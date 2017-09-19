using System;
using Xamarin.Forms;

namespace ESCL
{
	public class MainTabbedPage : TabbedPage 
	{
        readonly SettingsPage m_pageSettings;
        readonly WebPage m_pageWebView;

        public MainTabbedPage()
        {
            m_pageSettings = new SettingsPage { Title = "Paramètres" };
            m_pageWebView = new WebPage { Title = "Données de consommation" };

            Children.Add(m_pageSettings);
            Children.Add(m_pageWebView);
        }

        public void SwitchToTabSetting()
        {
            CurrentPage = m_pageSettings;
        }

        public void SwitchToTabWebView()
        {
            m_pageWebView.refresh();
            CurrentPage = m_pageWebView;
        }
	}
}

