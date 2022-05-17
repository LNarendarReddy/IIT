using System;
using System.IO;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            RollbackControl();
        }
    }
}