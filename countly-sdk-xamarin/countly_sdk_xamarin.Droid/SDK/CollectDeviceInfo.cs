using System;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Views.TextService;
using countly_sdk_xamarin.Models;
using Java.Util;
using TextInfo = System.Globalization.TextInfo;

namespace countly_sdk_xamarin.Droid.SDK
{
    class CollectDeviceInfo
    {
        private Metrics metrics;

        public Metrics GetMetrics(Context ctx)
        {
            metrics = new Metrics();

            metrics._os = "Android";

            int width = (int) (ctx.Resources.DisplayMetrics.WidthPixels/ctx.Resources.DisplayMetrics.Density);
            int hight = (int) (ctx.Resources.DisplayMetrics.HeightPixels/ctx.Resources.DisplayMetrics.Density);
            metrics._resolution = width.ToString() + "x" + hight.ToString();
            // iOS // App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;

            metrics._os_version = "";

            metrics._device = getDeviceName();
            
            metrics._carrier = "";

            metrics._app_version = ctx.PackageManager.GetPackageInfo(ctx.PackageName, 0).VersionName;
            // iOS // NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleShortVersionString")].ToString();

            

            metrics._density = ((int)(ctx.Resources.DisplayMetrics.Density)).ToString();
            metrics._locale = Locale.Default.GetDisplayLanguage(Locale.Default);
            metrics._store = "";

            return metrics;
        }

        public string getDeviceName()
        {
            string manufacturer = Build.Manufacturer;
            string model = Build.Model;

            TextInfo temp;
            if (model.StartsWith(manufacturer))
            {
                return model; // capitalize
            }
            else
            {
                return manufacturer + " " + model; //"Samsung GT-N8010"  // capitalize(manufacturer)
            }
        }
    }
}