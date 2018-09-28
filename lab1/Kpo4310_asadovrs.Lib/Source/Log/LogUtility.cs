using System;
using System.IO;
using AppKit;

namespace Kpo4310_asadovrs.Lib
{
    public static class LogUtility
    {
        public static void ErrorLog(string message)
        {
            try
            {
                File.AppendAllText("error.log", DateTime.Now + " " + message + "\n");
            } catch (Exception ex){
                var alert = new NSAlert();
                alert.MessageText = "Возникла ошибка";
                alert.InformativeText = "Ошибка №3: " + ex.Message;
                alert.RunModal();
            }
        }

        public static void ErrorLog(Exception ex){
            File.AppendAllText("error.log", DateTime.Now + " " + ex.Message + "\n");
        }
    }
}
