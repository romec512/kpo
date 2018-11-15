using System;
using System.Configuration;
using Kpo4310_asadovrs.Lib;

namespace Kpo4310_asadovrs
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        private static string _dataFileName;
        private static string _logFileName;
        private static ISubFactory _factory;
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

        public static string LogFileName
        {
            get
            {
                return _logFileName;
            }
        }

        public static ISubFactory Factory
        {
            get
            {
                return _factory;
            }
        }

        public static void Initialize(){
            _logPath = ConfigurationManager.AppSettings["logPath"];
            _dataFileName = ConfigurationManager.AppSettings["dataFileName"];
            _logFileName = ConfigurationManager.AppSettings["logFileName"];
            string _readAndSaveMode = ConfigurationManager.AppSettings["readAndSaveMode"];
            if (_readAndSaveMode == "file")
            {
                _factory = new SubstanceFileFactory();
            } else {
                _factory = new SubstanceTestFactory();
            }


        }
    }
}
