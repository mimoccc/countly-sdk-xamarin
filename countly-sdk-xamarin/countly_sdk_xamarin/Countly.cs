using System.Diagnostics;
using countly_sdk_xamarin.Models;
using countly_sdk_xamarin.Services;

namespace countly_sdk_xamarin
{
    public class Countly
    {
        #region Singleton
        private Countly() { }
        private static Countly instance;
        public static Countly Instance
        {
            get
            {
                if (instance == null) instance = new Countly();
                
                return instance;
            }
        }
        #endregion

        private Parameters param;
        private string ServerUrl;

        /*Countly.Init(this, "https://YOUR_SERVER", "YOUR_APP_KEY").*/
        public void Init(string Url, string AppKey)
        {
            Init(Url,AppKey,null);
        }

        /*You can specify device ID by yourself if you have one(it has to be unique per device):
        Countly.Init(this, "https://YOUR_SERVER", "YOUR_APP_KEY", "YOUR_DEVICE_ID").*/
        public void Init(string Url, string AppKey, string DeviceID)
        {
            if (string.IsNullOrWhiteSpace(Url)) Url = "https://cloud.count.ly/";
            if (Url[Url.Length-1] != '/') Url += "/";

            param = new Parameters()
            {
                app_key = AppKey,
                device_id = DeviceID
            };

            var RequestUrl = Url + "i?" + param.GetParams();//JsonConvert.SerializeObject(param);
            // debug value
            /*var debugResult = */RequestService ReqService = new RequestService(RequestUrl);
            //Debug.Assert(debugResult.Result.result == "success");
        }

        /*You can rely on Google Advertising ID for device ID generation.
        Countly.sharedInstance().init(this, "https://YOUR_SERVER", "YOUR_APP_KEY", null, DeviceId.Type.ADVERTISING_ID)*/
        //private void init()
        //{
        //}

        /*Or you can use OpenUDID:
        Countly.sharedInstance().init(this, "https://YOUR_SERVER", "YOUR_APP_KEY", null, DeviceId.Type.OPEN_UDID)*/
        //private void init()
        //{
        //}

        private void FinishCountly()
        {
            
        }
    }
}
