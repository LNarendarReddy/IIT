using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSingularMain : DevExpress.XtraEditors.XtraForm
    {
        private static frmSingularMain _instance = null;

        public static frmSingularMain Instance { get { return _instance ?? (_instance = new frmSingularMain()); } }

        public NavigationBase CurrentControl { get; set; }

        public frmSingularMain()
        {
            InitializeComponent();
        }

        private void frmSingularMain_Load(object sender, EventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Utility.ReportsPath = Path.Combine(folder, @"IIT\Reports");
            Utility.CompanyPath = Path.Combine(folder, @"IIT\Company");

            if (!Directory.Exists(Utility.ReportsPath))
                Directory.CreateDirectory(Utility.ReportsPath);

            if (!Directory.Exists(Utility.CompanyPath))
                Directory.CreateDirectory(Utility.CompanyPath);

            lblReportsPath.Text = $"Reports Path : {Utility.ReportsPath}";
            lblCompanyPath.Text = $"Company Path : {Utility.CompanyPath}";

            Utility.ShowDialog(new frmEntityList());
        }

        public void RollbackControl(bool showPrompt = true)
        {
            showPrompt = showPrompt && !(pcMain.Controls[0] is ucNavigationRouter);

            if (showPrompt 
                && XtraMessageBox.Show("Are you sure you want to close?"
                    , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                != DialogResult.Yes) return;

            Utility.ShowDialog((pcMain.Controls[0] as NavigationBase)?.PreviousControl);
        }

        private void frmSingularMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != (char) Keys.Escape)
            //    return;
            //RollbackControl();
        }

        private void frmSingularMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape || CurrentControl == null || CurrentControl.HandlesESC)
                return;
            RollbackControl();
        }
    }
}