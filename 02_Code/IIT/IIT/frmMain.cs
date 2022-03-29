using System;

namespace IIT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEntityList obj = new frmEntityList();
            Utility.showDialog(obj);
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            lblDateTime.Caption = DateTime.Now.ToString();
            btnEntity_ItemClick(null, null);
        }
    }
}
