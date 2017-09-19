using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCL
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        private const string IPAdresseKey = "IPAdresse_Key";
        private static readonly string IPAdresseDefault = "";

        private const string PortKey = "Port_Key";
        private static readonly string PortDefault = "9084";

        public static string IPAdresse
        {
            get 
            {
                return AppSettings.GetValueOrDefault(IPAdresseKey, IPAdresseDefault); 
            }
            set
            {
                AppSettings.AddOrUpdateValue(IPAdresseKey, value);
            }
        }

        public static string Port
        {
            get 
            {
                return AppSettings.GetValueOrDefault(PortKey, PortDefault); 
            }
            set 
            {
                AppSettings.AddOrUpdateValue(PortKey, value); 
            }
        }
    }
}
