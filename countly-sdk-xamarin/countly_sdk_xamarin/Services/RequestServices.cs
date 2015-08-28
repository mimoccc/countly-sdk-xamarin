using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using countly_sdk_xamarin.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace countly_sdk_xamarin.Services
{
    public class RequestService
    {
        private void FirstRequest()
        {

        }

        private void LastRequest()
        {
            
        }

        int GetSessionDuration()
        {
            TimeSpan duration = lastRequestTime - DateTime.Now;
            return duration.Seconds;
        }

        private string requestUrl;
        
        private static DateTime lastRequestTime;
        private int requestDelay;
        private bool successPush;


        private Queue<Event> currentEvents;

        public RequestService(string Url)
        {
            // Setting configures
            
            successPush = false; // check if last push were successfull
            requestDelay = 60; // setting delay time of requests - 60 seconds

            requestUrl = Url; // setting request URL
            TimeSpan time = new TimeSpan(0, 0, requestDelay);

            FirstRequest();
            Device.StartTimer(time, StartRequestProcessor); // starting processor
        }

        private bool StartRequestProcessor()
        {
            GetServerData();
            return true;
        }

        public async Task GetServerData()
        {
            if (EventService.Instance.EventCount != 0)
            {
                requestUrl += CreateEventJSONPack();
            }
            var result = await Task.Run(() => MakeRequest(requestUrl));
            InitResponse model = JsonConvert.DeserializeObject<InitResponse>(result);
            //Debug.Assert(model.result == "Success");

            if (model.result == "Success") successPush = true;
            else successPush = false;

            
        }

        private string CreateEventJSONPack()
        {
            int avalableEvents = EventService.Instance.EventCount > 10 ? 10 : EventService.Instance.EventCount;

            currentEvents = EventService.Instance.GetEvents(avalableEvents);

            string eventJSON = String.Empty;

            for (int i = 0; i < avalableEvents; i++)
            {
                eventJSON += toJSON(currentEvents.Dequeue());
            }

            return eventJSON;
        }

        public static async Task<string> MakeRequest(string url)
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
    }
}
