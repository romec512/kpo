using System;
using System.Configuration;

namespace Kpo4310_asadovrs
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        private static string _dataFileName;

        public static string LogPath {
            get {
                return _logPath;
            }
        }
        public static string DataFileName {
            get {
                return _dataFileName;
            }
        }

        public static void Initialize(){
            _logPath = ConfigurationManager.AppSettings["logPath"];
            _dataFileName = ConfigurationManager.AppSettings["dataFileName"];
        }
    }
}
