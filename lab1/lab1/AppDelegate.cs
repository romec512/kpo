using System;
using AppKit;
using Foundation;
using Kpo4310_asadovrs.Lib;

namespace Kpo4310_asadovrs.Main
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        #region Computed Properties
        public NSWindow Window { get; set; }
        #endregion
        public AppDelegate(){

        }


        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }


        [Export("actionEscape:")]
        public void actionEscape(NSObject sender){
           var window =  NSApplication.SharedApplication.Windows[0];
            //window.PerformClose(window);
            Environment.Exit(0);
        }

        [Export("actionOpen:")]
        public void actionOpen(NSObject sender){
            try
            {
                //Вызов исключения "Метод не реализован"
                //throw new NotImplementedException();
                //Вызов базового исключения
                throw new Exception("Неправильные входные параметры");
            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                NSAlert alert = new NSAlert();
                alert.MessageText = "Возникла ошибка";
                alert.InformativeText = "Ошибка №1: " + ex.Message ;
                alert.RunModal();
                LogUtility.ErrorLog("Ошибка №1: " + ex.Message);

            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                NSAlert alert = new NSAlert();
                alert.MessageText = "Возникла ошибка";
                alert.InformativeText = "Ошибка №2: " + ex.Message;
                alert.RunModal();
                LogUtility.ErrorLog("Ошибка №2: " + ex.Message);
            }
        }

    }
}
