using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityType : NavigationBase
    {
        public int entityType = 0;
        private List<string> helpText = new List<string>() { "(Alt + I) ==> Individual", "(Alt + P) ==> Partnership",
        "(Alt + A) ==> AOP ","(Alt + C) ==> Company "};
        public override List<string> HelpText => helpText;

        public override string Caption => "Select Entity Type";

        [Obsolete]
        public frmEntityType()
        {
            InitializeComponent();
            btnIndividualFirm.Click += btnIndividualFirm_Click;
            btnPertnershipFirm.Click += btnPertnershipFirm_Click;
            btnAOP.Click += btnAOP_Click;
            btnCompany.Click += btnCompany_Click;
        }
        
        private void btnIndividualFirm_Click(object sender, EventArgs e)
        {
            entityType = 11;
            frmEntityIndividual obj = new frmEntityIndividual(entityType);
            Utility.ShowDialog(obj);
        }

        private void btnPertnershipFirm_Click(object sender, EventArgs e)
        {
            entityType = 12;
            frmPartnershipFirm obj = new frmPartnershipFirm(entityType);
            Utility.ShowDialog(obj);
        }

        private void btnAOP_Click(object sender, EventArgs e)
        {
            entityType = 14;
            frmPartnershipFirm obj = new frmPartnershipFirm(entityType);
            Utility.ShowDialog(obj);
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            entityType = 13;
            frmPartnershipFirm obj = new frmPartnershipFirm(entityType);
            Utility.ShowDialog(obj);
        }

        private void btnIndividualFirm_Click_1(object sender, EventArgs e)
        {

        }
    }
}