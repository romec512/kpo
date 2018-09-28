using System;
using System.IO;

namespace Kpo4310_asadovrs.Lib{
    public static class LogUtility
    {
        public static void ErrorLog(string message)
        {
            File.AppendAllText("error.log", message);
        }
    }
}
