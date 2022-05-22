using System.Collections.Generic;

namespace IIT.Routes
{
    public class PurchaseRegisterRoute : ucNavigationRouter
    {
        public PurchaseRegisterRoute() : base(new List<string>()
                    {
                        "Supplier Purchase Registers"
                        , "Stock based Purchases Report"
                        , "Periodicity Purchases Register"
                        , "Location Purchases Register"
                    }, "Purchases Registers")
        {
        }

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Supplier Purchase Registers":
                    break;
                case "Stock based Purchases Report":
                    break;
                case "Periodicity Purchases Register":
                    break;
                case "Location Purchases Register":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
