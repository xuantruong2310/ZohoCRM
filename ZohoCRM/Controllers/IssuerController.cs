﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZCRMSDK.CRM.Library.Api.Response;
using ZCRMSDK.CRM.Library.Common;
using ZCRMSDK.CRM.Library.CRUD;
using ZCRMSDK.CRM.Library.Setup.MetaData;
using ZCRMSDK.CRM.Library.Setup.RestClient;
using ZCRMSDK.CRM.Library.Setup.Users;
using ZCRMSDK.OAuth.Client;
using ZCRMSDK.OAuth.Contract;
using ZohoCRM.DB;
using ZohoCRM.Models;

namespace ZohoCRM.Controllers
{
    public class IssuerController : ApiController
    {
        

        [HttpGet]
        // GET api/issuer
        public List<IssuerModel> Data()
        {
            var dbContext = new MS_UATEntities();
            var res = dbContext.Database.SqlQuery<IssuerModel>("select noactive.*, case when LoanStatus=8 then 'nonactive' else 'active' end as loanstatus,case when LoanRequestID is not null then ' ' end as Stage  from ( select company.BusinessName, nocompany.* from( select z.*, y.lastrepaymentdate, x.DAYS_OVERDUE, convert(decimal(18, 2), x.overdueamount) as overdueamount, w.numofoutstandingrepayment, w.numofoverduerepayment, w.numofpaidrepayment, w.totalnumofrepayment, convert(decimal(18, 2), v.outamountwithoutlf) as outamountwithoutlf, convert(decimal(18, 2), v.outamountwitlf) as outamountwithlf, convert(decimal(18, 2), v.outstandinglf) as outstandinglf, u.FinalAmount, convert(decimal(18, 2), s.paidlatefees) as paidlatefees, convert(decimal(18, 2), r.totalpaidamount) as totalpaidamount, q.accepteddate from( select loanrequestid, min(iif(paystatus = 2, duedate, null)) as overduesincedate from issuerrepayment group by LoanRequestID) as z left join( select LoanRequestID, max(date) as lastrepaymentdate from issuerrepayment right join issuerrepaymentpayment on issuerrepayment.IssuerRepID = IssuerRepaymentPayment.IssuerRepID group by LoanRequestID) as y on z.LoanRequestID = y.LoanRequestID left join( select a1.*, b1.overdueamount from( select loanrequestid, isnull(DATEDIFF(day, MIN(IIF(PAYSTATUS <> 1, DUEDATE, NULL)), GETDATE()), 0) AS DAYS_OVERDUE from issuerrepayment group by LoanRequestID) as a1 left join( Select distinct LoanRequestID, Case when paystatus = 2 then SUM(Principal - isnull(PaidPrincipal, 0) - isnull(PaidInterest, 0) + Interest + isnull(lateinterest, 0)) over(partition by loanrequestID) else 0 end as overdueamount from IssuerRepayment where PayStatus = 2 ) as b1 on a1.LoanRequestID = b1.LoanRequestID) as x on z.LoanRequestID = x.LoanRequestID left join( select t.*,isnull(numpaid.numofpaidrepayment, 0) as numofpaidrepayment, isnull(numoverdue.numofoverduerepayment, 0) as numofoverduerepayment, isnull(numoutstanding.numofoutstandingrepayment, 0) as numofoutstandingrepayment from(     select LoanRequestID, count(issuerrepid) as totalnumofrepayment    from IssuerRepayment group by LoanRequestID) as t left join( select LoanRequestID, count(issuerrepid) as numofpaidrepayment from IssuerRepayment where PayStatus = 1 group by LoanRequestID) as numpaid on t.LoanRequestID = numpaid.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoverduerepayment from IssuerRepayment where PayStatus = 2 group by LoanRequestID ) as numoverdue on t.LoanRequestID = numoverdue.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoutstandingrepayment from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as numoutstanding on t.LoanRequestID = numoutstanding.LoanRequestID) as w on z.LoanRequestID = w.LoanRequestID left join( select LoanRequestID, sum((isnull(latefees,0)-isnull(paidlatefees, 0))*(1 - isfeewaiver))as outstandinglf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0)) as outamountwithoutlf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0) + (isnull(latefees, 0) - isnull(paidlatefees, 0)) * (1 - isfeewaiver)) as outamountwitlf from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as v on z.LoanRequestID = v.LoanRequestID left join( select RequestId, FinalAmount from tbl_LoanRequests ) as u on z.LoanRequestID = u.RequestId left join( select loanrequestid, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalamountpaid from issuerrepayment group by loanrequestid) t     on z.LoanRequestID = t.LoanRequestID left join( select loanrequestid, sum(isnull(paidlatefees,0)) as paidlatefees from issuerrepayment where IsFeeWaiver = 0 group by loanrequestid) as s on z.LoanRequestID = s.LoanRequestID left join( select case when a.LoanRequestID is not null then a.LoanRequestID else b.LoanRequestID end as loanrequestid, isnull(totalpaid, 0) + isnull(totalpaida, 0) as totalpaidamount from(  select LoanRequestID, sum(amount + isnull(PaidLateInterest, 0)) as totalpaid from IssuerRepayment where paystatus = 1 group by LoanRequestID) as a full join(select LoanRequestID, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalpaida from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as b on a.loanrequestid = b.loanrequestid ) as r on z.LoanRequestID = r.loanrequestid left join( select requestid, accepteddate from tbl_loanrequests) as q on z.loanrequestid = q.requestid  ) as nocompany left join( select accountdetails.BusinessName, tbl_loanrequests.RequestId from tbl_loanrequests left join(select BusinessName, NRIC_Number, USER_ID from tbl_AccountDetails) as accountdetails on accountdetails.user_ID = tbl_loanrequests.user_ID) as company on nocompany.LoanRequestID = company.RequestId ) as noactive left join( select RequestId, LoanStatus from tbl_LoanRequests ) as active on noactive.LoanRequestID = active.RequestId  ").ToList();

            return res;
        }


        // POST api/issuer
        public List<ZCRMRecord> Post()
        {

            ZCRMRestClient.Initialize(config);
            //ZohoOAuthClient client = ZohoOAuthClient.GetInstance();
            //string grantToken = "1000.ff2d89ee2fcc27078e8ebe5cd5a0931c.f2a7e1c721219ee53995f757d45fe4d7";
            //ZohoOAuthTokens tokens = client.GenerateAccessToken(grantToken);
            //string accessToken = tokens.AccessToken;
            //string refreshToken = tokens.RefreshToken;
            List<ZCRMRecord> records = new List<ZCRMRecord>();
            var dbContext = new MS_UATEntities();
            var data = dbContext.Database.SqlQuery<IssuerModel>("select noactive.*, case when LoanStatus=8 then 'nonactive' else 'active' end as loanstatus,case when LoanRequestID is not null then ' ' end as Stage  from ( select company.BusinessName, nocompany.* from( select z.*, y.lastrepaymentdate, x.DAYS_OVERDUE, convert(decimal(18, 2), x.overdueamount) as overdueamount, w.numofoutstandingrepayment, w.numofoverduerepayment, w.numofpaidrepayment, w.totalnumofrepayment, convert(decimal(18, 2), v.outamountwithoutlf) as outamountwithoutlf, convert(decimal(18, 2), v.outamountwitlf) as outamountwithlf, convert(decimal(18, 2), v.outstandinglf) as outstandinglf, u.FinalAmount, convert(decimal(18, 2), s.paidlatefees) as paidlatefees, convert(decimal(18, 2), r.totalpaidamount) as totalpaidamount, q.accepteddate from( select loanrequestid, min(iif(paystatus = 2, duedate, null)) as overduesincedate from issuerrepayment group by LoanRequestID) as z left join( select LoanRequestID, max(date) as lastrepaymentdate from issuerrepayment right join issuerrepaymentpayment on issuerrepayment.IssuerRepID = IssuerRepaymentPayment.IssuerRepID group by LoanRequestID) as y on z.LoanRequestID = y.LoanRequestID left join( select a1.*, b1.overdueamount from( select loanrequestid, isnull(DATEDIFF(day, MIN(IIF(PAYSTATUS <> 1, DUEDATE, NULL)), GETDATE()), 0) AS DAYS_OVERDUE from issuerrepayment group by LoanRequestID) as a1 left join( Select distinct LoanRequestID, Case when paystatus = 2 then SUM(Principal - isnull(PaidPrincipal, 0) - isnull(PaidInterest, 0) + Interest + isnull(lateinterest, 0)) over(partition by loanrequestID) else 0 end as overdueamount from IssuerRepayment where PayStatus = 2 ) as b1 on a1.LoanRequestID = b1.LoanRequestID) as x on z.LoanRequestID = x.LoanRequestID left join( select t.*,isnull(numpaid.numofpaidrepayment, 0) as numofpaidrepayment, isnull(numoverdue.numofoverduerepayment, 0) as numofoverduerepayment, isnull(numoutstanding.numofoutstandingrepayment, 0) as numofoutstandingrepayment from(     select LoanRequestID, count(issuerrepid) as totalnumofrepayment    from IssuerRepayment group by LoanRequestID) as t left join( select LoanRequestID, count(issuerrepid) as numofpaidrepayment from IssuerRepayment where PayStatus = 1 group by LoanRequestID) as numpaid on t.LoanRequestID = numpaid.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoverduerepayment from IssuerRepayment where PayStatus = 2 group by LoanRequestID ) as numoverdue on t.LoanRequestID = numoverdue.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoutstandingrepayment from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as numoutstanding on t.LoanRequestID = numoutstanding.LoanRequestID) as w on z.LoanRequestID = w.LoanRequestID left join( select LoanRequestID, sum((isnull(latefees,0)-isnull(paidlatefees, 0))*(1 - isfeewaiver))as outstandinglf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0)) as outamountwithoutlf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0) + (isnull(latefees, 0) - isnull(paidlatefees, 0)) * (1 - isfeewaiver)) as outamountwitlf from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as v on z.LoanRequestID = v.LoanRequestID left join( select RequestId, FinalAmount from tbl_LoanRequests ) as u on z.LoanRequestID = u.RequestId left join( select loanrequestid, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalamountpaid from issuerrepayment group by loanrequestid) t     on z.LoanRequestID = t.LoanRequestID left join( select loanrequestid, sum(isnull(paidlatefees,0)) as paidlatefees from issuerrepayment where IsFeeWaiver = 0 group by loanrequestid) as s on z.LoanRequestID = s.LoanRequestID left join( select case when a.LoanRequestID is not null then a.LoanRequestID else b.LoanRequestID end as loanrequestid, isnull(totalpaid, 0) + isnull(totalpaida, 0) as totalpaidamount from(  select LoanRequestID, sum(amount + isnull(PaidLateInterest, 0)) as totalpaid from IssuerRepayment where paystatus = 1 group by LoanRequestID) as a full join(select LoanRequestID, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalpaida from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as b on a.loanrequestid = b.loanrequestid ) as r on z.LoanRequestID = r.loanrequestid left join( select requestid, accepteddate from tbl_loanrequests) as q on z.loanrequestid = q.requestid  ) as nocompany left join( select accountdetails.BusinessName, tbl_loanrequests.RequestId from tbl_loanrequests left join(select BusinessName, NRIC_Number, USER_ID from tbl_AccountDetails) as accountdetails on accountdetails.user_ID = tbl_loanrequests.user_ID) as company on nocompany.LoanRequestID = company.RequestId ) as noactive left join( select RequestId, LoanStatus from tbl_LoanRequests ) as active on noactive.LoanRequestID = active.RequestId  ").ToList();
            //foreach (var rc in data)
            //{
            ZCRMRecord record1 = new ZCRMRecord("leads"); //module api name
            record1.SetFieldValue("CompanyName", "rc.CompanyName");
            record1.SetFieldValue("FullName", "rc.FullName");
            record1.SetFieldValue("UserName", "rc.UserName");
            record1.SetFieldValue("MobileNumber", "rc.MobileNumber");
            record1.SetFieldValue("IssuerAccountBalance", "rc.IssuerAccountBalance");
            record1.SetFieldValue("OverdueDate", "rc.OverdueDate");
            record1.SetFieldValue("TotalAmountDisbursed", "rc.TotalAmountDisbursed");
            record1.SetFieldValue("TotalAmountOverdue", "rc.TotalAmountOverdue");
            record1.SetFieldValue("OutstandingLateFee", "rc.OutstandingLateFee");
            record1.SetFieldValue("OutstandingAmountNoLateFee", "rc.OutstandingAmountNoLateFee");
            record1.SetFieldValue("OutstandingAmountWithLateFee", "rc.OutstandingAmountWithLateFee");
            record1.SetFieldValue("LastRepaymentDate", "rc.LastRepaymentDate");
            record1.SetFieldValue("TotalFeesPaid", "rc.TotalFeesPaid");
            record1.SetFieldValue("TotalPrincipalPaid", "rc.TotalPrincipalPaid");
            record1.SetFieldValue("TotalInterestPaid", "rc.TotalInterestPaid");
            record1.SetFieldValue("TotalLateInterestPaid", " rc.TotalLateInterestPaid");
            records.Add(record1);
            //ZCRMModule moduleIns = ZCRMModule.GetInstance("Leads"); //module api name
            //BulkAPIResponse<ZCRMRecord> response = moduleIns.CreateRecords(records);
            // }
            ZCRMModule moduleIns = ZCRMModule.GetInstance("leads"); //module api name
            BulkAPIResponse<ZCRMRecord> response = moduleIns.CreateRecords(records); //records - list of ZCRMRecord instances filled with required data for upsert.
            List<ZCRMRecord> upsertedRecords = response.BulkData; //upsertedRecords - list of ZCRMRecord instance
            List<EntityResponse> entityResponses = response.BulkEntitiesResponse; //entityResponses - list of EntityResponses instance
            return records;
        }


        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //        public static Dictionary<string, string> config = new Dictionary<string, string>()
        //{
        //{"client_id","1000.332AUI1NR8D5H2I1ZWNNE0YK3ATEUH"},
        //{"client_secret","dfaa9671df3bd747d7b9cac10be1103a924a5f1143"},
        //{"redirect_uri","https://www.google.com.vn"},
        //{"access_type","offline"},
        //{"persistence_handler_class","ZCRMSDK.OAuth.ClientApp.ZohoOAuthDBPersistence, ZCRMSDK"},
        //{"oauth_tokens_file_path","{file_path}"},
        //{"mysql_username","9a9cca_zoho"},
        //{"mysql_password","Vbn*34295"},
        //{"mysql_database","db_9a9cca_zoho"},
        //{"mysql_server","MYSQL5022.site4now.net"},
        //{"mysql_port","3306"},
        //{"apiBaseUrl","{https://www.zohoapis.com}"},
        //{"photoUrl","{photo_url}"},
        //{"apiVersion","v2"},
        //{"logFilePath","{log_file_path}" },
        //{"timeout",""},
        //{"minLogLevel",""},
        //{"domainSuffix","com"},
        //{"currentUserEmail","nguyen.quang.tuyen@moolahsense.com"}

        //};
        //    }
        public static Dictionary<string, string> config = new Dictionary<string, string>()
{
{"client_id","1000.332AUI1NR8D5H2I1ZWNNE0YK3ATEUH"},
{"client_secret","dfaa9671df3bd747d7b9cac10be1103a924a5f1143"},
{"redirect_uri","https://www.google.com.vn"},
{"access_type","offline"},
{"persistence_handler_class","ZCRMSDK.OAuth.ClientApp.ZohoOAuthDBPersistence, ZCRMSDK"},
{"oauth_tokens_file_path",""},
{"mysql_username","9a9cca_zoho"},
{"mysql_password","Vbn*34295"},
{"mysql_database","db_9a9cca_zoho"},
{"mysql_server","MYSQL5022.site4now.net"},
{"mysql_port","3306"},
{"apiBaseUrl","https://www.zohoapis.com"},
{"photoUrl",""},
{"apiVersion","v2"},
{"logFilePath","" },
{"timeout",""},
{"minLogLevel",""},
{"domainSuffix","com"},
{"currentUserEmail","nguyen.quang.tuyen@moolahsense.com"}
};
    }
}