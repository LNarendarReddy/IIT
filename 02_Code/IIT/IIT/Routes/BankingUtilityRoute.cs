﻿using System.Collections.Generic;

namespace IIT.Routes
{
    public class BankingUtilityRoute : ucNavigationRouter
    {
        public BankingUtilityRoute() : base(new List<string>()
                    {
                        "Cheque Books Entry"
                        , "Cheque Print"
                        , "Cheque Register"
                        , "Post Dated Cheques"
                    }, "Banking Utility")
        {
        }

        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Cheque Books Entry":
                    break;
                case "Cheque Print":
                    break;
                case "Cheque Register":
                    break;
                case "Post Dated Cheques":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
