using Xamarin.Forms;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace TestApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new TestAppPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			Analytics.TrackEvent("OnStart", null);
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
			Analytics.TrackEvent("OnSleep", null);
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
			Analytics.TrackEvent("OnResume", null);
		}
	}
}
