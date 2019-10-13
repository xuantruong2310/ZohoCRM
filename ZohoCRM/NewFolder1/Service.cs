
using System;
using System.Linq;
using System.Collections.Generic;
using ZCRMSDK.CRM.Library.CRUD;
using ZCRMSDK.CRM.Library.Api.Response;
using ZohoCRM.Models;
using ZohoCRM.DB;
using ZCRMSDK.CRM.Library.Setup.RestClient;
using ZCRMSDK.OAuth.Client;
using ZCRMSDK.OAuth.Contract;
using ZCRMSDK.CRM.Library.Setup.Users;

namespace ZohoCRM.Services
{
    public interface IService
    {
        BulkAPIResponse<ZCRMRecord> Insert();
        void Update();
    }
    public class Service : IService
    {
        
        public Service()
        {
           
        }

        public BulkAPIResponse<ZCRMRecord> Insert()
        {
            // hardcode
            ZCRMRestClient.Initialize(config);
            ZohoOAuthClient client = ZohoOAuthClient.GetInstance();
            string refreshToken = "1000.b9482a79cac2f29c7ac3d2a254d9e5c7.0c0505d64a40d8eae4e649809ac4814c";
            string userMailId = "nguyen.quang.tuyen@moolahsense.com";
            ZohoOAuthTokens tokens = client.GenerateAccessTokenFromRefreshToken(refreshToken, userMailId);
            List<ZCRMRecord> records = new List<ZCRMRecord>();
            ZCRMRecord record1 = new ZCRMRecord("accounts"); //module api name
            var dbContext = new MS_UATEntities();
            var data = dbContext.Database.SqlQuery<IssuerModel>("select noactive.*, case when LoanStatus=8 then 'nonactive' else 'active' end as loanstatus,case when LoanRequestID is not null then ' ' end as Stage  from ( select company.BusinessName, nocompany.* from( select z.*, y.lastrepaymentdate, x.DAYS_OVERDUE, convert(decimal(18, 2), x.overdueamount) as overdueamount, w.numofoutstandingrepayment, w.numofoverduerepayment, w.numofpaidrepayment, w.totalnumofrepayment, convert(decimal(18, 2), v.outamountwithoutlf) as outamountwithoutlf, convert(decimal(18, 2), v.outamountwitlf) as outamountwithlf, convert(decimal(18, 2), v.outstandinglf) as outstandinglf, u.FinalAmount, convert(decimal(18, 2), s.paidlatefees) as paidlatefees, convert(decimal(18, 2), r.totalpaidamount) as totalpaidamount, q.accepteddate from( select loanrequestid, min(iif(paystatus = 2, duedate, null)) as overduesincedate from issuerrepayment group by LoanRequestID) as z left join( select LoanRequestID, max(date) as lastrepaymentdate from issuerrepayment right join issuerrepaymentpayment on issuerrepayment.IssuerRepID = IssuerRepaymentPayment.IssuerRepID group by LoanRequestID) as y on z.LoanRequestID = y.LoanRequestID left join( select a1.*, b1.overdueamount from( select loanrequestid, isnull(DATEDIFF(day, MIN(IIF(PAYSTATUS <> 1, DUEDATE, NULL)), GETDATE()), 0) AS DAYS_OVERDUE from issuerrepayment group by LoanRequestID) as a1 left join( Select distinct LoanRequestID, Case when paystatus = 2 then SUM(Principal - isnull(PaidPrincipal, 0) - isnull(PaidInterest, 0) + Interest + isnull(lateinterest, 0)) over(partition by loanrequestID) else 0 end as overdueamount from IssuerRepayment where PayStatus = 2 ) as b1 on a1.LoanRequestID = b1.LoanRequestID) as x on z.LoanRequestID = x.LoanRequestID left join( select t.*,isnull(numpaid.numofpaidrepayment, 0) as numofpaidrepayment, isnull(numoverdue.numofoverduerepayment, 0) as numofoverduerepayment, isnull(numoutstanding.numofoutstandingrepayment, 0) as numofoutstandingrepayment from(     select LoanRequestID, count(issuerrepid) as totalnumofrepayment    from IssuerRepayment group by LoanRequestID) as t left join( select LoanRequestID, count(issuerrepid) as numofpaidrepayment from IssuerRepayment where PayStatus = 1 group by LoanRequestID) as numpaid on t.LoanRequestID = numpaid.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoverduerepayment from IssuerRepayment where PayStatus = 2 group by LoanRequestID ) as numoverdue on t.LoanRequestID = numoverdue.LoanRequestID left join( select LoanRequestID, count(issuerrepid) as numofoutstandingrepayment from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as numoutstanding on t.LoanRequestID = numoutstanding.LoanRequestID) as w on z.LoanRequestID = w.LoanRequestID left join( select LoanRequestID, sum((isnull(latefees,0)-isnull(paidlatefees, 0))*(1 - isfeewaiver))as outstandinglf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0)) as outamountwithoutlf,sum(principal - isnull(paidprincipal, 0) + Interest - isnull(paidinterest, 0) + isnull(lateinterest, 0) + (isnull(latefees, 0) - isnull(paidlatefees, 0)) * (1 - isfeewaiver)) as outamountwitlf from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as v on z.LoanRequestID = v.LoanRequestID left join( select RequestId, FinalAmount from tbl_LoanRequests ) as u on z.LoanRequestID = u.RequestId left join( select loanrequestid, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalamountpaid from issuerrepayment group by loanrequestid) t     on z.LoanRequestID = t.LoanRequestID left join( select loanrequestid, sum(isnull(paidlatefees,0)) as paidlatefees from issuerrepayment where IsFeeWaiver = 0 group by loanrequestid) as s on z.LoanRequestID = s.LoanRequestID left join( select case when a.LoanRequestID is not null then a.LoanRequestID else b.LoanRequestID end as loanrequestid, isnull(totalpaid, 0) + isnull(totalpaida, 0) as totalpaidamount from(  select LoanRequestID, sum(amount + isnull(PaidLateInterest, 0)) as totalpaid from IssuerRepayment where paystatus = 1 group by LoanRequestID) as a full join(select LoanRequestID, sum(isnull(paidprincipal,0)+isnull(paidinterest, 0) + isnull(paidlateinterest, 0)) as totalpaida from IssuerRepayment where PayStatus <> 1 group by LoanRequestID) as b on a.loanrequestid = b.loanrequestid ) as r on z.LoanRequestID = r.loanrequestid left join( select requestid, accepteddate from tbl_loanrequests) as q on z.loanrequestid = q.requestid  ) as nocompany left join( select accountdetails.BusinessName, tbl_loanrequests.RequestId from tbl_loanrequests left join(select BusinessName, NRIC_Number, USER_ID from tbl_AccountDetails) as accountdetails on accountdetails.user_ID = tbl_loanrequests.user_ID) as company on nocompany.LoanRequestID = company.RequestId ) as noactive left join( select RequestId, LoanStatus from tbl_LoanRequests ) as active on noactive.LoanRequestID = active.RequestId  ").ToList();
            foreach (var rc in data)
            {
                record1.SetFieldValue("Account_Name", "test1");
                record1.SetFieldValue("Email", "test1@gmail.com");
                record1.SetFieldValue("Username", "test1");
                record1.SetFieldValue("Industry", "rc.MobileNumber");
                record1.SetFieldValue("Status", "rc.IssuerAccountBalance");
                record1.SetFieldValue("Phone", "41212124124");
                record1.SetFieldValue("Fax", "12412412424");
                record1.SetFieldValue("Employees", 12);
                record1.SetFieldValue("Total_Loan_Amount_Disbursed", 31);
                record1.SetFieldValue("Last_Repayment_Date", 14);
                record1.SetFieldValue("Days_overdue", 13);
                record1.SetFieldValue("Issuer_Account_Balance", 13);
                record1.SetFieldValue("Outstanding_Amount_with_Late_Fee", 13);
                record1.SetFieldValue("Outstanding_w/o_Late_Fee", 13);
                record1.SetFieldValue("Outstanding_Late_Fee", 13);
                record1.SetFieldValue("Total_Amount_Overdue", 13);
                record1.SetFieldValue("Total_Principle_Paid", 12);
                record1.SetFieldValue("Total_Interest_Paid", 12);
                record1.SetFieldValue("Total_Late_Fee_Paid", 13);
                record1.SetFieldValue("Total_Late_Interest_Paid", 12);
                record1.SetFieldValue("Total_Paid_Amount", 14);
                record1.CreatedTime = DateTime.UtcNow.Ticks.ToString();
                records.Add(record1);

            }
            ZCRMModule moduleIns = ZCRMModule.GetInstance("accounts"); //module api name
            BulkAPIResponse<ZCRMRecord> response = moduleIns.CreateRecords(records); //records - list of ZCRMRecord instances filled with required data for upsert.
            List<ZCRMRecord> upsertedRecords = response.BulkData; //upsertedRecords - list of ZCRMRecord instance
            List<EntityResponse> entityResponses = response.BulkEntitiesResponse; //entityResponses - list of EntityResponses instance
            return response;
        }

        public void Update()
        {
            List<ZCRMRecord> listRecord = new List<ZCRMRecord>();
            ZCRMRecord record;

            record = new ZCRMRecord("Invoices"); //To get ZCRMRecord instance
            record.SetFieldValue("id", 3372164000001904002);
            record.SetFieldValue("Subject", "UpdateInvoice4"); //This method use to set FieldApiName and value similar to all other FieldApis and Custom field
            record.SetFieldValue("Account_Name", 3372164000001855101);
            record.SetFieldValue("Company", "KK");
            record.SetFieldValue("Last_Name", "User");
            record.SetFieldValue("Customfield", "CustomFieldValue");
            record.SetFieldValue("Price_Book_Name", "Price_Book_Name");

            /** Following methods are being used only by Inventory modules */
            ZCRMPriceBookPricing pricing;

            pricing = new ZCRMPriceBookPricing
            {
                ToRange = 5,
                FromRange = 1,
                Discount = 0
            };
            record.AddPriceDetail(pricing);

            pricing = new ZCRMPriceBookPricing
            {
                ToRange = 11,
                FromRange = 6,
                Discount = 1
            };
            record.AddPriceDetail(pricing);

            pricing = new ZCRMPriceBookPricing
            {
                ToRange = 17,
                FromRange = 12,
                Discount = 2
            };
            record.AddPriceDetail(pricing);

            pricing = new ZCRMPriceBookPricing
            {
                ToRange = 23,
                FromRange = 18,
                Discount = 3
            };
            record.AddPriceDetail(pricing);

            record.SetFieldValue("Pricing_Model", "Flat");
            ZCRMTax linetax;
            linetax = ZCRMTax.GetInstance("Sales Tax");
            linetax.Percentage = 12.5;
            record.AddTax(linetax);

            ZCRMRecord product = ZCRMRecord.GetInstance("Products", 3372164000000190001); // product instance

            ZCRMInventoryLineItem lineItem = new ZCRMInventoryLineItem(product)
            {
                Description = "Product_description", //To set line item description
                Discount = 5, //To set line item discount
                ListPrice = 100 //To set line item list price

            }; //To get ZCRMInventoryLineItem instance
            lineItem.DiscountPercentage = 10;
            ZCRMTax taxInstance = ZCRMTax.GetInstance("Sales Tax"); //To get ZCRMTax instance
            taxInstance.Percentage = 2; //To set tax percentage
            taxInstance.Value = 50; //To set tax value
            lineItem.AddLineTax(taxInstance); //To set line tax to line item

            taxInstance = ZCRMTax.GetInstance("Vat");
            taxInstance.Percentage = 12;
            taxInstance.Value = 50;

            lineItem.AddLineTax(taxInstance);
            lineItem.Quantity = 200; //To set product quantity to this line item

            record.AddLineItem(lineItem); //The line item set to the record object
                                          /** End Inventory **/

            listRecord.Add(record);


            record = new ZCRMRecord("Invoices"); //To get ZCRMRecord instance
            record.SetFieldValue("id", 3372164000001904001);
            record.SetFieldValue("Subject", "UpdateInvoice4"); //This method use to set FieldApiName and value similar to all other FieldApis and Custom field
            record.SetFieldValue("Account_Name", 3372164000001855101);
            record.SetFieldValue("Company", "KK");
            record.SetFieldValue("Last_Name", "User");
            record.SetFieldValue("Customfield", "CustomFieldValue");
            record.SetFieldValue("Price_Book_Name", "Price_Book_Name");

            /** Following methods are being used only by Inventory modules */
            ZCRMPriceBookPricing pricing1;

            pricing1 = new ZCRMPriceBookPricing
            {
                ToRange = 5,
                FromRange = 1,
                Discount = 0
            };
            record.AddPriceDetail(pricing1);

            pricing1 = new ZCRMPriceBookPricing
            {
                ToRange = 11,
                FromRange = 6,
                Discount = 1
            };
            record.AddPriceDetail(pricing1);

            pricing1 = new ZCRMPriceBookPricing
            {
                ToRange = 17,
                FromRange = 12,
                Discount = 2
            };
            record.AddPriceDetail(pricing1);

            pricing1 = new ZCRMPriceBookPricing
            {
                ToRange = 23,
                FromRange = 18,
                Discount = 3
            };
            record.AddPriceDetail(pricing1);

            record.SetFieldValue("Pricing_Model", "Flat");
            linetax = ZCRMTax.GetInstance("Sales Tax");
            linetax.Percentage = 12.5;
            record.AddTax(linetax);

            ZCRMRecord product1 = ZCRMRecord.GetInstance("Products", 3372164000000190001); // product instance

            ZCRMInventoryLineItem lineItem1 = new ZCRMInventoryLineItem(product1)
            {
                Description = "Product_description", //To set line item description
                Discount = 5, //To set line item discount
                ListPrice = 100 //To set line item list price

            }; //To get ZCRMInventoryLineItem instance
            lineItem1.DiscountPercentage = 10;
            ZCRMTax taxInstance11 = ZCRMTax.GetInstance("Sales Tax"); //To get ZCRMTax instance
            taxInstance11.Percentage = 2; //To set tax percentage
            taxInstance11.Value = 50; //To set tax value
            lineItem1.AddLineTax(taxInstance11); //To set line tax to line item

            taxInstance11 = ZCRMTax.GetInstance("Vat");
            taxInstance11.Percentage = 12;
            taxInstance11.Value = 50;

            lineItem1.AddLineTax(taxInstance11);
            lineItem1.Quantity = 500; //To set product quantity to this line item

            record.AddLineItem(lineItem1); //The line item set to the record object
                                           /** End Inventory **/

            listRecord.Add(record);

            ZCRMModule moduleIns = ZCRMModule.GetInstance("Invoices"); //To get the Module instance
            BulkAPIResponse<ZCRMRecord> responseIns = moduleIns.UpdateRecords(listRecord); //To call the Update record method
            Console.WriteLine("HTTP Status Code:" + responseIns.HttpStatusCode); //To get Update record http response code
            foreach (EntityResponse response in responseIns.BulkEntitiesResponse)
            {
                Console.WriteLine("Status:" + response.Status); //To get Update record response status
                Console.WriteLine("Message:" + response.Message); //To get Update record response message
                Console.WriteLine("Details:" + response.ResponseJSON); //To get Update record response details
                ZCRMRecord record1 = (ZCRMRecord)response.Data;
                Console.WriteLine(record1.EntityId); //To get inserted record id
                Console.WriteLine(record1.CreatedTime);
                Console.WriteLine(record1.ModifiedTime);
                ZCRMUser CreatedBy = record1.CreatedBy;
                if (CreatedBy != null)
                {
                    Console.WriteLine(CreatedBy.Id);
                    Console.WriteLine(CreatedBy.FullName);
                }
                ZCRMUser ModifiedBy = record1.ModifiedBy;
                if (ModifiedBy != null)
                {
                    Console.WriteLine(ModifiedBy.Id);
                    Console.WriteLine(ModifiedBy.FullName);
                }
            }
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
