using Xamarin.Forms;
using System;
using System.Collections;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System.Collections.Generic;

namespace TestApp
{
	public partial class TestAppPage : ContentPage
	{
		public TestAppPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			IDictionary<string, string> details = new Dictionary<string, string> {
  				{ "Key1", "Value1" },
 				{ "Key2", "Value2" },
  				{ "Key3", "Value3" }
			};
			Analytics.TrackEvent("Action1", details);
		}

		void Handle_Clicked2(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

	}
}
