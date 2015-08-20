using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countly_sdk_xamarin.Models
{
    class Metrics
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
    }
}
