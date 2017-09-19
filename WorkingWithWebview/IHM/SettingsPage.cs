using System;
using Xamarin.Forms;

namespace ESCL
{
	public class SettingsPage : ContentPage
	{
        public SettingsPage()
		{
            Label label_IP = new Label 
            {
				Text = @"Saisissez l'adresse IP de votre Raspberry"
			};

            Entry entry_IP = new Entry
            {
                Placeholder = @"192.168.1.3",
                Text = Settings.IPAdresse
            };


            Label label_Port = new Label
            {
                Text = @"Saisissez le port du Raspberry. Laissez par défaut si vous ne l'avez pas changé."
            };

            Entry entry_Port = new Entry
            {
                Placeholder = @"9084",
                Text = Settings.Port
            };
            

            Button btnValid = new Button 
            {
				Text = "Valider"
			};

            btnValid.Clicked += (sender, e) => 
            {
                Settings.IPAdresse = entry_IP.Text;
                Settings.Port = entry_Port.Text;

                ((MainTabbedPage)Parent).SwitchToTabWebView();
			};


            Content = new StackLayout
            {
                Padding = new Thickness(5, 20, 5, 0),
                HorizontalOptions = LayoutOptions.Fill,
                Children = {
					label_IP,
                    entry_IP,
                    label_Port,
                    entry_Port,
					btnValid
				}
            };
		}
	}
}

