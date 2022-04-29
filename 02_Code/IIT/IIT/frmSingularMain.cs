using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSingularMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static frmSingularMain _instance = null;

        public static frmSingularMain Instance { get { return _instance ?? (_instance = new frmSingularMain()); } }

        public frmSingularMain()
        {
            InitializeComponent();
        }

        private void frmSingularMain_Load(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmEntityList());
        }

        public void RollbackControl()
        {
            Utility.ShowDialog((pcMain.Controls[0] as NavigationBase)?.PreviousControl);
        }

        private void frmSingularMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Escape)
                return;
            RollbackControl();
        }
    }
}