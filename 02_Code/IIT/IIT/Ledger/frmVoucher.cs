using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.UI;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmVoucher : NavigationBase
    {
        private List<string> helpText = new List<string>() { "(Alt + S) ==> Save", "(Alt + L) ==> Add ledger" };
        public override List<string> HelpText => helpText;
        Voucher voucherObj;
        public frmVoucher(Voucher _voucherObj)
        {
            InitializeComponent();
            voucherObj = _voucherObj;
            dtpVoucherDate.EditValue = DateTime.Now;
        }

        private void frmVoucherNew_Load(object sender, EventArgs e)
        {
            BindLookups();

            txtRefNo.EditValue = voucherObj.VoucherNumber;
            txtAmountIRupees.EditValue = voucherObj.Amount;
            cmbPaymentMadeto.EditValue = voucherObj.PaymentTo;
            cmbPaymentMadefrom.EditValue = voucherObj.PaymentFrom;
            txtPurposeofPayment.EditValue = voucherObj.Purpose;
            dtpVoucherDate.EditValue = voucherObj.VoucherDate ?? DateTime.Now;

            switch (Convert.ToInt32(voucherObj.VoucherTypeID))
            {
                case 55:
                    lblformHeader.Text = "CASH PAYMENT VOUCHER";
                    lciPaymentMadeFrom.Text = "Payment made from :";
                    lciPaymentMadeTo.Text = "Payment made to :";
                    lciPurpose.Text = "Purpose of the payment ";
                    cmbPaymentMadefrom.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeFrom.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedgerFrom.Visibility = LayoutVisibility.Never;
                    break;
                case 56:
                    lblformHeader.Text = "BANK PAYMENT VOUCHER";
                    lciPaymentMadeFrom.Text = "Bank account :";
                    lciPaymentMadeTo.Text = "Payment made to :";
                    lciPurpose.Text = "Purpose of the payment ";
                    break;
                case 57:
                    lblformHeader.Text = "CASH RECIEPT VOUCHER";
                    lciPaymentMadeFrom.Text = "Cash received from :";
                    lciPaymentMadeTo.Text = "Amount credited to :";
                    lciPurpose.Text = "Purpose of the reciept ";
                    cmbPaymentMadeto.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeTo.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedger1To.Visibility = LayoutVisibility.Never;
                    break;
                case 58:
                    lblformHeader.Text = "BANK RECIEPT VOUCHER";
                    lciPaymentMadeFrom.Text = "Cash received from :";
                    lciPaymentMadeTo.Text = "Bank account :";
                    lciPurpose.Text = "Purpose of the reciept ";
                    break;
                case 59:
                    lblformHeader.Text = "CONTRA VOUCHER - Withdrawal";
                    lciPaymentMadeFrom.Text = "Amount withdrawn from :";
                    lciPaymentMadeTo.Text = "Cash credited to :";
                    lciPurpose.Text = "Reasons ";
                    cmbPaymentMadeto.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeTo.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedger1To.Visibility = LayoutVisibility.Never;
                    break;
                case 60:
                    lblformHeader.Text = "CONTRA VOUCHER - Deposit";
                    lciPaymentMadeFrom.Text = "Cash debited from :";
                    lciPaymentMadeTo.Text = "Amount deposited in to :";
                    lciPurpose.Text = "Reasons ";
                    cmbPaymentMadefrom.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeFrom.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedgerFrom.Visibility = LayoutVisibility.Never;
                    break;
                default:
                    break;
            }

            Text = string.IsNullOrEmpty(voucherObj.VoucherNumber?.ToString()) ? Text : $"{Text} - {voucherObj.VoucherNumber}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            voucherObj.VoucherNumber = txtRefNo.EditValue;
            voucherObj.Amount = txtAmountIRupees.EditValue;
            
            voucherObj.PaymentFrom = lciPaymentMadeFrom.Visibility == LayoutVisibility.Never ? 
                Utility.CurrentEntity.CASHINHANDID : cmbPaymentMadefrom.EditValue;
            
            voucherObj.PaymentTo = lciPaymentMadeTo.Visibility == LayoutVisibility.Never ? 
                Utility.CurrentEntity.CASHINHANDID : cmbPaymentMadeto.EditValue;

            voucherObj.Purpose = txtPurposeofPayment.EditValue;
            voucherObj.VoucherDate = dtpVoucherDate.EditValue;
            voucherObj.UserName = Utility.UserName;
            voucherObj.EntityID = Utility.CurrentEntity.ID;

            try
            {
                new VoucherRepository().Save(voucherObj);
                voucherObj.IsSave = true;

                rptVoucher rpt = new rptVoucher();
                rpt.Parameters["OrgName"].Value = Utility.CurrentEntity.EntityName;
                rpt.Parameters["VoucherTypeID"].Value = voucherObj.VoucherTypeID;
                rpt.Parameters["VoucherDate"].Value = voucherObj.VoucherDate;
                rpt.Parameters["VoucherNumber"].Value = voucherObj.VoucherNumber;
                rpt.Parameters["AmountInRupees"].Value = voucherObj.Amount;
                rpt.Parameters["AmountInWords"].Value = voucherObj.AmountInWords;
                rpt.Parameters["PaymentMadeFrom"].Value = cmbPaymentMadefrom.Text;
                rpt.Parameters["PaymentMadeTo"].Value = cmbPaymentMadeto.Text;
                rpt.Parameters["Purpose"].Value = voucherObj.Purpose;

                switch (Convert.ToInt32(voucherObj.VoucherTypeID))
                {
                    case 55:
                        rpt.Parameters["VoucherCaption"].Value = "CASH PAYMENT VOUCHER";
                        rpt.Parameters["PaymentMadeFromCaption"].Value = "Cash debited form :";
                        rpt.Parameters["PaymentMadeToCaption"].Value = "Payment made to :";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the payment :";
                        break;
                    case 56:
                        rpt.Parameters["VoucherCaption"].Value = "BANK PAYMENT VOUCHER";
                        rpt.Parameters["PaymentMadeFromCaption"].Value = "Bank account :";
                        rpt.Parameters["PaymentMadeToCaption"].Value = "Payment made to :";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the payment :";
                        break;
                    case 57:
                        rpt.Parameters["VoucherCaption"].Value = "CASH RECIEPT VOUCHER";
                        rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount recieved from :";
                        rpt.Parameters["PaymentMadeToCaption"].Value = "Cash credited to :";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the reciept :";
                        break;
                    case 58:
                        rpt.Parameters["VoucherCaption"].Value = "BANK RECIEPT VOUCHER";
                        rpt.Parameters["PaymentMadeFromCaption"].Value = "Bank Account :";
                        rpt.Parameters["PaymentMadeToCaption"].Value = "Payment made to :";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the reciept :";
                        break;
                    case 59:
                        rpt.Parameters["VoucherCaption"].Value = "CONTRA VOUCHER - Withdrawal";
                        rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount withdrawn from :";
                        rpt.Parameters["PaymentMadeToCaption"].Value = "Amount credited to :";
                        rpt.Parameters["PurposeCaption"].Value = "Reasons :";
                        break;
                    case 60:
                        rpt.Parameters["VoucherCaption"].Value = "CONTRA VOUCHER - Deposit";
                        rpt.Parameters["PaymentMadeFromCaption"].Value = "Cash debited from :";
                        rpt.Parameters["PaymentMadeToCaption"].Value = "Cash deposited to :";
                        rpt.Parameters["PurposeCaption"].Value = "Reasons :";
                        break;
                    default:
                        break;
                }
                rpt.ShowRibbonPreview();
                frmSingularMain.Instance.RollbackControl();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmSingularMain.Instance.RollbackControl();
        }

        private void txtAmountIRupees_Leave(object sender, EventArgs e)
        {
            try
            {
                voucherObj.AmountInWords = 
                    long.TryParse(Convert.ToString(txtAmountIRupees.EditValue), out long dValue) 
                        ? Utility.ConvertNum(dValue) 
                        : string.Empty;

                txtAmountInWords.Text = Convert.ToString(voucherObj.AmountInWords);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error while converting numbers to words : " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Ledger ledgerobj = new Ledger();
            Utility.ShowDialog(new frmLedger(ledgerobj));
            if (!ledgerobj.IsSave)
                return;
            BindLookups();
        }

        private void BindLookups()
        {
            object selectedfrom = cmbPaymentMadeto.EditValue;
            object selectedto = cmbPaymentMadefrom.EditValue;

            DataTable dt = new LedgerRepository().GetLedgerList(Utility.CurrentEntity.ID);

            cmbPaymentMadefrom.Properties.DataSource = dt;
            cmbPaymentMadefrom.Properties.DisplayMember = "LEDGERNAME";
            cmbPaymentMadefrom.Properties.ValueMember = "LEDGERID";
            cmbPaymentMadefrom.EditValue = selectedfrom;

            cmbPaymentMadeto.Properties.DataSource = dt;
            cmbPaymentMadeto.Properties.DisplayMember = "LEDGERNAME";
            cmbPaymentMadeto.Properties.ValueMember = "LEDGERID";
            cmbPaymentMadeto.EditValue = selectedto;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.L))
            {
                btnAdd_Click(null, null);
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}