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
    public class ValuesController : ApiController
    {
        // GET api/values
        public BulkAPIResponse<ZCRMUser> Get()
        {
            ZCRMRestClient.Initialize(config);
            ZohoOAuthClient client = ZohoOAuthClient.GetInstance();
            string grantToken = "1000.c1fed545dc04a4772d02f4db76c82a88.3305bccfe5f6cd14fc35359a616bc37f";
            ZohoOAuthTokens tokens = client.GenerateAccessToken(grantToken);
            string accessToken = tokens.AccessToken;
            string refreshToken = tokens.RefreshToken;
            ZCRMRestClient restClient = ZCRMRestClient.GetInstance();
            BulkAPIResponse<ZCRMUser> response = restClient.GetOrganizationInstance().GetAllUsers();
            List<ZCRMUser> allUsers = response.BulkData; //response - list of ZCRMUser instances
            return response;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public APIResponse Post()
        {
            /** To create new user */
            ZCRMRestClient.Initialize(config);
            ZCRMUser user = ZCRMUser.GetInstance("Boyle", "Patricia@abc.com"); //last_name and email of the user
            ZCRMOrganization OrgInstance = ZCRMRestClient.GetInstance().GetOrganizationInstance();
            user.Country = "US";
            user.Role = ZCRMRole.GetInstance(5540230004000015969, "Manager");
            user.CountryLocale = "en_US";
            user.FirstName = "Patricia";
            user.Profile = ZCRMProfile.GetInstance(5540234000000015975, "Standard");
            user.DateOfBirth = "1990-12-31";
            user.DateFormat = "MM/dd/yyyy";

            user.SetFieldValue("FieldApiName", "FieldValue");
            APIResponse response = OrgInstance.CreateUser(user);
            Console.WriteLine(response.HttpStatusCode);
            Console.WriteLine(response.Status);
            Console.WriteLine(response.ResponseJSON);
            Console.WriteLine(response.Message);
            Console.WriteLine(JsonConvert.SerializeObject(response));
            Console.WriteLine("\n\n\n");
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
