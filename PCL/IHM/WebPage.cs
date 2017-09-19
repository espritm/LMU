using System;
using Xamarin.Forms;

namespace ESCL
{
	public class WebPage : ContentPage
	{
        public string m_sIPAdresse { get; set; }

        private WebView m_webview;

		public WebPage ()
		{
            m_webview = new WebView();
            refresh();
		}

        public void refresh()
        {
            if (Settings.IPAdresse != "")
            {
                m_webview.Source = "http://" + Settings.IPAdresse + ":" + Settings.Port + "/projetERDF/";

                Content = m_webview;
            }
        }
	}
}

