using System;
using System.IO;
using System.Json;
using System.Net;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Widget;
using countly_sdk_xamarin.Models;

namespace countly_sdk_xamarin.Droid
{
    [Activity(Label = "countly_sdk_xamarin.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int count = 1;
      
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.myButton);

            //if you leave server_Url empty - it will be assigned default - https://cloud.count.ly 
            string server_Url   = "http://try.count.ly"; // you can put '/' at the end. if you don't out it will be automaticly added.

            string app_key      = "fa65c0e6a099bd4e3b4ac8368dac7542df76497a";
            string device_id    = "123";
            
            var responseLabel = FindViewById<TextView>(Resource.Id.textViewResponse);
            
            Countly Service = Countly.Instance;
            Service.Init(server_Url, app_key, device_id);
        }
    }
}