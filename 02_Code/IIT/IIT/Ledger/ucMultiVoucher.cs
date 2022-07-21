using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucMultiVoucher : NavigationBase
    {
        private readonly object voucherTypeID;
        BindingList<Voucher> vouchersList = new BindingList<Voucher>();
        DataTable paymentFromSource = null;
        DataTable paymentToSource = null;

        public override string Caption => "Multiple Voucher Entry";

        private readonly List<ActionText> helpText = new List<ActionText>()
            {
                new ActionText("Save", buildShort: false, shortCut: "Ctrl + S")
            };

        public override IEnumerable<ActionText> HelpText => helpText;

        public ucMultiVoucher(MultiVoucherSettings multiVoucherSettings)
        {
            InitializeComponent();
            voucherTypeID = multiVoucherSettings.VoucherTypeID;
            lblVoucherTypeHeader.Text = $"Multiple voucher creation for : {multiVoucherSettings.VoucherTypeHeader}";
            gcPaymentFrom.Caption = multiVoucherSettings.FromPaymentHeader;
            gcPaymentTo.Caption = multiVoucherSettings.ToPaymentHeader;
            gcPurpose.Caption = multiVoucherSettings.PurposeText;
            paymentFromSource = multiVoucherSettings.FromPaymentSource as DataTable;
            paymentToSource = multiVoucherSettings.ToPaymentSource as DataTable;

            rluPaymentFrom.DataSource = paymentFromSource;
            rluPaymentTo.DataSource = paymentToSource;

            rluPaymentFrom.DisplayMember = "LEDGERNAME";
            rluPaymentFrom.ValueMember = "LEDGERID";

            rluPaymentTo.DisplayMember = "LEDGERNAME";
            rluPaymentTo.ValueMember = "LEDGERID";

            if (paymentFromSource.Rows.Count == 1) rluPaymentFrom.ReadOnly = true;
            if (paymentToSource.Rows.Count == 1) rluPaymentTo.ReadOnly = true;
        }

        private void ucMultiVoucher_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvVouchers);
            gcVouchers.DataSource = vouchersList;
            gvVouchers.AddNewRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!gvVouchers.UpdateCurrentRow())
            {
                XtraMessageBox.Show("Some of the values are not entered");
                return;
            }

            new VoucherRepository().Save(vouchersList.ToList());
            frmSingularMain.Instance.RollbackControl(false);
        }

        private void gvVouchers_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvVouchers.SetRowCellValue(e.RowHandle, "VoucherTypeID", voucherTypeID);
            gvVouchers.SetRowCellValue(e.RowHandle, "VoucherDate", DateTime.Now);

            if (paymentFromSource.Rows.Count == 1)
                gvVouchers.SetRowCellValue(e.RowHandle, "PaymentFrom", paymentFromSource.Rows[0]["LEDGERID"]);
            if (paymentToSource.Rows.Count == 1)
                gvVouchers.SetRowCellValue(e.RowHandle, "PaymentTo", paymentToSource.Rows[0]["LEDGERID"]);

            gvVouchers.SetRowCellValue(e.RowHandle, "UserName", Utility.UserName);
            gvVouchers.SetRowCellValue(e.RowHandle, "EntityID", Utility.CurrentEntity.ID);
        }

        private void rbtnAddNew_Click(object sender, EventArgs e)
        {
            gvVouchers.AddNewRow();
        }

        private void gvVouchers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                gvVouchers.MoveNext();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave_Click(null, null);
                return true;
            }
           
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gvVouchers_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            Voucher currentVoucherObj = gvVouchers.GetFocusedRow() as Voucher;

            if (currentVoucherObj.VoucherDate == null)
            {
                e.Valid = false;
                gvVouchers.SetColumnError(gvVouchers.Columns["VoucherDate"], "Value cannot be empty");
            }

            if (currentVoucherObj.PaymentFrom == null)
            {
                e.Valid = false;
                gvVouchers.SetColumnError(gvVouchers.Columns["PaymentFrom"], "Value cannot be empty");
            }

            if (currentVoucherObj.PaymentTo == null)
            {
                e.Valid = false;
                gvVouchers.SetColumnError(gvVouchers.Columns["PaymentTo"], "Value cannot be empty");
            }

            if (string.IsNullOrEmpty(currentVoucherObj.Purpose?.ToString()))
            {
                e.Valid = false;
                gvVouchers.SetColumnError(gvVouchers.Columns["Purpose"], "Value cannot be empty");
            }

            if (currentVoucherObj.Amount == null || Convert.ToDecimal(currentVoucherObj.Amount) == 0)
            {
                e.Valid = false;
                gvVouchers.SetColumnError(gvVouchers.Columns["Amount"], "Value cannot be empty");
            }
        }

        private void gvVouchers_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            //Suppress displaying the error message box
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }

    public class MultiVoucherSettings
    {
        public object VoucherTypeID { get; set; }

        public string VoucherTypeHeader { get; set; } 

        public object FromPaymentSource { get; set; }

        public object ToPaymentSource { get; set; }

        public string PurposeText { get; set; }

        public string ToPaymentHeader { get; set; }

        public string FromPaymentHeader { get; set; }


    }
}
