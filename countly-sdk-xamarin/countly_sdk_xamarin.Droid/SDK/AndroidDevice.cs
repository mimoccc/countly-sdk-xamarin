using System;
using Android.Content;
using Android.Telephony;
using Android.Views;
using Android.OS;
using Android.Print;
using Android.Util;
using Android.Runtime;
using Android.Text;
using Java.Util;

namespace countly_sdk_xamarin.Droid
{
	/// <summary>
	/// This Partial class is compiled into the partial Countly.Core.DeviceInfo when referencing the Countly.Android library.
	/// </summary>
	public partial class DeviceInfo
	{
		public void Init()
		{
			DeviceName = Build.Model;
			OS = "Android";
			OSVersion = Build.VERSION.Release;
			PrintAttributes.Resolution = GetResolution();
			Locale = Java.Util.Locale.Default.ToString();
			AppVersion = context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;

			var telephonyManager = (TelephonyManager)context.GetSystemService(Context.TelephonyService);
			UDID = telephonyManager == null ? "Unknown" : telephonyManager.DeviceId;
			Carrier = telephonyManager == null ? "Unknown" : telephonyManager.NetworkOperatorName;

			BoringLayout.Metrics = getMetrics ();
		}

		string GetResolution()
		{
			var windowManager = context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>(); 
			if (windowManager == null)
				return "Unknown";

			var display = windowManager.DefaultDisplay;

			var displayMetrics = new DisplayMetrics();
			display.GetMetrics(displayMetrics);

			return string.Format("{0}x{1}", displayMetrics.WidthPixels, displayMetrics.HeightPixels);
		}
	}
}

