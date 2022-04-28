using Entity;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityType : NavigationBase
    {
        public int entityType = 0;
        public frmEntityType()
        {
            InitializeComponent();
        }
        
        private void btnIndividualFirm_Click(object sender, EventArgs e)
        {
            entityType = 11;
            frmEntityIndividual obj = new frmEntityIndividual(entityType);
            Utility.ShowDialog(obj);
            if (obj.IsSave)
                frmSingularMain.Instance.RollbackControl();
        }

        private void btnPertnershipFirm_Click(object sender, EventArgs e)
        {
            entityType = 12;
            frmPartnershipFirm obj = new frmPartnershipFirm(entityType);
            Utility.ShowDialog(obj);
            if (obj.IsSave)
                frmSingularMain.Instance.RollbackControl();
        }

        private void btnAOP_Click(object sender, EventArgs e)
        {
            entityType = 14;
            frmPartnershipFirm obj = new frmPartnershipFirm(entityType);
            Utility.ShowDialog(obj);
            if (obj.IsSave)
                frmSingularMain.Instance.RollbackControl();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            entityType = 13;
            frmPartnershipFirm obj = new frmPartnershipFirm(entityType);
            Utility.ShowDialog(obj);
            if (obj.IsSave)
                frmSingularMain.Instance.RollbackControl();
        }
    }
}