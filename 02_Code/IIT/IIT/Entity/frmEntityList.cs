using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : DevExpress.XtraEditors.XtraForm
    {
        public frmEntityList()
        {
            InitializeComponent();
        }

        private void frmEntityList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            this.Close();
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            frmEntityIndividual  frmEntityIndividual = new frmEntityIndividual();
            Utility.showDialog(frmEntityIndividual);
        }
    }
}