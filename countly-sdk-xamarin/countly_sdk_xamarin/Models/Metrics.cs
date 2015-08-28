using System;
using System.ServiceModel.Channels;
using Xamarin.Forms;

namespace countly_sdk_xamarin.Models
{
    public class Metrics
    {
        public string _os { get; set; }
        public string _os_version { get; set; }
        public string _device { get; set; }
        public string _resolution { get; set; }
        public string _carrier { get; set; }
        public string _app_version { get; set; }
        public string _density { get; set; }
        public string _locale { get; set; }
        public string _store { get; set; }

        private void CollectMetrics()
        {
            //Device.OnPlatform(
            //    Android: () =>
            //    {
            //        _os = "Android";
            //        _os_version = "";
            //        _device = "";
            //        _resolution = "";
            //        _carrier = "";
            //        _app_version = "";
            //        _density = "";
            //        _locale = "";
            //        _store = "";
            //    },
            //    WinPhone: () =>
            //    {
            //        _os = "Android";
            //        _os_version = "";
            //        _device = "";
            //        _resolution = "";
            //        _carrier = "";
            //        _app_version = "";
            //        _density = "";
            //        _locale = "";
            //        _store = "";
            //    },
            //    iOS: () =>
            //    {
            //        _os = "iOS";
            //        _os_version = Device.;
            //        _device = "";
            //        _resolution = "";
            //        _carrier = "";
            //        _app_version = "";
            //        _density = "";
            //        _locale = "";
            //        _store = "";
            //    }
            //    );
            _os = Device.OS.ToString();
        }

    }
}
