using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countly_sdk_xamarin.Models
{
    public class GCMModel
    {
        public static string SenderID;                 // = "<GoogleProjectNumber>"; // Google API Project Number
        public static string ListenConnectionString;   // = "<Listen connection string>";
        public static string NotificationHubName;      // = "<hub name>";

        public void SetGCMModel(string senderID, string listenConnectionString, string notificationHubName)
        {
            SenderID = senderID;
            ListenConnectionString = listenConnectionString;
            NotificationHubName = notificationHubName;
        }
    }
}
