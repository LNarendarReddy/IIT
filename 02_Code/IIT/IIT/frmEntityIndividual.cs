using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityIndividual : DevExpress.XtraEditors.XtraForm
    {
        int entityType = 0;
        public frmEntityIndividual()
        {
            InitializeComponent();
            frmEntityType frmentitytype = new frmEntityType();
            Utility.showDialog(frmentitytype);
            entityType = frmentitytype.entityType;
        }

        private void frmEntityIndividual_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {

        }

        private void frmEntityIndividual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }
    }
}