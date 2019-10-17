using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    public class InvestorController : ApiController
    {
        // GET api/investor
        public List<InvestorModel> Get()
        {
            var dbContext = new MS_DEVEntities();
            var res = dbContext.Database.SqlQuery<InvestorModel>("select investorinfo.*,investamount.totalinvestedamount,investamount.paidP,paidI,paidLI,TotalAmountReceived,currentinFunding,numberofinvested,convert(decimal(18,2),Closeoff_PI)as Closeoff_PI,numofcloseoff,numberoffullypaidnotes,numofdelinquent,convert(decimal(18,2),outstanding_I)as outstanding_I,convert(decimal(18,2),outstanding_P)as outstanding_P,convert(decimal(18,2),outstandingPI)as outstandingPI from ( select oldinformation.*, newinformation.age, newinformation.FullName, newinformation.Gender, newinformation.Mobilenumber, newinformation.Nationality, newinformation.DateofBirth, newinformation.NRIC_Number, newinformation.PassportNumber from( select almost.*, lastlogin from( select users.*, ActualAmount from( select USER_ID, ActualAmount from tbl_Balances where User_ID is not null) as balance left join( select UserID, username, QualifiedDate, AdminVerification, DateCreated from tbl_users ) as users on balance.User_ID = users.UserID) as almost left join( select  UserName, max(timestamp) as lastlogin from tbl_AuditLog group by UserName) as pre on almost.UserName = pre.UserName) as oldinformation left join( select User_ID, FullName, Gender, DateofBirth, datediff(year, DateofBirth, getdate()) as age, NRIC_Number, PassportNumber, Mobilenumber, Nationality  from tbl_AccountDetails) as newinformation on oldinformation.UserID = newinformation.User_ID) as investorinfo left join( select totalinvested.*,paidI,paidP,paidLI,TotalAmountReceived,OfferedAmount as currentinFunding,numberofinvested,Closeoff_PI,numofcloseoff,numberoffullypaidnotes,outstanding_I,outstanding_P,outstandingPI,numofdelinquent From( select Investor_Id, sum(acceptedamount) as totalinvestedamount   from( select  OfferId, Investor_Id, case when LoanRequest_Id in (2036, 2001, 2037, 2019, 2004, 2059, 2020, 1994, 2053) then 0   else AcceptedAmount end as acceptedamount,LoanRequest_Id,case when LoanRequest_Id = 2001 then concat('2001','-',offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a where acceptedamount<>0  group by Investor_Id) as totalinvested left join( select Investor_Id,convert(decimal(18, 2), sum(isnull(paidinterest, 0))) as paidI, convert(decimal(18, 2), sum(isnull(paidprincipal, 0))) as paidP,convert(decimal(18, 2), sum(isnull(paidlateinterest, 0))) as paidLI, convert(decimal(18, 2), sum(isnull(paidinterest, 0) + isnull(paidprincipal, 0) + isnull(paidlateinterest, 0))) as TotalAmountReceived from( select pre1.Investor_Id, pre1.AcceptedAmount, pre1.LoanRequest_Id, pre1.newcontractid, InvestorRepaymentPayment.* from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1 ) as pre1 join InvestorRepaymentPayment on pre1.OfferId = InvestorRepaymentPayment.OfferID ) as paidamount group by Investor_Id) as totalpaidamount on totalinvested.Investor_Id = totalpaidamount.Investor_Id left join( select Investor_Id,OfferedAmount from tbl_Loanoffers join( select* from tbl_LoanRequests where LoanStatus= 2) as a on tbl_Loanoffers.LoanRequest_Id = a.RequestId) as currentfunding on totalinvested.Investor_Id = currentfunding.Investor_Id left join( select Investor_Id,count(totalinvested) as numberofinvested from( select Investor_Id, sum(acceptedamount) as totalinvested, LoanRequest_Id   from( select  OfferId, Investor_Id, case when LoanRequest_Id in (2036, 2001, 2037, 2019, 2004, 2059, 2020, 1994, 2053) then 0   else AcceptedAmount end as acceptedamount,LoanRequest_Id,case when LoanRequest_Id = 2001 then concat('2001','-',offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a where acceptedamount<>0  group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofinvest on totalinvested.Investor_Id = numberofinvest.Investor_Id left join( select Investor_Id,sum(Principal - isnull(paidprincipal, 0) + interest - isnull(paidinterest, 0)) as Closeoff_PI from( select b.*, c.Investor_Id, c.AcceptedAmount, c.newcontractid from( select a.* From( select InvestorRepayment.*, LoanRequest_Id from InvestorRepayment left join tbl_Loanoffers on InvestorRepayment.OfferID = tbl_Loanoffers.OfferId) as a  left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 9) as b left join( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as c on b.OfferId = c.OfferId) as d where PayStatus<>1 group by Investor_Id) as closeoffamount on totalinvested.Investor_Id = closeoffamount.Investor_Id left join( select Investor_Id, count(totalclose) as numofcloseoff from( select a.Investor_Id, sum(AcceptedAmount) as totalclose, LoanRequest_Id from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 9 group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofcloseoff on totalinvested.Investor_Id = numberofcloseoff.Investor_Id left join( select Investor_Id,count(amount) as numberoffullypaidnotes from( select Investor_Id, sum(acceptedamount) as amount, LoanRequest_Id from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 7 group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as fully on totalinvested.Investor_Id = fully.Investor_Id left join( select Investor_Id,sum(principal - isnull(paidprincipal, 0)) as outstanding_P, sum(Interest - isnull(paidinterest, 0)) as outstanding_I, sum(principal + interest - isnull(paidprincipal, 0) - isnull(paidinterest, 0)) as outstandingPI  from( select b.*, Investor_Id from( select a.* From( select InvestorRepayment.*, LoanRequest_Id from InvestorRepayment left join tbl_Loanoffers on InvestorRepayment.OfferID = tbl_Loanoffers.OfferId) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus in (3, 5, 7, 9)) as b left join( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as c on b.OfferID = c.OfferId) as final where PayStatus<>1 group by Investor_Id) as deliquentamount on totalinvested.Investor_Id = deliquentamount.Investor_Id left join( select Investor_Id,count(LoanRequest_Id) as numofdelinquent from( select Investor_Id, sum(acceptedamount) as amount, LoanRequest_Id from( select a.*, RequestId from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join(select* from tbl_LoanRequests where LoanStatus in (3,5,9) ) as b on a.LoanRequest_Id = b.RequestId where RequestId is not null) as pre group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofdelinquent on totalinvested.Investor_Id = numberofdelinquent.Investor_Id) as investamount on investorinfo.UserID = investamount.Investor_Id").ToList();

            return res;
        }
       
        public List<ZCRMRecord> Post()
        {
            //test
            ZCRMRestClient.Initialize(config);
            ZohoOAuthClient client = ZohoOAuthClient.GetInstance();
            string refreshToken = "1000.354c162c19b5da4fc4053bc4e38dd27f.1e548f961cc913acbacd82fbad0a3387";
            string userMailId = "nguyen.quang.tuyen@moolahsense.com";
            ZohoOAuthTokens tokens = client.GenerateAccessTokenFromRefreshToken(refreshToken, userMailId);
            List<ZCRMRecord> records = new List<ZCRMRecord>();
            var dbContext = new MS_DEVEntities();
            var data = dbContext.Database.SqlQuery<InvestorModel>("select investorinfo.*,investamount.totalinvestedamount,investamount.paidP,paidI,paidLI,TotalAmountReceived,currentinFunding,numberofinvested,convert(decimal(18,2),Closeoff_PI)as Closeoff_PI,numofcloseoff,numberoffullypaidnotes,numofdelinquent,convert(decimal(18,2),outstanding_I)as outstanding_I,convert(decimal(18,2),outstanding_P)as outstanding_P,convert(decimal(18,2),outstandingPI)as outstandingPI from ( select oldinformation.*, newinformation.age, newinformation.FullName, newinformation.Gender, newinformation.Mobilenumber, newinformation.Nationality, newinformation.DateofBirth, newinformation.NRIC_Number, newinformation.PassportNumber from( select almost.*, lastlogin from( select users.*, ActualAmount from( select USER_ID, ActualAmount from tbl_Balances where User_ID is not null) as balance left join( select UserID, username, QualifiedDate, AdminVerification, DateCreated from tbl_users ) as users on balance.User_ID = users.UserID) as almost left join( select  UserName, max(timestamp) as lastlogin from tbl_AuditLog group by UserName) as pre on almost.UserName = pre.UserName) as oldinformation left join( select User_ID, FullName, Gender, DateofBirth, datediff(year, DateofBirth, getdate()) as age, NRIC_Number, PassportNumber, Mobilenumber, Nationality  from tbl_AccountDetails) as newinformation on oldinformation.UserID = newinformation.User_ID) as investorinfo left join( select totalinvested.*,paidI,paidP,paidLI,TotalAmountReceived,OfferedAmount as currentinFunding,numberofinvested,Closeoff_PI,numofcloseoff,numberoffullypaidnotes,outstanding_I,outstanding_P,outstandingPI,numofdelinquent From( select Investor_Id, sum(acceptedamount) as totalinvestedamount   from( select  OfferId, Investor_Id, case when LoanRequest_Id in (2036, 2001, 2037, 2019, 2004, 2059, 2020, 1994, 2053) then 0   else AcceptedAmount end as acceptedamount,LoanRequest_Id,case when LoanRequest_Id = 2001 then concat('2001','-',offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a where acceptedamount<>0  group by Investor_Id) as totalinvested left join( select Investor_Id,convert(decimal(18, 2), sum(isnull(paidinterest, 0))) as paidI, convert(decimal(18, 2), sum(isnull(paidprincipal, 0))) as paidP,convert(decimal(18, 2), sum(isnull(paidlateinterest, 0))) as paidLI, convert(decimal(18, 2), sum(isnull(paidinterest, 0) + isnull(paidprincipal, 0) + isnull(paidlateinterest, 0))) as TotalAmountReceived from( select pre1.Investor_Id, pre1.AcceptedAmount, pre1.LoanRequest_Id, pre1.newcontractid, InvestorRepaymentPayment.* from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1 ) as pre1 join InvestorRepaymentPayment on pre1.OfferId = InvestorRepaymentPayment.OfferID ) as paidamount group by Investor_Id) as totalpaidamount on totalinvested.Investor_Id = totalpaidamount.Investor_Id left join( select Investor_Id,OfferedAmount from tbl_Loanoffers join( select* from tbl_LoanRequests where LoanStatus= 2) as a on tbl_Loanoffers.LoanRequest_Id = a.RequestId) as currentfunding on totalinvested.Investor_Id = currentfunding.Investor_Id left join( select Investor_Id,count(totalinvested) as numberofinvested from( select Investor_Id, sum(acceptedamount) as totalinvested, LoanRequest_Id   from( select  OfferId, Investor_Id, case when LoanRequest_Id in (2036, 2001, 2037, 2019, 2004, 2059, 2020, 1994, 2053) then 0   else AcceptedAmount end as acceptedamount,LoanRequest_Id,case when LoanRequest_Id = 2001 then concat('2001','-',offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a where acceptedamount<>0  group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofinvest on totalinvested.Investor_Id = numberofinvest.Investor_Id left join( select Investor_Id,sum(Principal - isnull(paidprincipal, 0) + interest - isnull(paidinterest, 0)) as Closeoff_PI from( select b.*, c.Investor_Id, c.AcceptedAmount, c.newcontractid from( select a.* From( select InvestorRepayment.*, LoanRequest_Id from InvestorRepayment left join tbl_Loanoffers on InvestorRepayment.OfferID = tbl_Loanoffers.OfferId) as a  left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 9) as b left join( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as c on b.OfferId = c.OfferId) as d where PayStatus<>1 group by Investor_Id) as closeoffamount on totalinvested.Investor_Id = closeoffamount.Investor_Id left join( select Investor_Id, count(totalclose) as numofcloseoff from( select a.Investor_Id, sum(AcceptedAmount) as totalclose, LoanRequest_Id from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 9 group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofcloseoff on totalinvested.Investor_Id = numberofcloseoff.Investor_Id left join( select Investor_Id,count(amount) as numberoffullypaidnotes from( select Investor_Id, sum(acceptedamount) as amount, LoanRequest_Id from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus = 7 group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as fully on totalinvested.Investor_Id = fully.Investor_Id left join( select Investor_Id,sum(principal - isnull(paidprincipal, 0)) as outstanding_P, sum(Interest - isnull(paidinterest, 0)) as outstanding_I, sum(principal + interest - isnull(paidprincipal, 0) - isnull(paidinterest, 0)) as outstandingPI  from( select b.*, Investor_Id from( select a.* From( select InvestorRepayment.*, LoanRequest_Id from InvestorRepayment left join tbl_Loanoffers on InvestorRepayment.OfferID = tbl_Loanoffers.OfferId) as a left join tbl_LoanRequests on a.LoanRequest_Id = tbl_LoanRequests.RequestId where LoanStatus in (3, 5, 7, 9)) as b left join( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as c on b.OfferID = c.OfferId) as final where PayStatus<>1 group by Investor_Id) as deliquentamount on totalinvested.Investor_Id = deliquentamount.Investor_Id left join( select Investor_Id,count(LoanRequest_Id) as numofdelinquent from( select Investor_Id, sum(acceptedamount) as amount, LoanRequest_Id from( select a.*, RequestId from( select  OfferId, Investor_Id, AcceptedAmount, LoanRequest_Id,case when  LoanRequest_Id = 2001 then concat('2001', '-', offerid) else ContractId end as newcontractid from tbl_Loanoffers where OfferStatus = 1) as a left join(select* from tbl_LoanRequests where LoanStatus in (3,5,9) ) as b on a.LoanRequest_Id = b.RequestId where RequestId is not null) as pre group by Investor_Id,LoanRequest_Id) as final group by Investor_Id) as numberofdelinquent on totalinvested.Investor_Id = numberofdelinquent.Investor_Id) as investamount on investorinfo.UserID = investamount.Investor_Id").ToList();
            //foreach (var rc in data)
            //{
            ZCRMRecord record1 = new ZCRMRecord("accounts"); //module api name
            record1.SetFieldValue("UserID", "rc.CompanyName");
            record1.SetFieldValue("FullName", "rc.FullName");
            record1.SetFieldValue("UserName", "rc.UserName");
            record1.SetFieldValue("Age", "rc.MobileNumber");
            record1.SetFieldValue("Gender", "rc.IssuerAccountBalance");
            record1.SetFieldValue("NRIC_Number", "rc.OverdueDate");
            record1.SetFieldValue("PassportNumber", "rc.TotalAmountDisbursed");
            record1.SetFieldValue("Nationality", "rc.TotalAmountOverdue");
            record1.SetFieldValue("DateOfBirth", "rc.OutstandingLateFee");
            record1.SetFieldValue("MobileNumber", "rc.OutstandingAmountNoLateFee");
            record1.SetFieldValue("SignUpDate", "rc.OutstandingAmountWithLateFee");
            record1.SetFieldValue("AdminVerification", "rc.LastRepaymentDate");
            record1.SetFieldValue("QualifiedDate", "rc.TotalFeesPaid");
            record1.SetFieldValue("LatestLogin", "rc.TotalPrincipalPaid");
            record1.SetFieldValue("SumOfNumInvestNotes", "rc.TotalInterestPaid");
            record1.SetFieldValue("InvestorAmount_TotalInvested", " rc.TotalLateInterestPaid");
            record1.SetFieldValue("SumOfLedgerAmount", "rc.CompanyName");
            record1.SetFieldValue("NumberOfDelinquentNote", "rc.FullName");
            record1.SetFieldValue("TotalDelinquentAmount", "rc.UserName");
            record1.SetFieldValue("NumberOfFullyPaidNote", "rc.MobileNumber");
            record1.SetFieldValue("InvestorAmount_PrincipalReceived", "rc.IssuerAccountBalance");
            record1.SetFieldValue("InvestorAmount_InvestReceived", "rc.OverdueDate");
            record1.SetFieldValue("TotalAmountReceived", "rc.TotalAmountDisbursed");
            record1.SetFieldValue("SumOftotPaidLateInterest", "rc.TotalAmountOverdue");
            record1.SetFieldValue("NumberOfCloseOffNote", "rc.OutstandingLateFee");
            record1.SetFieldValue("TotalCloseOffPandI", "rc.OutstandingAmountNoLateFee");
            record1.SetFieldValue("CurrentInFundingAmount", "rc.OutstandingAmountWithLateFee");
            record1.SetFieldValue("InvestorAmount_OutstandingP", "rc.LastRepaymentDate");
            record1.SetFieldValue("InvestorAmount_OutstandingI", "rc.TotalFeesPaid");
            records.Add(record1);
            //ZCRMModule moduleIns = ZCRMModule.GetInstance("Leads"); //module api name
            //BulkAPIResponse<ZCRMRecord> response = moduleIns.CreateRecords(records);
            // }
            ZCRMModule moduleIns = ZCRMModule.GetInstance("accounts"); //module api name
            BulkAPIResponse<ZCRMRecord> response = moduleIns.CreateRecords(records); //records - list of ZCRMRecord instances filled with required data for upsert.
            List<ZCRMRecord> upsertedRecords = response.BulkData; //upsertedRecords - list of ZCRMRecord instance
            List<EntityResponse> entityResponses = response.BulkEntitiesResponse; //entityResponses - list of EntityResponses instance
            return records;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
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
