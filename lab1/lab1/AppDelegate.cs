using System;
using AppKit;
using Foundation;

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
            window.PerformClose(window);
        }

        [Export("actionOpen:")]
        public void actionOpen(NSObject sender){
            try{
                throw new NotImplementedException();
            } catch (NotImplementedException){
                NSAlert alert = new NSAlert();
                alert.MessageText = "Что-то не так";
                alert.InformativeText = "Кажется, что что-то пошло не так";
                alert.RunModal();
            }
        }

    }
}
