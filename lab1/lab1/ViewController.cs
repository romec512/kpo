using System;

using AppKit;
using Foundation;
using Kpo4310_asadovrs.Lib;
using Kpo4310_asadovrs.Main;

namespace lab1Kpo4310_asadovrs.Main
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Do any additional setup after loading the view.

        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        [Export("actionEscape:")]
        public void actionEscape(NSObject sender)
        {
            Environment.Exit(0);
        }

        [Export("actionOpen:")]
        public void actionOpen(NSObject sender)
        {
            try
            {
                MockSubstanceListCommand loader = new MockSubstanceListCommand();
                loader.Execute();
                var data = new SubstanceTableDataSource();
                data.Substances = loader.substanceList;
                TableView.DataSource = data;
                TableView.Delegate = new SubstanceTableDelegate(data);

            }
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
