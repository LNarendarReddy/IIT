using System.Collections.Generic;

namespace IIT.Routes
{
    public class AccountingReportsRoute : ucNavigationRouter
    {
        public AccountingReportsRoute() : base(new List<string>()
                    {
                        "Trail Balance"
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
