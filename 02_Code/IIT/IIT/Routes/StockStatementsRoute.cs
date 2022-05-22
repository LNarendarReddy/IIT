using System.Collections.Generic;

namespace IIT.Routes
{
    public class StockStatementsRoute : ucNavigationRouter
    {
        public StockStatementsRoute() : base(new List<string>()
                    {
                        "Purchase Orders"
                        , "Sales Orders"
                        , "COGS Reports ( Cost of Goods Sold)"
                        , "Stock Wise Reports"
                        , "PO's Vs Invoices Reconciliation"
                        , "Stock Movement Reports - Internal transfers"
                        , "Inventory Levels"
                    }, "Stock Statements")
        {
        }

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Purchase Orders":
                    break;
                case "Sales Orders":
                    break;
                case "COGS Reports ( Cost of Goods Sold)":
                    break;
                case "Stock Wise Reports":
                    break;
                case "PO's Vs Invoices Reconciliation":
                    break;
                case "Stock Movement Reports - Internal transfers":
                    break;
                case "Inventory Levels":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
