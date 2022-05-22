using System.Collections.Generic;

namespace IIT.Routes
{
    public class RequisitionFormsRoute : ucNavigationRouter
    {
        public RequisitionFormsRoute() : base(new List<string>()
                    {
                        "Banking Utility"
                        , "Stock Statements"
                        , "Sales Registers"
                        , "Purchases Registers"
                        , "CMA Reports"
                        , "Pay Sheets"
                        , "Depreciation Sheets"
                        , "Statutory Sheets"
                        , "Ratio Analysis"
                    }, "Requisition Forms")
        {
        }

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Banking Utility":
                    formObj = new BankingUtilityRoute();
                    break;
                case "Stock Statements":
                    formObj = new StockStatementsRoute();
                    break;
                case "Sales Registers":
                    formObj = new SalesRegisterRoute();
                    break;
                case "Purchases Registers":
                    formObj = new PurchaseRegisterRoute();
                    break;
                case "CMA Reports":
                    break;
                case "Pay Sheets":
                    break;
                case "Depreciation Sheets":
                    break;
                case "Statutory Sheets":
                    break;
                case "Ratio Analysis":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
