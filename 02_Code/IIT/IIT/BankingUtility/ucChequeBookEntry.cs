using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucChequeBookEntry : NavigationBase
    {
        BankingRepository bankingRepository = new BankingRepository();
        private static string caption = "Banking - Cheque Book Entry";
        public ucChequeBookEntry():base (caption)
        {
            InitializeComponent();
        }

        private void ucChequeBookEntry_Load(object sender, EventArgs e)
        {
            lblHeader.Text = caption;
            cmbLedger.Properties.DataSource = Utility.GetBankingLedgers();
            cmbLedger.Properties.ValueMember = "LEDGERID";
            cmbLedger.Properties.DisplayMember = "LEDGERNAME";
        }

        private void cmbLedger_Leave(object sender, EventArgs e)
        {
            if (cmbLedger.EditValue == null)
            {
                gcChequeRegister.DataSource = null;
                return;
            }
            gcChequeRegister.DataSource = 
                bankingRepository.GetChequeRegister(cmbLedger.EditValue);
        }

        private void gvChequeRegister_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
               GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, "CHEQUEREGISTERID", -1);
                view.SetRowCellValue(e.RowHandle, "LEDGERID", cmbLedger.EditValue);
        }

        private void gvChequeRegister_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
            GridView view = sender as GridView;
            DataRow row = (e.Row as DataRowView).Row;
            view.SetRowCellValue(e.RowHandle,
                "CHEQUEREGISTERID", bankingRepository.Save(row, Utility.UserName));
        }

        private void gvChequeRegister_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataRowView focusedRow = (DataRowView)gvChequeRegister.GetFocusedRow();
            if (!focusedRow.IsNew) return;
            foreach (DataColumn column in focusedRow.DataView.Table.Columns)
            {
                e.Valid = !focusedRow.Row.IsNull(column);
                if (!e.Valid) return;
            }
        }

        private void gvChequeRegister_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "OPENINGCHEQUENO" || e.Column.FieldName == "NOOFLEAFS")
            {
                GridView gv = sender as GridView;
                 if(int.TryParse(Convert.ToString(gv.GetFocusedRowCellValue("OPENINGCHEQUENO")), 
                     out int OpeningChequeNo) &&
                    int.TryParse(Convert.ToString(gv.GetFocusedRowCellValue("NOOFLEAFS")), 
                    out int NoOfLeafs))
                {
                    gv.SetFocusedRowCellValue("CLOSINGCHEQUENO", OpeningChequeNo + (NoOfLeafs - 1));
                }
            }
        }

        private void gvChequeRegister_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = (gvChequeRegister.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle);
        }
    }
}
