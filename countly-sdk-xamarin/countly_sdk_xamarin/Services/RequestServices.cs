using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using countly_sdk_xamarin.Models;
using Newtonsoft.Json;

namespace countly_sdk_xamarin.Services
{
    public class RequestService
    {
        public static string toJSON<TemplateType>(TemplateType someObject)
        {
            var json = JsonConvert.SerializeObject(someObject);
            return json;
        }

        public static TemplateType eventFromJSON<TemplateType>(string json)
        {
            var newEvent = JsonConvert.DeserializeObject<TemplateType>(json);
            return newEvent;
        }

        public static async Task GetServerData(string Url)
        {
            string result = await RequestService.MakeInitRequest(Url);
            InitResponse model = Newtonsoft.Json.JsonConvert.DeserializeObject<InitResponse>(result);
            Debug.Assert(model.result == "Success");
        }

        public static async Task<string> MakeInitRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "text/html";
            //request.ContentType = "application/json; charset=utf-8";
            request.Method = "GET";
            var response = await request.GetResponseAsync();
            var respStream = response.GetResponseStream();
            respStream.Flush();

            using (StreamReader sr = new StreamReader(respStream))
            {
                //Need to return this response 
                string strContent = sr.ReadToEnd();
                respStream = null;
                return strContent;
            }
        }
    }
}
