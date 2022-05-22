using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Entity;
using Repository;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : NavigationBase
    {
        public object EntityID;
        public object EntityName;
        public bool IsEntitySelected = false;
        private const int GridMinWidth = 300;
        private const int GridMinHeight = 100;
        EntityDataRepository entityDataRepository = new EntityDataRepository();

        List<string> entitylistactions = new List<string>()
            {
                "Create"
                , "Modify"
                , "Select"
                , "Export"
                , "Import"
                , "Shut"
                ,"Admin Settings"
            };

        private List<ActionText> helpText = new List<ActionText>();
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
            int i = 1;
            gcButtons.DataSource = helpText = entitylistactions.Select(x => new ActionText(x, i++)).ToList();
            gvButtons.BestFitColumns();
            UpdateGridSize();
            BindDatasource();
        }
        private void EntityListActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Create":
                    List<string> createactions = new List<string>()
                    {
                        "Individual / Proprietor Firm"
                        , "Partnership Firm"
                        , "AOP / BOI"
                        , "Company"
                    };
                    formObj = new ucNavigationRouter(createactions, "Entity Selection", EntityTypeActionExecute);
                    break;
                case "Modify":
                    if (gvEntityList.FocusedRowHandle < 0)
                        return;
                    if (gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID").Equals(11))
                        formObj = new frmEntityIndividual(11,Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                    else
                        formObj = new frmPartnershipFirm(Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID")),
                            Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                    break;
                case "Select":
                    formObj = SelectEntity();
                    break;
                case "Export":
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
                    break;
                case "Import":
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
                    break;
                case "Shut":
                    break;
                case "Admin Settings":
                    Utility.ShowDialog(new frmSettings());
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void EntityTypeActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Individual / Proprietor Firm":
                    formObj = new frmEntityIndividual(LookUpIDMap.EntityType_IndividualEntity);
                    break;
                case "Partnership Firm":
                    formObj = new frmPartnershipFirm(LookUpIDMap.EntityType_Firm);
                    break;
                case "AOP / BOI":
                    formObj = new frmPartnershipFirm(LookUpIDMap.EntityType_AOPBOI);
                    break;
                case "Company":
                    formObj = new frmPartnershipFirm(LookUpIDMap.EntityType_Company);
                    break;
            }
            Utility.ShowDialog(formObj);
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
                        "Bank Reciept Voucher"
                        , "Bank Payments Voucher"
                        , "Cash Reciepts Voucher"
                        , "Cash Payments Voucher"
                        , "Contra Withdrawal Voucher"
                        , "Contra Deposit Voucher"
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
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Assets, "Assets");
                    break;
                case "Liabilities Ledgers":
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Liabilities, "Liabilities");
                    break;
                case "Income Ledgers":
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Incomes, "Income");
                    break;
                case "Expenses Ledgers":
                    formObj = new frmLedgerCreation(LookUpIDMap.Classification_Expenses, "Expenses");
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void VoucherEntryActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Bank Reciept Voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_BankReciept });
                    break;
                case "Bank Payments Voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_BankPayment });
                    break;
                case "Cash Reciepts Voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_CashReciept });
                    break;
                case "Cash Payments Voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_CashPayment });
                    break;
                case "Contra Withdrawal Voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_ContraVoucher_Withdrawal });
                    break;
                case "Contra Deposit Voucher":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_ContraVoucher_Deposit });
                    break;
                case "Journal Entry":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_ContraVoucher_Deposit });
                    break;
                case "Inventory Entry":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_ContraVoucher_Deposit });
                    break;
                case "Misc. Vouchers":
                    formObj = new frmVoucher(new Voucher() { VoucherTypeID = LookUpIDMap.VoucherType_ContraVoucher_Deposit });
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
                        , "Post Dated Cheques"
                    };
                    formObj = new ucNavigationRouter(BUactions, actionText, BankingUtilityActionExecute);
                    break;
                case "Stock Statements":
                    List<string> SSactions = new List<string>()
                    {
                        "Purchase Orders"
                        , "Sales Orders"
                        , "COGS Reports ( Cost of Goods Sold)"
                        , "Stock Wise Reports"
                        , "PO's Vs Invoices Reconciliation"
                        , "Stock Movement Reports - Internal transfers"
                        , "Inventory Levels"
                    };
                    formObj = new ucNavigationRouter(SSactions, actionText, StockStatementsActionExecute);
                    break;
                case "Sales Registers":
                    List<string> SRactions = new List<string>()
                    {
                        "Customers Sales Registers"
                        , "Stock based Sales Report"
                        , "Periodicity Sales Register"
                        , "Location Sales Register"
                    };
                    formObj = new ucNavigationRouter(SRactions, actionText, SalesRegistersActionExecute);
                    break;
                case "Purchases Registers":
                    List<string> PRactions = new List<string>()
                    {
                        "Supplier Purchase Registers"
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
                case "Post Dated Cheques":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void StockStatementsActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Purchase Orders":
                    break;
                case "Sales Orders":
                    break;
                case "COGS Reports ( Cost of Goods Sold)":
                    break;
                case "Stock Wise Reports":
                    break;
                case "PO's Vs Invoices Reconciliation":
                    break;
                case "Stock Movement Reports - Internal transfers":
                    break;
                case "Inventory Levels":
                    break;
            }
            Utility.ShowDialog(formObj);
        }
        private void SalesRegistersActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Customers Sales Registers":
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
                case "Supplier Purchase Registers":
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
        private void BindDatasource()
        {
            gcEntityList.DataSource = entityDataRepository.GetEntityList();
        }
        private void gvEntityList_DoubleClick(object sender, EventArgs e)
        {        
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                Utility.ShowDialog(SelectEntity());
            }
        }
        private NavigationBase SelectEntity()
        {
            NavigationBase navigationBase = null;
            if (gvEntityList.FocusedRowHandle >= 0)
            {
                Utility.CurrentEntity = entityDataRepository.GetEntityData(
                gvEntityList.GetFocusedRowCellValue("ENTITYID"));
                List<string> selectactions = new List<string>()
                    {
                        "Ledgers Creation"
                        , "Vouchers Entry"
                        , "Accounting Reports"
                        , "Requisition Forms"
                    };
                navigationBase = new ucNavigationRouter(selectactions, "Accounting", AccountingActionExecute);
            }
            return navigationBase;
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
            Utility.ShowDialog(SelectEntity());
        }
        private void UpdateGridSize()
        {
            GridViewInfo viewInfo = (GridViewInfo)gvButtons.GetViewInfo();
            FieldInfo fi = typeof(GridView).GetField("scrollInfo", BindingFlags.Instance | BindingFlags.NonPublic);
            ScrollInfo scrollInfo = (ScrollInfo)fi.GetValue(gvButtons);
            int width = viewInfo.ViewRects.IndicatorWidth;
            foreach (GridColumn column in gvButtons.VisibleColumns)
            {
                if (viewInfo.GetColumnLeftCoord(column) < viewInfo.ViewRects.ColumnPanelWidth)
                    gvButtons.LeftCoord = width;
                try
                {
                    width += viewInfo.ColumnsInfo[column].Bounds.Width;
                }
                catch (Exception ex) { }
            }
            if (scrollInfo.VScrollVisible) width += scrollInfo.VScrollSize;
            int height = viewInfo.CalcRealViewHeight(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), true);
            if (scrollInfo.HScrollVisible) height += scrollInfo.HScrollSize;
            width = Math.Max(GridMinWidth, width);
            width = Math.Min(ClientSize.Width - gcButtons.Location.X, width);
            height = Math.Max(GridMinHeight, height);
            height = Math.Min(ClientSize.Height - gcButtons.Location.Y, height);
            gcButtons.Size = new Size(width, height);
            gvButtons.LayoutChanged();
        }
        private void gcButtons_Click(object sender, EventArgs e)
        {
            EntityListActionExecute(Convert.ToString(gvButtons.GetRowCellValue(gvButtons.FocusedRowHandle, "Action")));
        }
        private void gcButtons_KeyUp(object sender, KeyEventArgs e)
        {
            int inputNumber = gvButtons.FocusedRowHandle + 1;
            if (e.KeyCode != Keys.Enter)
            {
                if (!e.Control || !char.IsNumber((char)e.KeyCode)
                    || !int.TryParse(((char)e.KeyCode).ToString(), out inputNumber) || !(inputNumber > 0) || !(inputNumber <= gvButtons.RowCount))
                    return;
            }

            gvButtons.FocusedRowHandle = inputNumber - 1;
            gcButtons_Click(sender, e);
        }
    }
}