using System.Collections.Generic;

namespace IIT.Routes
{
    public class AccountingRoute : ucNavigationRouter
    {        
        public AccountingRoute() : base(new List<string>()
                    {
                        "Ledgers Creation"
                        , "Vouchers Entry"
                        , "Accounting Reports"
                        , "Requisition Forms"
                    }, "Accounting")
        {
        }

        public override bool ShowQuickOptions => false;

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Ledgers Creation":
                    formObj = new LedgerCreationRoute();
                    break;
                case "Vouchers Entry":                   
                    formObj = new VoucherEntryRoute();
                    break;
                case "Accounting Reports":
                    formObj = new AccountingReportsRoute();
                    break;
                case "Requisition Forms":
                    formObj = new RequisitionFormsRoute();
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
