using System;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestApp.Droid
{
	[Activity(Label = "TestApp.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}

		protected override void OnStart()
		{
			MobileCenter.Start("ios=0c8f5b78-8984-4484-855c-5e006b9fab98;android=b67e26ea-8202-4e6d-abe0-28a7a0853453",
		typeof(Analytics), typeof(Crashes));
			base.OnStart();
		}
	}
}
