using DevExpress.XtraEditors;
using IIT.Routes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSingularMain : XtraForm
    {
        private static frmSingularMain _instance = null;

        private readonly AccountingRoute accountingRoute = new AccountingRoute();

        public static frmSingularMain Instance { get { return _instance ?? (_instance = new frmSingularMain()); } }
        
        public NavigationBase CurrentControl { get; set; }

        private Dictionary<string, object> requestCache = new Dictionary<string, object>();

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
            NavigationBase previousControl = (pcMain.Controls[0] as NavigationBase)?.PreviousControl;
            if (previousControl == null) return;
            showPrompt = showPrompt && !(pcMain.Controls[0] is ucNavigationRouter) && previousControl != null;
            if (showPrompt 
                && XtraMessageBox.Show("Are you sure you want to close?"
                    , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                != DialogResult.Yes) return;
            previousControl.Visible = true;
            Utility.ShowDialog(previousControl);
        }

        public bool HasRequest(string requestName) => requestCache.ContainsKey(requestName);

        public void AddRequest(string requestName) => requestCache[requestName] = null;

        public void AddRequestValue(string requestName, object requestValue) => requestCache[requestName] = requestValue;

        public object GetRequestValue(string requestName) => HasRequest(requestName) ? requestCache[requestName] : null;

        public void RemoveRequest(string requestName) 
        {
            if (!HasRequest(requestName))
            {
                return;
            }

            requestCache.Remove(requestName); 
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

        private void btnLedgerCreation_Click(object sender, EventArgs e)
        {
            accountingRoute.ActionExecute((sender as SimpleButton).Text);
        }

        private void btnVoucherEntry_Click(object sender, EventArgs e)
        {
            accountingRoute.ActionExecute((sender as SimpleButton).Text);
        }

        private void btnAccountingReports_Click(object sender, EventArgs e)
        {
            accountingRoute.ActionExecute((sender as SimpleButton).Text);
        }

        private void btnRequisitionForms_Click(object sender, EventArgs e)
        {
            accountingRoute.ActionExecute((sender as SimpleButton).Text);
        }
    }
}