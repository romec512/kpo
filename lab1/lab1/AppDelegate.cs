using System;
using AppKit;
using Foundation;
using Kpo4310_asadovrs.Lib;

namespace Kpo4310_asadovrs.Main
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {
        #region Computed Properties
        public NSWindow Window { get; set; }
        #endregion
        [Outlet]
        AppKit.NSTableColumn TableColumnSubMax { get; set; }
        public AppDelegate(){

        }


        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
            Window = NSApplication.SharedApplication.Windows[0];
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }



    }
}
