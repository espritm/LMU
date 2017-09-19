using System;
using Xamarin.Forms;

namespace ESCL
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
            MainTabbedPage tabbedPage = new MainTabbedPage();

            MainPage = tabbedPage;

            if (Settings.IPAdresse != "")
                tabbedPage.SwitchToTabWebView();
            else
                tabbedPage.SwitchToTabSetting();

		}
	}
}

