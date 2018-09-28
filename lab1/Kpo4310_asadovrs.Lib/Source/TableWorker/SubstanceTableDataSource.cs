using System;
using System.Collections.Generic;
using AppKit;

namespace Kpo4310_asadovrs.Lib
{
    public class SubstanceTableDataSource : NSTableViewDataSource
    {
        public SubstanceTableDataSource()
        {
        }

        #region Public Variables
        public List<Substance> Substances = new List<Substance>();
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return Substances.Count;
        }
        #endregion
    }
}
