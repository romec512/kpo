// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using System.Collections.Generic;
using Kpo4310_asadovrs.Lib;
using Kpo4310_asadovrs.Utility;

namespace Kpo4310_asadovrs.Main
{
	public partial class SearchFormViewController : NSViewController
	{
        private Substance _substance;
        public Substance substance {
            get {
                return _substance;
            }
        }

        public SearchFormViewController (IntPtr handle) : base (handle)
		{
            _substance = null;
		}

        public void SetSubstance(Substance sub){
            _substance = sub;
            fillTextFields(sub);

        }

        private void fillTextFields(Substance substance){
            TFName.Enabled = true;
            TFName.Selectable = false;
            TFName.StringValue = substance.name;

            TFType.Enabled = true;
            TFType.Selectable = false;
            TFType.StringValue = substance.type.ToString();

            TFMinTemp.Enabled = true;
            TFMinTemp.Selectable = false;
            TFMinTemp.StringValue = substance.lowTemperature.ToString();

            TFMaxTemp.Enabled = true;
            TFMaxTemp.Selectable = false;
            TFMaxTemp.StringValue = substance.highTemperature.ToString();
        }
	}
}
