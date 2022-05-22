using System.Collections.Generic;

namespace IIT.Routes
{
    public class SalesRegisterRoute : ucNavigationRouter
    {
        public SalesRegisterRoute() : base(new List<string>()
                    {
                        "Customers Sales Registers"
                        , "Stock based Sales Report"
                        , "Periodicity Sales Register"
                        , "Location Sales Register"
                    }, "Sales Registers")
        {
        }

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Customers Sales Registers":
                    break;
                case "Stock based Sales Report":
                    break;
                case "Periodicity Sales Register":
                    break;
                case "Location Sales Register":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
