// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace lab1Kpo4310_asadovrs.Main
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSComboBox SStatus { get; set; }

		[Outlet]
		AppKit.NSTableColumn TableColumnSubMax { get; set; }

		[Outlet]
		AppKit.NSTableColumn TableColumnSubMin { get; set; }

		[Outlet]
		AppKit.NSTableColumn TableColumnSubName { get; set; }

		[Outlet]
		AppKit.NSTableColumn TableColumnSubType { get; set; }

		[Outlet]
		AppKit.NSTableView TableView { get; set; }

		[Outlet]
		AppKit.NSTextField TFDataFileName { get; set; }

		[Outlet]
		AppKit.NSTextField TFLogPath { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SStatus != null) {
				SStatus.Dispose ();
				SStatus = null;
			}

			if (TableColumnSubMax != null) {
				TableColumnSubMax.Dispose ();
				TableColumnSubMax = null;
			}

			if (TableColumnSubMin != null) {
				TableColumnSubMin.Dispose ();
				TableColumnSubMin = null;
			}

			if (TableColumnSubName != null) {
				TableColumnSubName.Dispose ();
				TableColumnSubName = null;
			}

			if (TableColumnSubType != null) {
				TableColumnSubType.Dispose ();
				TableColumnSubType = null;
			}

			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}

			if (TFLogPath != null) {
				TFLogPath.Dispose ();
				TFLogPath = null;
			}

			if (TFDataFileName != null) {
				TFDataFileName.Dispose ();
				TFDataFileName = null;
			}
		}
	}
}
