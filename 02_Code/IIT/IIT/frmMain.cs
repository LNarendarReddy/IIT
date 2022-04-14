using System;

namespace IIT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static frmMain _instance = null;

        public static frmMain Instance { get { return _instance ?? (_instance = new frmMain()); } }

        private frmMain()
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
            lblVersion.Caption = "1.1.1 (06-04-2022)";
            btnEntity_ItemClick(null, null);
        }

        public void UpdateStatusBar(string message)
        {
            lblStatus.Caption = message;
        }
    }
}
