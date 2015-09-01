using System;
using System.Collections.Generic;
using SQLite;

namespace countly_sdk_xamarin.Models
{
    public class Event
    {
        private static readonly string SEGMENTATION_KEY = "segmentation";
        private static readonly string KEY_KEY = "key";
        private static readonly string COUNT_KEY = "count";
        private static readonly string SUM_KEY = "sum";
        private static readonly string TIMESTAMP_KEY = "timestamp";

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string key;
        public Dictionary<String, String> segmentation;
        public int count;
        public double sum;
        public int timestamp;
    }
}
