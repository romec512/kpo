using System;
using AppKit;

namespace Kpo4310_asadovrs.Lib
{
    public class SubstanceTableDelegate : NSTableViewDelegate
    {
        public SubstanceTableDelegate()
        {
        }

        #region Constants 
        private const string CellIdentifier = "SubCell";
        #endregion

        #region Private Variables
        private SubstanceTableDataSource DataSource;
        #endregion

        #region Constructors
        public SubstanceTableDelegate(SubstanceTableDataSource datasource)
        {
            this.DataSource = datasource;
        }
        #endregion

        #region Override Methods
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Название вещества":
                    view.StringValue = DataSource.Substances[(int)row].name;
                    break;
                case "Тип вещества":
                    if (DataSource.Substances[(int)row].type == 'M')
                    {
                        view.StringValue = "Металл";
                    } else if(DataSource.Substances[(int)row].type == 'C'){
                        view.StringValue = "Соединение";
                    } else if(DataSource.Substances[(int)row].type == 'P'){
                        view.StringValue = "Сплав";
                    }
                    break;
                case "Минимальная температура перехода":
                    view.StringValue = DataSource.Substances[(int)row].lowTemperature.ToString();
                    break;
                case "Максимальная температура перехода" :
                    view.StringValue = DataSource.Substances[(int)row].highTemperature.ToString();
                    break;
            }

            return view;
        }
        #endregion

    }
}
