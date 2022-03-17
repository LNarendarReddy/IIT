using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityType : DevExpress.XtraEditors.XtraForm
    {
        public int entityType = 0;
        public frmEntityType()
        {
            InitializeComponent();
        }

        private void frmEntityType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void btnIndividualFirm_Click(object sender, EventArgs e)
        {
            entityType = 0;
            this.Close();
        }

        private void btnPertnershipFirm_Click(object sender, EventArgs e)
        {
            entityType = 1;
            this.Close();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            entityType = 2;
            this.Close();
        }

        private void btnAOP_Click(object sender, EventArgs e)
        {
            entityType = 3;
            this.Close();
        }
    }
}