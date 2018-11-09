using System;
namespace Kpo4310_asadovrs.Lib.Source.Log
{
    public class LogFileUtility
    {
        private string _fileName;
        public string FileName {
            get {
                return _fileName;
            }
            set {
                _fileName = value;
            }
        }

        public LogFileUtility()
        {
            _fileName = "error.log";
        }


        public static void ErrorLog(string message){

        }

    }
}
