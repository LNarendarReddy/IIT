using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmVoucher : XtraForm
    {
        Voucher voucherObj;

        public frmVoucher(Voucher voucher)
        {
            InitializeComponent();
            voucherObj = voucher;
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            luVoucherType.Properties.DataSource = LookUpUtility.GetVoucherType();
            luVoucherType.Properties.DisplayMember = "LOOKUPVALUE";
            luVoucherType.Properties.ValueMember = "ENTITYLOOKUPID";

            luVoucherType.EditValue = voucherObj.VoucherTypeID;
            txtVoucherNumber.EditValue = voucherObj.VoucherNumber;
            txtRefNo.EditValue = voucherObj.RefNO;
            txtAmount.EditValue = voucherObj.Amount;
            txtPaymentFrom.EditValue = voucherObj.PaymentFrom;
            txtPaymentTo.EditValue = voucherObj.PaymentTo;
            txtBankName.EditValue = voucherObj.BankName;
            mePurpose.EditValue = voucherObj.Purpose;
            dtVoucherDate.EditValue = voucherObj.VoucherDate ?? DateTime.Now;

            Text = string.IsNullOrEmpty(voucherObj.VoucherNumber?.ToString()) ? Text : $"{Text} - {voucherObj.VoucherNumber}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            voucherObj.VoucherTypeID = luVoucherType.EditValue;
            voucherObj.VoucherNumber = txtVoucherNumber.EditValue;
            voucherObj.RefNO = txtRefNo.EditValue;
            voucherObj.Amount = txtAmount.EditValue;
            voucherObj.PaymentFrom = txtPaymentFrom.EditValue;
            voucherObj.PaymentTo = txtPaymentTo.EditValue;
            voucherObj.BankName = txtBankName.EditValue;
            voucherObj.Purpose = mePurpose.EditValue;
            voucherObj.VoucherDate = dtVoucherDate.EditValue;
            voucherObj.UserName = Utility.UserName;

            try
            {
                new VoucherRepository().Save(voucherObj);
                voucherObj.IsSave = true;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}