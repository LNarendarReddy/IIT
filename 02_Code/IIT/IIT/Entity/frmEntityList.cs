using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : NavigationBase
    {
        public object EntityID;
        public object EntityName;
        public bool IsEntitySelected = false;
        EntityDataRepository entityDataRepository = new EntityDataRepository();

        private List<ActionText> helpText = new List<ActionText>() 
            { 
                new ActionText("Create", buildShort: false, shortCut: "(Alt + C)"),
                new ActionText("Modify", buildShort: false, shortCut: "(Alt + M)"),
                new ActionText("Select", buildShort: false, shortCut: "(Alt + S)")
            };
        public override NavigationBase PreviousControl { get => base.PreviousControl; set { } }
        public override IEnumerable<ActionText> HelpText => helpText;
        public override string Caption => "(Home)";

        public frmEntityList() 
        {    
            InitializeComponent();
        }
        private void frmEntityList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvEntityList);
            frmSingularMain.Instance.KeyPress += frmEntityList_KeyPress;
            BindDatasource();
        }
        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            List<string> actions = new List<string>()
            {
                "Individual / Proprietor Firm"
                , "Partnership Firm"
                , "AOP / BOI"
                , "Company"
            };

            ucNavigationRouter router = new ucNavigationRouter(actions, "Entity Selection", EntityTypeActionExecute);
            Utility.ShowDialog(router);
        }
        private void EntityTypeActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Individual / Proprietor Firm":
                    formObj = new frmEntityIndividual(11);
                    break;
                case "Partnership Firm":
                    formObj = new frmPartnershipFirm(12);
                    break;
                case "AOP / BOI":
                    formObj = new frmPartnershipFirm(14);
                    break;
                case "Company":
                    formObj = new frmPartnershipFirm(13);
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gvEntityList.FocusedRowHandle < 0)
                return;

            Utility.CurrentEntity = entityDataRepository.GetEntityData(
            gvEntityList.GetFocusedRowCellValue("ENTITYID"));

            List<string> actions = new List<string>()
            {
                "Ledgers Creation"
                , "Vouchers Entry"
                , "Accounting Reports"
                , "Requisition Forms"
            };

            ucNavigationRouter router = new ucNavigationRouter(actions, "Accounting", AccountingActionExecute);
            Utility.ShowDialog(router);
        }
        private void AccountingActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Ledgers Creation":
                    List<string> LCactions = new List<string>()
                    {
                        "Assets Ledgers"
                        , "Liabilities Ledgers"
                        , "Income Ledgers"
                        , "Expenses Ledgers"
                    };
                    formObj = new ucNavigationRouter(LCactions, actionText, LedgerCreationActionExecute);
                    break;
                case "Vouchers Entry":
                    List<string> VEactions = new List<string>()
                    {
                        "Bank Reciept voucher"
                        , "Bank payments voucher"
                        , "Cash Reciepts voucher"
                        , "Cash payments voucher"
                        , "Contra withdrawal voucher"
                        , "Contra Deposit voucher"
                        , "Journal Entry"
                        , "Inventory Entry"
                        , "Misc. Vouchers"
                    };
                    formObj = new ucNavigationRouter(VEactions, actionText, VoucherEntryActionExecute);
                    break;
                case "Accounting Reports":
                    List<string> actions = new List<string>()
                    {
                        "Trail Balance"
                        , "Balance Sheet"
                        , "Profit and Loss Account"
                        , "Cash Flow Statement"
                        , "Funds Flow Statement"
                    };
                    formObj = new ucNavigationRouter(actions, actionText, AccountingReportActionExecute);
                    break;
                case "Requisition Forms":
                    List<string> RFactions = new List<string>()
                    {
                        "Banking Utility"
                        , "Stock Statements"
                        , "Sales Registers"
                        , "Purchases Registers"
                        , "CMA Reports"
                        , "Pay Sheets"
                        , "Depreciation Sheets"
                        , "Statutory Sheets"
                        , "Ratio Analysis"
                    };
                    formObj = new ucNavigationRouter(RFactions, actionText, RequisitionFormsActionExecute);
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void LedgerCreationActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Assets Ledgers":
                    formObj = new frmLedgerCreation(Utility.AssetsHeadID, "Assets");
                    break;
                case "Liabilities Ledgers":
                    formObj = new frmLedgerCreation(Utility.LiabilitiesHeadID, "Liabilities");
                    break;
                case "Income Ledgers":
                    formObj = new frmLedgerCreation(Utility.IncomeHeadID, "Income");
                    break;
                case "Expenses Ledgers":
                    formObj = new frmLedgerCreation(Utility.ExpensesHeadID, "Expenses");
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void VoucherEntryActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Bank Reciept voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 58 });
                    break;
                case "Bank payments voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 56 });
                    break;
                case "Cash Reciepts voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 57 });
                    break;
                case "Cash payments voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 55 });
                    break;
                case "Contra withdrawal voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 59 });
                    break;
                case "Contra Deposit voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 60 });
                    break;
                case "Journal Entry":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 60 });
                    break;
                case "Inventory Entry":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 60 });
                    break;
                case "Misc. Vouchers":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = 60 });
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void AccountingReportActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Trail Balance":
                    break;
                case "Balance Sheet":
                    break;
                case "Profit and Loss Account":
                    break;
                case "Cash Flow Statement":
                    break;
                case "Funds Flow Statement":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void RequisitionFormsActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Banking Utility":
                    List<string> BUactions = new List<string>()
                    {
                        "Cheque Books Entry"
                        , "Cheque Print"
                        , "Cheque Register"
                        , "Post Dated cheques"
                    };
                    formObj = new ucNavigationRouter(BUactions, actionText, BankingUtilityActionExecute);
                    break;
                case "Stock Statements":
                    List<string> SSactions = new List<string>()
                    {
                        "Purchase orders"
                        , "Sales Orders"
                        , "COGS Reports ( Cost of Goods Sold)"
                        , "Stock wise Reports"
                        , "PO's Vs Invoices Reconciliation"
                        , "Stock Movement Reports - Internal transfers"
                        , "Inventory levels"
                    };
                    formObj = new ucNavigationRouter(SSactions, actionText, StockStatementsActionExecute);
                    break;
                case "Sales Registers":
                    List<string> SRactions = new List<string>()
                    {
                        "Customers Sales registers"
                        , "Stock based Sales Report"
                        , "Periodicity Sales Register"
                        , "Location Sales Register"
                    };
                    formObj = new ucNavigationRouter(SRactions, actionText, SalesRegistersActionExecute);
                    break;
                case "Purchases Registers":
                    List<string> PRactions = new List<string>()
                    {
                        "Supplier Purchase registers"
                        , "Stock based Purchases Report"
                        , "Periodicity Purchases Register"
                        , "Location Purchases Register"
                    };
                    formObj = new ucNavigationRouter(PRactions, actionText, PurchasesRegistersActionExecute);
                    break;
                case "CMA Reports":
                    break;
                case "Pay Sheets":
                    break;
                case "Depreciation Sheets":
                    break;
                case "Statutory Sheets":
                    break;
                case "Ratio Analysis":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void BankingUtilityActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Cheque Books Entry":
                    break;
                case "Cheque Print":
                    break;
                case "Cheque Register":
                    break;
                case "Post Dated cheques":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void StockStatementsActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Purchase orders":
                    break;
                case "Sales Orders":
                    break;
                case "COGS Reports ( Cost of Goods Sold)":
                    break;
                case "Stock wise Reports":
                    break;
                case "PO's Vs Invoices Reconciliation":
                    break;
                case "Stock Movement Reports - Internal transfers":
                    break;
                case "Inventory levels":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void SalesRegistersActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Customers Sales registers":
                    break;
                case "Stock based Sales Report":
                    break;
                case "Periodicity Sales Register":
                    break;
                case "Location Sales Register":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void PurchasesRegistersActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Supplier Purchase registers":
                    break;
                case "Stock based Purchases Report":
                    break;
                case "Periodicity Purchases Register":
                    break;
                case "Location Purchases Register":
                    break;
            }
            Utility.ShowDialog(formObj);
        }

        private void gvEntityList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            bool enabled = gvEntityList.FocusedRowHandle >= 0;
            btnModifyEntity.Enabled = enabled;
            btnSelect.Enabled = enabled;
            btnExport.Enabled = enabled;
        }
        private void btnModifyEntity_Click(object sender, EventArgs e)
        {
            if(gvEntityList.FocusedRowHandle < 0)
                return;
            if (gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID").Equals(11))
            {
                frmEntityIndividual obj = new frmEntityIndividual(1,
                    Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                Utility.ShowDialog(obj);
            }
            else
            {
                frmPartnershipFirm obj = new frmPartnershipFirm(Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID")),
                    Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                Utility.ShowDialog(obj);
            }

            BindDatasource();
        }
        private void btnExportEntity_Click(object sender, EventArgs e)
        {
            if (gvEntityList.FocusedRowHandle < 0)
                return;

            try
            {
                XtraSaveFileDialog xtraSaveFileDialog = new XtraSaveFileDialog();
                xtraSaveFileDialog.FileName = gvEntityList.GetFocusedRowCellValue("ENTITYNAME").ToString() + ".bin";
                if (xtraSaveFileDialog.ShowDialog() != DialogResult.OK) return;

                DataSet entityDataSource = entityDataRepository.GetEntityExportData(gvEntityList.GetFocusedRowCellValue("ENTITYID"));
                entityDataSource.RemotingFormat = SerializationFormat.Binary;

                FileStream fs = new FileStream(xtraSaveFileDialog.FileName, FileMode.Create);
                BinaryFormatter fmt = new BinaryFormatter();
                fmt.Serialize(fs, entityDataSource);
                fs.Close();

                XtraMessageBox.Show("Export completed");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Export failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            DataSet dsEntityDataFromFile;
            XtraOpenFileDialog xtraOpenFileDialog = new XtraOpenFileDialog();
            try
            {
                if (xtraOpenFileDialog.ShowDialog() != DialogResult.OK) return;

                using (Stream stream = xtraOpenFileDialog.OpenFile())
                {
                    BinaryFormatter format = new BinaryFormatter();
                    dsEntityDataFromFile = (DataSet)format.Deserialize(stream);
                }

                var output = entityDataRepository.ImportEntityData(dsEntityDataFromFile);
                BindDatasource();
                XtraMessageBox.Show(output);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }    
        }
        private void BindDatasource()
        {
            gcEntityList.DataSource = entityDataRepository.GetEntityList();
            gvEntityList_FocusedRowChanged(null, null);
        }
        private void gvEntityList_DoubleClick(object sender, EventArgs e)
        {        
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                btnSelect_Click(null, null);
            }
        }
        private void frmEntityList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Parent == null)
                return;
            if (e.KeyChar == (char)Keys.C)
                btnCreateEntity_Click(null, null);
            else if (e.KeyChar == (char)Keys.M && btnModifyEntity.Enabled)
                btnModifyEntity_Click(null, null);
        }
        private void frmEntityList_ParentChanged(object sender, EventArgs e)
        {
            if (Parent == null) return;

            BindDatasource();
            Utility.CurrentEntity = null;
            frmSingularMain.Instance.Text = "IIT";
        }
        private void btnviewLogo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (gvEntityList.FocusedRowHandle < 0)
            //    return;
            //Utility.ShowDialog(new frmEntityLogo(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
        }
        private void gvEntityList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            btnSelect_Click(null, null);
        }
    }
}