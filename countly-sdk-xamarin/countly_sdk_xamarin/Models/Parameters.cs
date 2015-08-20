using Newtonsoft.Json;

namespace countly_sdk_xamarin.Models
{
    class Parameters
    {
        private const string AppKey     = "app_key";
        private const string DeviceID   = "device_id";
        private const string BeginSession       = "begin_session";
        private const string SessionDuration    = "session_duration";
        private const string EndSession = "end_session";
        private const string IPAddress  = "ip_address";
        private const string Timestamp  = "timestamp";
        private const string Metrics    = "metrics";
        private const string Events     = "events";
        private const string UserDetails    = "user_details";
        private const string CountryCode    = "country_code";
        private const string City       = "city";
        private const string Location   = "location";
        private const string OldDeviceID    = "old_device_id";

        public string app_key   { get; set; }
        public string device_id { get; set; }
        public string begin_session { get; set; } // int
        public string session_duration  { get; set; } // int
        public string end_session   { get; set; } // int
        public string ip_address    { get; set; }
        public string timestamp { get; set; } // int
        public string metrics   { get; set; }
        public string events    { get; set; }
        public string user_details  { get; set; }
        public string country_code  { get; set; }
        public string city      { get; set; }
        public string location  { get; set; }
        public string old_device_id { get; set; }

        public string GetParams()
        {
            bool flag = false;
            string rez = "";

            if (!string.IsNullOrWhiteSpace(app_key))
                rez += AppKey + "=:" + app_key;
            else { return ""; }

            if (!string.IsNullOrWhiteSpace(device_id))
            {
                rez += "&";
                rez += DeviceID + "=:" + device_id;
            }
            else { return ""; }

            if (!string.IsNullOrWhiteSpace(begin_session))
            {
                if (flag == true) rez += "&";
                rez += BeginSession + "=:" + begin_session;
            }

            if (!string.IsNullOrWhiteSpace(session_duration))
            {
                if (flag == true) rez += "&";
                rez += SessionDuration + "=:" + session_duration;
            }

            if (!string.IsNullOrWhiteSpace(end_session))
            {
                if (flag == true) rez += "&";
                rez += EndSession + "=:" + end_session;
            }

            if (!string.IsNullOrWhiteSpace(ip_address))
            {
                if (flag == true) rez += "&";
                rez += IPAddress + "=:" + ip_address;
            }

            if (!string.IsNullOrWhiteSpace(timestamp))
            {
                if (flag == true) rez += "&";
                rez += Timestamp + "=:" + timestamp;
            }

            if (!string.IsNullOrWhiteSpace(metrics))
            {
                rez += "&";
                rez += Metrics + "=:" + metrics;
            }

            if (!string.IsNullOrWhiteSpace(events))
            {
                rez += "&";
                rez += Events + "=:" + events;
            }

            if (!string.IsNullOrWhiteSpace(user_details))
            {
                rez += "&";
                rez += UserDetails + "=:" + user_details;
            }

            if (!string.IsNullOrWhiteSpace(country_code))
            {
                rez += "&";
                rez += CountryCode + "=:" + country_code;
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                rez += "&";
                rez += City + "=:" + city;
            }

            if (!string.IsNullOrWhiteSpace(location))
            {
                rez += "&";
                rez += Location + "=:" + location;
            }

            if (!string.IsNullOrWhiteSpace(old_device_id))
            {
                rez += "&";
                rez += OldDeviceID + "=:" + old_device_id;
            }

            return rez;
        }

    }
}
