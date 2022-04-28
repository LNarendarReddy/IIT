using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSingularMain : DevExpress.XtraEditors.XtraForm
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
                
        private void frmSingularMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
                return;   
            RollbackControl();
        }

        public void RollbackControl()
        {
            Utility.ShowDialog((pcMain.Controls[0] as NavigationBase).PreviousControl);
        }
    }
}