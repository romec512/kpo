using System;
using System.IO;
using AppKit;
using Kpo4310_asadovrs.Utility;

namespace Kpo4310_asadovrs.Lib
{
    public static class LogFileUtility
    {
    
        public static void ErrorLog(string message){

            var configManager = new AppConfigUtility();
            string _fileName = Kpo4310_asadovrs.AppGlobalSettings.LogFileName;
            System.Diagnostics.Debug.Assert(_fileName == "", "Имя файла задано");
            FileStream fstream = new FileStream(_fileName, FileMode.OpenOrCreate);
            try
            {
                using (fstream)
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(DateTime.Now + ": " + message);
                    fstream.Write(array, 0, array.Length);
                }
            } catch (Exception e){
                var alert = new NSAlert();
                alert.MessageText = "Возникла ошибка";
                alert.InformativeText = "Ошибка №4: " + e.Message;
                alert.RunModal();
            } finally {
                fstream.Close();
            }

        }

    }
}
