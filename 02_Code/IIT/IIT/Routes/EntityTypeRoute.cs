using Repository.Utility;
using System.Collections.Generic;

namespace IIT.Routes
{
    public class EntityTypeRoute : ucNavigationRouter
    {
        public EntityTypeRoute() : base(new List<string>()
                    {
                        "Individual / Proprietor Firm"
                        , "Partnership Firm"
                        , "Company"
                        , "AOP / BOI"
                    }, "Entity Selection")
        {
        }

        public override bool ShowQuickOptions => false;


        public override void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Individual / Proprietor Firm":
                    formObj = new frmEntityIndividual(LookUpIDMap.EntityType_IndividualEntity);
                    break;
                case "Partnership Firm":
                    formObj = new frmPartnershipFirm(LookUpIDMap.EntityType_Firm);
                    break;
                case "AOP / BOI":
                    formObj = new frmPartnershipFirm(LookUpIDMap.EntityType_AOPBOI);
                    break;
                case "Company":
                    formObj = new frmPartnershipFirm(LookUpIDMap.EntityType_Company);
                    break;
            }
            Utility.ShowDialog(formObj);
        }
    }
}
