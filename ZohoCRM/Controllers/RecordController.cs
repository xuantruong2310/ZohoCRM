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

namespace ZohoCRM.Controllers
{
    public class RecordController : ApiController
    {
        // GET api/record
        public BulkAPIResponse<ZCRMRecord> Get()
        {
            ZCRMRestClient.Initialize(config);
            ZohoOAuthClient client = ZohoOAuthClient.GetInstance();
            string grantToken = "1000.f8b6e45384893de974d11eb552ec016f.f6616a7e1091c4519cee3440c5ccb458";
            ZohoOAuthTokens tokens = client.GenerateAccessToken(grantToken);
            string accessToken = tokens.AccessToken;
            string refreshToken = tokens.RefreshToken;
            ZCRMModule moduleIns = ZCRMModule.GetInstance("Leads"); //module api name
            List<string> fields = new List<string> { "Last_Name", "Company", "Email", "id" }; //field api name
            BulkAPIResponse<ZCRMRecord> response = moduleIns.GetRecords(3372164000000087503, "Company", CommonUtil.SortOrder.asc, 1, 4, fields);// get Records with cvId, sortByField, sortOrder, startIndex, endIndex and fieldApiNamelist.
            List<ZCRMRecord> records = response.BulkData; //records - list of ZCRMRecord instance
            return response;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/record
        public BulkAPIResponse<ZCRMRecord> Post()
        {
            ZCRMRestClient.Initialize(config);
            ZohoOAuthClient client = ZohoOAuthClient.GetInstance();
            string grantToken = "1000.6e18451db3efeca854554e0c3e5e0a3f.5f6e9dbdcff49ecc3d19104195b8934c";
            ZohoOAuthTokens tokens = client.GenerateAccessToken(grantToken);
            string accessToken = tokens.AccessToken;
            string refreshToken = tokens.RefreshToken;
            List<ZCRMRecord> records = new List<ZCRMRecord>();
            ZCRMRecord record1 = new ZCRMRecord("Leads"); //module api name
            record1.SetFieldValue("Company", "abc");
            record1.SetFieldValue("Last_Name", "Lead_changed");
            record1.SetFieldValue("Email", "newcrmapi@zoho.com");
            record1.SetFieldValue("State", "Texas");
            records.Add(record1);
 
            ZCRMModule moduleIns = ZCRMModule.GetInstance("Leads"); //module api name
            BulkAPIResponse<ZCRMRecord> response = moduleIns.CreateRecords(records); //records - list of ZCRMRecord instances filled with required data for upsert.
            List<ZCRMRecord> upsertedRecords = response.BulkData; //upsertedRecords - list of ZCRMRecord instance
            List<EntityResponse> entityResponses = response.BulkEntitiesResponse; //entityResponses - list of EntityResponses instance
            return response;
        }

        // PUT api/values/5
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
