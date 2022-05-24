using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.UI;
using Entity;
using Repository;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmVoucher : NavigationBase
    {
        private string caption;
        public override string Caption => caption;
        private List<ActionText> helpText = new List<ActionText>()
            {
                new ActionText("Save", buildShort: false, shortCut: "Alt + S"),
                new ActionText("Add Ledger", buildShort: false, shortCut: "Alt + L")
            };

        public override IEnumerable<ActionText> HelpText => helpText;

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
            UpdateLabels();
            caption = lblformHeader.Text;
            Text = string.IsNullOrEmpty(voucherObj.VoucherNumber?.ToString()) ? Text : $"{Text} - {voucherObj.VoucherNumber}";
        }

        private void UpdateLabels()
        {
            switch (Convert.ToInt32(voucherObj.VoucherTypeID))
            {
                case LookUpIDMap.VoucherType_CashPayment:
                    lblformHeader.Text = "CASH PAYMENT VOUCHER";
                    lciPaymentMadeFrom.Text = "Payment made from";
                    lciPaymentMadeTo.Text = "Payment made to";
                    lciPurpose.Text = "Narration of the payment ";
                    cmbPaymentMadefrom.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeFrom.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedgerFrom.Visibility = LayoutVisibility.Never;
                    break;
                case LookUpIDMap.VoucherType_BankPayment:
                    lblformHeader.Text = "BANK PAYMENT VOUCHER";
                    lciPaymentMadeFrom.Text = "Bank account";
                    lciPaymentMadeTo.Text = "Payment made to";
                    lciPurpose.Text = "Narration of the payment ";
                    break;
                case LookUpIDMap.VoucherType_CashReciept:
                    lblformHeader.Text = "CASH RECIEPT VOUCHER";
                    lciPaymentMadeFrom.Text = "Amount received from";
                    lciPaymentMadeTo.Text = "Amount credited to";
                    lciPurpose.Text = "Narration of the reciept ";
                    cmbPaymentMadeto.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeTo.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedger1To.Visibility = LayoutVisibility.Never;
                    break;
                case LookUpIDMap.VoucherType_BankReciept:
                    lblformHeader.Text = "BANK RECIEPT VOUCHER";
                    lciPaymentMadeFrom.Text = "Amount received from";
                    lciPaymentMadeTo.Text = "Bank account";
                    lciPurpose.Text = "Narration of the reciept ";
                    break;
                case LookUpIDMap.VoucherType_ContraVoucher_Withdrawal:
                    lblformHeader.Text = "CONTRA VOUCHER - Withdrawal";
                    lciPaymentMadeFrom.Text = "Bank Account";
                    lciPaymentMadeTo.Text = "Amount credited to";
                    lciPurpose.Text = "Narration ";
                    cmbPaymentMadeto.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeTo.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedger1To.Visibility = LayoutVisibility.Never;
                    break;
                case LookUpIDMap.VoucherType_ContraVoucher_Deposit:
                    lblformHeader.Text = "CONTRA VOUCHER - Deposit";
                    lciPaymentMadeFrom.Text = "Amount debited from";
                    lciPaymentMadeTo.Text = "Bank Account";
                    lciPurpose.Text = "Reasons ";
                    cmbPaymentMadefrom.EditValue = Utility.CurrentEntity.CASHINHANDID;
                    lciPaymentMadeFrom.Visibility = LayoutVisibility.Never;
                    lcibtnAddLedgerFrom.Visibility = LayoutVisibility.Never;
                    break;
                default:
                    break;
            }
        }

        private void cmbPaymentMadefrom_EditValueChanged(object sender, EventArgs e)
        {
            cmbPaymentMadeto.EditValue = null;
            if (cmbPaymentMadefrom.EditValue == null)
                return;

            BindLookups();

            DataTable table = cmbPaymentMadeto.Properties.DataSource as DataTable;
            DataView clone = new DataView(table);
            clone.RowFilter = string.Format($"[LEDGERID] <> {cmbPaymentMadefrom.EditValue}");
            cmbPaymentMadeto.Properties.DataSource = clone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Savevoucher();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Savevoucher(true);
        }

        private void Savevoucher(bool IsPrint = false)
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
                if (IsPrint)
                {
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
                        case LookUpIDMap.VoucherType_CashPayment:
                            rpt.Parameters["VoucherCaption"].Value = "CASH PAYMENT VOUCHER";
                            rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount debited form :";
                            rpt.Parameters["PaymentMadeToCaption"].Value = "Payment made to :";
                            rpt.Parameters["PurposeCaption"].Value = "Narration of the payment :";
                            break;
                        case LookUpIDMap.VoucherType_BankPayment:
                            rpt.Parameters["VoucherCaption"].Value = "BANK PAYMENT VOUCHER";
                            rpt.Parameters["PaymentMadeFromCaption"].Value = "Bank account :";
                            rpt.Parameters["PaymentMadeToCaption"].Value = "Payment made to :";
                            rpt.Parameters["PurposeCaption"].Value = "Narration of the payment :";
                            break;
                        case LookUpIDMap.VoucherType_CashReciept:
                            rpt.Parameters["VoucherCaption"].Value = "CASH RECIEPT VOUCHER";
                            rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount recieved from :";
                            rpt.Parameters["PaymentMadeToCaption"].Value = "Cash credited to :";
                            rpt.Parameters["PurposeCaption"].Value = "Narration of the reciept :";
                            break;
                        case LookUpIDMap.VoucherType_BankReciept:
                            rpt.Parameters["VoucherCaption"].Value = "BANK RECIEPT VOUCHER";
                            rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount recieved from :";
                            rpt.Parameters["PaymentMadeToCaption"].Value = "Bank Account :";
                            rpt.Parameters["PurposeCaption"].Value = "Narration of the reciept :";
                            break;
                        case LookUpIDMap.VoucherType_ContraVoucher_Withdrawal:
                            rpt.Parameters["VoucherCaption"].Value = "CONTRA VOUCHER - Withdrawal";
                            rpt.Parameters["PaymentMadeFromCaption"].Value = "Bank Account :";
                            rpt.Parameters["PaymentMadeToCaption"].Value = "Amount credited to :";
                            rpt.Parameters["PurposeCaption"].Value = "Narration :";
                            break;
                        case LookUpIDMap.VoucherType_ContraVoucher_Deposit:
                            rpt.Parameters["VoucherCaption"].Value = "CONTRA VOUCHER - Deposit";
                            rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount debited from :";
                            rpt.Parameters["PaymentMadeToCaption"].Value = "Bank Account :";
                            rpt.Parameters["PurposeCaption"].Value = "Narration :";
                            break;
                        default:
                            break;
                    }
                    rpt.ShowRibbonPreview();
                }
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
                    double.TryParse(Convert.ToString(txtAmountIRupees.EditValue), out double dValue) 
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
            if (lciPaymentMadeTo.Visibility == LayoutVisibility.Never)
                cmbPaymentMadefrom.Focus();
            else
                cmbPaymentMadeto.Focus();
        }

        private void BindLookups()
        {
            object selectedto = cmbPaymentMadeto.EditValue;
            object selectedfrom = cmbPaymentMadefrom.EditValue;
            switch (Convert.ToInt32(voucherObj.VoucherTypeID))
            {
                case LookUpIDMap.VoucherType_CashPayment:
                    cmbPaymentMadefrom.Properties.DataSource = Utility.GetLedgers();
                    cmbPaymentMadeto.Properties.DataSource = Utility.GetNonCashLedgers();
                    break;
                case LookUpIDMap.VoucherType_BankPayment:
                    cmbPaymentMadefrom.Properties.DataSource = Utility.GetBankingLedgers();
                    cmbPaymentMadeto.Properties.DataSource = Utility.GetNonCashLedgers();
                    break;
                case LookUpIDMap.VoucherType_CashReciept:
                    cmbPaymentMadefrom.Properties.DataSource = Utility.GetNonCashLedgers();
                    cmbPaymentMadeto.Properties.DataSource = Utility.GetLedgers();
                    break;
                case LookUpIDMap.VoucherType_BankReciept:
                    cmbPaymentMadefrom.Properties.DataSource = Utility.GetNonCashLedgers();
                    cmbPaymentMadeto.Properties.DataSource = Utility.GetBankingLedgers();
                    break;
                case LookUpIDMap.VoucherType_ContraVoucher_Withdrawal:
                    cmbPaymentMadefrom.Properties.DataSource = Utility.GetBankingLedgers();
                    cmbPaymentMadeto.Properties.DataSource = Utility.GetLedgers();
                    break;
                case LookUpIDMap.VoucherType_ContraVoucher_Deposit:
                    cmbPaymentMadefrom.Properties.DataSource = Utility.GetLedgers();
                    cmbPaymentMadeto.Properties.DataSource = Utility.GetBankingLedgers();
                    break;
                default:
                    break;
            }
            cmbPaymentMadefrom.Properties.DisplayMember = "LEDGERNAME";
            cmbPaymentMadefrom.Properties.ValueMember = "LEDGERID";
            cmbPaymentMadefrom.EditValue = selectedfrom;

            cmbPaymentMadeto.Properties.DisplayMember = "LEDGERNAME";
            cmbPaymentMadeto.Properties.ValueMember = "LEDGERID";
            cmbPaymentMadeto.EditValue = selectedto;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.L))
            {
                btnAdd_Click(null, null);
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void cmbPaymentMadeto_Enter(object sender, EventArgs e)
        {
            
        }
    }
}