using System;
using System.Configuration;
namespace Kpo4310_asadovrs.Utility
{
    public class AppConfigUtility
    {
        public AppConfigUtility()
        {
        }

        public string AppSettings(string name)
        {
            if (ConfigurationManager.AppSettings[name] == null)
            {
                return ConfigurationManager.AppSettings[name];
            }
            else
            {
                return "";
            }
        }
    }
}
