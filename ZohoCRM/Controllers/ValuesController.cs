using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
using ZohoCRM.Services;

namespace ZohoCRM.Controllers
{
    public class ValuesController : ApiController
    {
        // IService _iservice;
        DatabaseZohoEntities dbzoho = new DatabaseZohoEntities();


        // GET api/values
        public void Get()
        {
         
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            var dbContext = new MS_DEVEntities();
            ZohoService sc = new ZohoService();
            //var datainvestor = dbContext.Database.SqlQuery<InvestorModel>("select investorinfo.*,investamount.totalinvestedamount,investamount.paidP,paidI,paidLI,TotalAmountReceived,currentinFunding,numberofinvested,convert(decimal(18,2),Closeoff_PI)as Closeoff_PI,numofcloseoff,numberoffullypaidnotes,numofdelinquent,convert(decimal(18,2),outstanding_I)as outstanding_I,convert(decimal(18,2),outstanding_P)as outstanding_P,convert(decimal(18,2),outstandingPI)as outstandingPI from ( select oldinformation.*, newinformation.age, newinformation.FullName, newinformation.Gender, newinformation.Mobilenumber, newinformation.Nationality, newinformation.DateofBirth, newinformation.NRIC_Number, newinformation.PassportNumber from( select almost.*, lastlogin from( select users.*, ActualAmount from( select USER_ID, ActualAmount from tbl_Balances where User_ID is not null) as balance left join( select UserID, username, QualifiedDate, AdminVerification, DateCreated from tbl_users ) as users on balance.User_ID = users.UserID) as almost left join( select  UserName, max(timestamp) as lastlogin from tbl_AuditLog group by UserName) as pre on almost.UserName = pre.UserName) as oldinformation left join( select User_ID, FullName, Gender, DateofBirth, datediff(year, DateofBirth, getdate()) as age, NRIC_Number, PassportNumber, Mobilenumber, Nationality  from tbl_AccountDetails) as newinformation on oldinformation.UserID = newinformation.User_ID) as investorinfo left join( select totalinvested.*,paidI,paidP,paidLI,TotalAmountReceived,OfferedAmount as currentinFunding,numberofinvested,Closeoff_PI,numofcloseoff,numberoffullypaidnotes,outstanding_I,outstanding_P,outstandingPI,numofdelinquent From( select Investor_Id, sum(acceptedamount) as totalinvestedamount   from( select  OfferId, Investor_Id, case when LoanRequest_Id in (2036, 2001, 2037, 2019, 2004, 2059, 2020, 1994, 2053) then 0   else AcceptedAmount end as acceptedamount,LoanRequest_Id,case when LoanRequest_Id = 2001 then concat('2001','-',offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a where acceptedamount<>0  group by Investor_Id) as totalinvested left join( select Investor_Id,convert(decimal(18, 2), sum(isnull(paidinterest, 0))) as paidI, convert(decimal(18, 2), sum(isnull(paidprincipal, 0))) as paidP,convert(decimal(18, 2), sum(isnull(paidlateinterest, 0))) as paidLI, convert(decimal(18, 2), sum(isnull(paidinterest, 0) + isnull(paidprincipal, 0) + isnull(paidlateinterest, 0))) as TotalAmountReceived from( select pre1.Investor_Id, pre1.AcceptedAmount, pre1.LoanRequest_Id, pre1.newcontractid, InvestorRepaymentPayment.* from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1 ) as pre1 join InvestorRepaymentPayment on pre1.OfferId = InvestorRepaymentPayment.OfferID ) as paidamount group by Investor_Id) as totalpaidamount on totalinvested.Investor_Id = totalpaidamount.Investor_Id left join( select Investor_Id,OfferedAmount from tbl_Loanoffers join( select* from tbl_LoanRequests where LoanStatus= 2) as a on tbl_Loanoffers.LoanRequest_Id = a.RequestId) as currentfunding on totalinvested.Investor_Id = currentfunding.Investor_Id left join( select Investor_Id,count(totalinvested) as numberofinvested from( select Investor_Id, sum(acceptedamount) as totalinvested, LoanRequest_Id   from( select  OfferId, Investor_Id, case when LoanRequest_Id in (2036, 2001, 2037, 2019, 2004, 2059, 2020, 1994, 2053) then 0   else AcceptedAmount end as acceptedamount,LoanRequest_Id,case when LoanRequest_Id = 2001 then concat('2001','-',offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a where acceptedamount<>0  group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofinvest on totalinvested.Investor_Id = numberofinvest.Investor_Id left join( select Investor_Id,sum(Principal - isnull(paidprincipal, 0) + interest - isnull(paidinterest, 0)) as Closeoff_PI from( select b.*, c.Investor_Id, c.AcceptedAmount, c.newcontractid from( select a.* From( select InvestorRepayment.*, LoanRequest_Id from InvestorRepayment left join tbl_Loanoffers on InvestorRepayment.OfferID = tbl_Loanoffers.OfferId) as a  left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 9) as b left join( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as c on b.OfferId = c.OfferId) as d where PayStatus<>1 group by Investor_Id) as closeoffamount on totalinvested.Investor_Id = closeoffamount.Investor_Id left join( select Investor_Id, count(totalclose) as numofcloseoff from( select a.Investor_Id, sum(AcceptedAmount) as totalclose, LoanRequest_Id from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 9 group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofcloseoff on totalinvested.Investor_Id = numberofcloseoff.Investor_Id left join( select Investor_Id,count(amount) as numberoffullypaidnotes from( select Investor_Id, sum(acceptedamount) as amount, LoanRequest_Id from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 7 group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as fully on totalinvested.Investor_Id = fully.Investor_Id left join( select Investor_Id,sum(principal - isnull(paidprincipal, 0)) as outstanding_P, sum(Interest - isnull(paidinterest, 0)) as outstanding_I, sum(principal + interest - isnull(paidprincipal, 0) - isnull(paidinterest, 0)) as outstandingPI  from( select b.*, Investor_Id from( select a.* From( select InvestorRepayment.*, LoanRequest_Id from InvestorRepayment left join tbl_Loanoffers on InvestorRepayment.OfferID = tbl_Loanoffers.OfferId) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus in (3, 5, 7, 9)) as b left join( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as c on b.OfferID = c.OfferId) as final where PayStatus<>1 group by Investor_Id) as deliquentamount on totalinvested.Investor_Id = deliquentamount.Investor_Id left join( select Investor_Id,count(LoanRequest_Id) as numofdelinquent from( select Investor_Id, sum(acceptedamount) as amount, LoanRequest_Id from( select a.*, RequestId from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join(select* from tbl_LoanRequests where LoanStatus in (3,5,9) ) as b on a.LoanRequest_Id = b.RequestId where RequestId is not null) as pre group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofdelinquent on totalinvested.Investor_Id = numberofdelinquent.Investor_Id) as investamount on investorinfo.UserID = investamount.Investor_Id").ToList();
            var dataissuer = dbContext.Database.SqlQuery<IssuerModel>("select BusinessName,FullName,Mobilenumber,UserName,ActualAmount,max(daysoverdue) as daysoverdue, sum(totaldisbursed) as totaldisbursed, convert(decimal(18,2),sum(isnull(overdueamount,0)))as overdueamount, convert(decimal(18,2),sum(isnull(outstandinglf,0)))as outstandinglf,convert(decimal(18,2),sum(isnull(outamountwithoutlf,0)))as outamountwithoutlf,convert(decimal(18,2),sum(isnull(outamountwithlf,0)))as outamountwithlf, max(lastrepaymentdate)as lastrepaymentdate,convert(decimal(18,2), sum(isnull(totalpaidamount,0)))as totalpaidamount,convert(decimal(18,2),sum(isnull(totalpaidprincipal,0)))as totalpaidprincipal,convert(decimal(18,2),sum(isnull(totalpaidinterest,0)))as totalpaidinterest,convert(decimal(18,2), sum(isnull(totalpaidlateinterest,0)))as totalpaidlateinterest,convert(decimal(18,2),sum(isnull(paidlatefees,0)))as paidlatefees from( select company.BusinessName, company.FullName,case when company.Mobilenumber = '94389427' and company.UserName = 'exproof.moolah@gmail.com_delete_9/11/2019 6:37:47 AM' then '97521852' else company.Mobilenumber end as Mobilenumber,case when company.UserName = 'exproof.moolah@gmail.com_delete_9/11/2019 6:37:47 AM' then 'eric.tan@exproof.com.sg' else company.UserName end as UserName,company.ActualAmount,max(DAYS_OVERDUE) as daysoverdue, sum(finalamount) as totaldisbursed, sum(isnull(overdueamount, 0)) as overdueamount, sum(isnull(outstandinglf, 0)) as outstandinglf,sum(isnull(outamountwithoutlf, 0)) as outamountwithoutlf,sum(isnull(outamountwithlf, 0)) as outamountwithlf, max(lastrepaymentdate) as lastrepaymentdate, sum(isnull(totalpaidamount, 0)) as totalpaidamount,sum(isnull(totalpaidprincipal, 0)) as totalpaidprincipal,sum(isnull(totalpaidinterest, 0)) as totalpaidinterest, sum(isnull(totalpaidlateinterest, 0)) as totalpaidlateinterest,sum(isnull(paidlatefees, 0)) as paidlatefees from(  select LoanRequestID, overduesincedate, lastrepaymentdate,case when LoanStatus = 8 then 0 else DAYS_OVERDUE end as days_overdue, case when loanstatus = 8 then 0 else overdueamount end as overdueamount,case when loanstatus = 8 then 0 else outamountwithoutlf end as outamountwithoutlf, case when LoanStatus = 8 then 0 else outamountwitlf end as outamountwithlf,case when LoanStatus = 8 then 0 else outstandinglf end as outstandinglf,case when LoanRequestID in (2036, 2001, 2037, 2019, 2004, 2059, 2020, 1994, 2053) then 0 else FinalAmount end as FinalAmount, paidlatefees,totalpaidamount,totalpaidprincipal,totalpaidinterest,totalpaidlateinterest from(  select z.*,y.lastrepaymentdate,x.DAYS_OVERDUE,x.overdueamount,w.numofoutstandingrepayment,w.numofoverduerepayment,w.numofpaidrepayment,w.totalnumofrepayment,v.outamountwithoutlf,v.outamountwitlf,v.outstandinglf,u.FinalAmount,s.paidlatefees,r.totalpaidamount,q.accepteddate,p.totalpaidprincipal,o.totalpaidinterest,n.totalpaidlateinterest,m.LoanStatus from(                   select loanrequestid, min(iif(paystatus= 2, duedate,null)) as overduesincedate from issuerrepayment group by LoanRequestID) as z left join( select LoanRequestID, max(date) as lastrepaymentdate from issuerrepayment right join issuerrepaymentpayment  on issuerrepayment.IssuerRepID = IssuerRepaymentPayment.IssuerRepID group by LoanRequestID) as y on z.LoanRequestID = y.LoanRequestID left join( select a1.*,b1.overdueamount from( select loanrequestid, isnull(DATEDIFF(day, MIN(IIF(PAYSTATUS<> 1,DUEDATE, NULL)),GETDATE()),0) AS DAYS_OVERDUE from issuerrepayment group by LoanRequestID ) as a1 left join( Select distinct LoanRequestID, Case when paystatus = 2 then SUM(Principal -isnull(PaidPrincipal, 0) - isnull(PaidInterest, 0) + Interest + isnull(lateinterest, 0)) over(partition by loanrequestID) else 0 end as overdueamount from IssuerRepayment where PayStatus = 2 ) as b1 on a1.LoanRequestID = b1.LoanRequestID) as x on z.LoanRequestID = x.LoanRequestID left join( select t.*,isnull(numpaid.numofpaidrepayment, 0) as numofpaidrepayment, isnull(numoverdue.numofoverduerepayment, 0) as numofoverduerepayment, isnull(numoutstanding.numofoutstandingrepayment, 0) as numofoutstandingrepayment from( select LoanRequestID, count(issuerrepid) as totalnumofrepayment  from IssuerRepayment group by LoanRequestID) as t left join( select LoanRequestID, count(issuerrepid) as numofpaidrepayment from IssuerRepayment where PayStatus = 1 group by LoanRequestID) as numpaid on t.LoanRequestID = numpaid.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoverduerepayment from IssuerRepayment where PayStatus = 2 group by LoanRequestID ) as numoverdue on t.LoanRequestID = numoverdue.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoutstandingrepayment from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as numoutstanding on t.LoanRequestID = numoutstanding.LoanRequestID) as w on z.LoanRequestID = w.LoanRequestID left join( select LoanRequestID, sum((isnull(latefees,0)-isnull(paidlatefees, 0))*(1 - isfeewaiver))as outstandinglf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0)) as outamountwithoutlf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0) + (isnull(latefees, 0) - isnull(paidlatefees, 0)) * (1 - isfeewaiver)) as outamountwitlf from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as v on z.LoanRequestID = v.LoanRequestID left join( select RequestId, FinalAmount from tbl_LoanRequests ) as u on z.LoanRequestID = u.RequestId left join( select loanrequestid, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalamountpaid from issuerrepayment group by loanrequestid) t on z.LoanRequestID = t.LoanRequestID left join( select loanrequestid, sum(isnull(paidlatefees,0)) as paidlatefees from issuerrepayment where IsFeeWaiver = 0 group by loanrequestid) as s on z.LoanRequestID = s.LoanRequestID left join( select case when a.LoanRequestID is not null then a.LoanRequestID else b.LoanRequestID end as loanrequestid, isnull(totalpaid, 0) + isnull(totalpaida, 0) as totalpaidamount from(  select LoanRequestID, sum(amount + isnull(PaidLateInterest, 0)) as totalpaid from IssuerRepayment where paystatus = 1 group by LoanRequestID) as a full join(select LoanRequestID, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalpaida from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as b on a.loanrequestid = b.loanrequestid ) as r on z.LoanRequestID = r.loanrequestid left join( select requestid, accepteddate from tbl_loanrequests) as q on z.loanrequestid = q.requestid left join( select case when a.LoanRequestID is not null then a.LoanRequestID else b.LoanRequestID end as loanrequestid, isnull(totalpaid, 0) + isnull(totalpaida, 0) as totalpaidprincipal from( select LoanRequestID, sum(Principal) as totalpaid from IssuerRepayment where paystatus = 1 group by LoanRequestID) as a full join(select LoanRequestID, sum(isnull(paidprincipal,0)) as totalpaida from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as b on a.loanrequestid = b.loanrequestid) as p on z.LoanRequestID = p.loanrequestid left join( select case when a.LoanRequestID is not null then a.LoanRequestID else b.LoanRequestID end as loanrequestid, isnull(totalpaid, 0) + isnull(totalpaida, 0) as totalpaidinterest from(  select LoanRequestID, sum(interest) as totalpaid from IssuerRepayment where paystatus = 1 group by LoanRequestID) as a full join(select LoanRequestID, sum(isnull(PaidInterest,0)) as totalpaida from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as b on a.loanrequestid = b.loanrequestid) as o on z.LoanRequestID = o.loanrequestid left join( select case when a.LoanRequestID is not null then a.LoanRequestID else b.LoanRequestID end as loanrequestid, isnull(totalpaid, 0) + isnull(totalpaida, 0) as totalpaidlateinterest from(  select LoanRequestID, sum(isnull(paidlateinterest, 0)) as totalpaid from IssuerRepayment where paystatus = 1 group by LoanRequestID) as a full join(select LoanRequestID, sum(isnull(PaidInterest,0)) as totalpaida from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as b on a.loanrequestid = b.loanrequestid) as n on z.LoanRequestID = n.loanrequestid left join( select RequestId, LoanStatus from tbl_loanRequests) as m on z.LoanRequestID = m.RequestId ) as notelevelmini  ) as notelevel left join( select accountdetails.BusinessName, tbl_loanrequests.RequestId, accountdetails.FullName, accountdetails.Mobilenumber, users.UserName, balance.ActualAmount from tbl_loanrequests left join(select BusinessName, NRIC_Number, USER_ID, FullName, Mobilenumber from tbl_AccountDetails) as accountdetails on accountdetails.user_ID = tbl_loanrequests.user_ID left join( select userid, username from tbl_Users) as users on tbl_LoanRequests.User_ID = users.UserID left join( select User_ID, ActualAmount from tbl_Balances) as balance on tbl_LoanRequests.User_ID = balance.User_ID) as company on notelevel.LoanRequestID = company.RequestId group by BusinessName, fullname, UserName, Mobilenumber,ActualAmount) as abc group by BusinessName,FullName,UserName,Mobilenumber,ActualAmount ").ToList();
            try
            {
                foreach (var item in dataissuer)
                {
                    var checkid = dbzoho.tbl_CheckID.FirstOrDefault(p => p.EmailMS == item.UserName);
                    if (checkid == null)
                    {

                        sc.InsertIssuer(item);

                    }
                    else
                    {
                        sc.UpdateIssuer(item);
                    }
                }
                //foreach (var investor in datainvestor)
                //{
                //    var checkid = dbzoho.tbl_CheckID.FirstOrDefault(p => p.EmailMS == investor.UserName);
                //    if (checkid == null)
                //    {

                //        sc.InsertInvestor(investor);

                //    }
                //    else
                //    {
                //        sc.UpdateInvestor(investor);
                //    }
                //}
            }
            catch (Exception ex)
            {

            }
            return;
        }

        // PUT api/values/5
        public void Put()
        {
           
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

       
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
