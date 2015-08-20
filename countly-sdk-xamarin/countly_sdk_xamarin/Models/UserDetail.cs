using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countly_sdk_xamarin.Models
{
    internal class UserDetail
    {
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string organization { get; set; }
        public string phone { get; set; }
        public string picture { get; set; }
        public string gender { get; set; }
        public int byear { get; set; }
        public Dictionary<string,string> custom { get; set; }
    }
}
