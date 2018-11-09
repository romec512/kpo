using System;

using AppKit;
using Foundation;
using Kpo4310_asadovrs.Lib;
using Kpo4310_asadovrs.Main;

namespace lab1Kpo4310_asadovrs.Main
{
    public partial class ViewController : NSViewController
    {
        //private BindingSource bsEmploees = new BindingSource();


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Do any additional setup after loading the view.
            TFLogPath.StringValue = Kpo4310_asadovrs.AppGlobalSettings.LogPath;
            TFDataFileName.StringValue = Kpo4310_asadovrs.AppGlobalSettings.DataFileName;
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
                //MockSubstanceListCommand loader = new MockSubstanceListCommand();
                //loader.Execute();
                //ISubFactory factory = new SubstanceFileFactory();
                ISubFactory factory = new SubstanceTestFactory();
                ISubstanceListLoader loader = factory.CreateLoader();
                loader.Execute();
                var data = new SubstanceTableDataSource();
                data.Substances = loader.GetSubstances();
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

        [Export("openSubstance:")]
        public void openSubstance(NSObject sender){
            var storyboard = NSStoryboard.FromName("MainForm", null);
            var controller = storyboard.InstantiateControllerWithIdentifier("MyTestWindow") as NSWindowController;
            
            // Display
            controller.ShowWindow(this);
        }

        [Export("SelectRow:")]
        public void getSelectedRow(NSObject sender){
            var source = TableView.DataSource as SubstanceTableDataSource;

            var storyboard = NSStoryboard.FromName("MainForm", null);
            var controller = storyboard.InstantiateControllerWithIdentifier("MyTestWindow") as NSWindowController;
            var viewController = controller.ContentViewController as SearchFormViewController;
            viewController.SetSubstance(source.GetRow(TableView.SelectedRow));
            controller.ShowWindow(this);

        }

        [Export("actionAddSubstance:")]
        public void actionAddSubstance(NSObject sender){
            var storyboard = NSStoryboard.FromName("MainForm", null);
            var controller = storyboard.InstantiateControllerWithIdentifier("MyTestWindow") as NSWindowController;
            var viewController = controller.ContentViewController as SearchFormViewController;
            viewController.InitializeViewForAddingSubstance(); //Делаем активной кнопку и поля для ввода
            controller.ShowWindow(this);
        }
    }
}
