using Repository.Utility;
using System.Collections.Generic;

namespace IIT.Routes
{
    public class LedgerCreationRoute : ucNavigationRouter
    {
        public LedgerCreationRoute() : base(new List<string>()
                    {
                        "Assets Ledgers"
                        , "Liabilities Ledgers"
                        , "Income Ledgers"
                        , "Expenses Ledgers"
                    }, "Ledgers Creation")
        {
        }

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Assets Ledgers":
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Assets, "Assets");
                    break;
                case "Liabilities Ledgers":
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Liabilities, "Liabilities");
                    break;
                case "Income Ledgers":
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Incomes, "Income");
                    break;
                case "Expenses Ledgers":
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Expenses, "Expenses");
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
