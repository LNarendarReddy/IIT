using System.Collections.Generic;

namespace IIT.Routes
{
    public class AccountingReportsRoute : ucNavigationRouter
    {
        public AccountingReportsRoute() : base(new List<string>()
                    {
                        "On Demand Reports"
                        ,"Ledger Reports"
                        ,"Day Book"
                        ,"Inventory Reports"
                        ,"Banking/Finance Utility"
                        ,"Financial Reports"
                        , "Trail Balance"
                        , "Balance Sheet"
                        , "Profit and Loss Account"
                        , "Cash Flow Statement"
                        , "Funds Flow Statement"
                    }, "Accounting Reports")
        {
        }

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Ledger Reports":
                    formObj = new ucLedgerList();
                    break;
                case "Day Book":
                    formObj = new frmVoucherList();
                    break;
                case "Inventory Reports":
                    break;
                case "Banking/Finance Utility":
                    formObj = new BankingUtilityRoute();
                    break;
                case "Trail Balance":
                    break;
                case "Balance Sheet":
                    break;
                case "Profit and Loss Account":
                    break;
                case "Cash Flow Statement":
                    break;
                case "Funds Flow Statement":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
