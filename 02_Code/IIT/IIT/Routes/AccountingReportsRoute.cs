using IIT.ReportForms;
using System.Collections.Generic;

namespace IIT.Routes
{
    public class AccountingReportsRoute : ucNavigationRouter
    {
        public AccountingReportsRoute() : base(new List<ActionText>()
                    {
                        new ActionText("On Demand Reports", isHeader:true)
                        , new ActionText("Ledger Reports", 1)
                        , new ActionText("Day Book", 2)
                        , new ActionText("Inventory Reports", 3)
                        , new ActionText("Banking/Finance Utility", 4)
                        , new ActionText("Financial Reports", isHeader:true)
                        , new ActionText( "Trail Balance", 5)
                        , new ActionText( "Balance Sheet", 6)
                        , new ActionText( "Profit and Loss Account", 7)
                        , new ActionText( "Cash Flow Statement", 8)
                        , new ActionText( "Funds Flow Statement", 9)
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
                    formObj = new ucTrailBalance();
                    break;
                case "Balance Sheet":
                    formObj = new ucBalanceSheet();
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
