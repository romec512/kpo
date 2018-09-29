// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Kpo4310_asadovrs.Main
{
	[Register ("SearchFormViewController")]
	partial class SearchFormViewController
	{
		[Outlet]
		AppKit.NSButton buttonSeacrh { get; set; }

		[Outlet]
		AppKit.NSTextField searchName { get; set; }

		[Outlet]
		AppKit.NSTextField TFMaxTemp { get; set; }

		[Outlet]
		AppKit.NSTextField TFMinTemp { get; set; }

		[Outlet]
		AppKit.NSTextField TFName { get; set; }

		[Outlet]
		AppKit.NSTextField TFType { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonSeacrh != null) {
				buttonSeacrh.Dispose ();
				buttonSeacrh = null;
			}

			if (searchName != null) {
				searchName.Dispose ();
				searchName = null;
			}

			if (TFName != null) {
				TFName.Dispose ();
				TFName = null;
			}

			if (TFType != null) {
				TFType.Dispose ();
				TFType = null;
			}

			if (TFMinTemp != null) {
				TFMinTemp.Dispose ();
				TFMinTemp = null;
			}

			if (TFMaxTemp != null) {
				TFMaxTemp.Dispose ();
				TFMaxTemp = null;
			}
		}
	}
}
