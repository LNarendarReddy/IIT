﻿using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Entity;
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
    public partial class frmVoucher : DevExpress.XtraEditors.XtraForm
    {
        Voucher voucherObj;
        public frmVoucher(Voucher _voucherObj)
        {
            InitializeComponent();
            voucherObj = _voucherObj;
            switch (Convert.ToInt32(voucherObj.VoucherTypeID))
            {
                case 55:
                    lblformHeader.Text = "CASH PAYMENT VOUCHER";
                    lciBankAccount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciPaymentMadeTo.Text = "Payment Made to : ";
                    lciPurpose.Text = "Purpose of the Payment ";
                    break;
                case 56:
                    lblformHeader.Text = "BANK PAYMENT VOUCHER";
                    lciPaymentMadeTo.Text = "Payment Made to : ";
                    lciBankAccount.Text = "Payment Made from : ";
                    lciPurpose.Text = "Purpose of the Payment ";
                    break;
                case 57:
                    lblformHeader.Text = "CASH RECIEPT VOUCHER";
                    lciBankAccount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lciPaymentMadeTo.Text = "Amount received From : ";
                    lciPurpose.Text = "Purpose of the Reciept ";
                    break;
                case 58:
                    lblformHeader.Text = "BANK RECIEPT VOUCHER";
                    lciPaymentMadeTo.Text = "Amount received From : ";
                    lciBankAccount.Text = "Amount Credit to : ";
                    lciPurpose.Text = "Purpose of the Reciept ";
                    break;
                default:
                    break;
            }
            dtpVoucherDate.EditValue = DateTime.Now;
        }

        private void frmVoucherNew_Load(object sender, EventArgs e)
        {
            luPaymentMadeto.Properties.DataSource = new LedgerRepository().GetLedgerList(Utility.CurrentEntity.ID);
            luPaymentMadeto.Properties.DisplayMember = "LEDGERNAME";
            luPaymentMadeto.Properties.ValueMember = "LEDGERID";

            luBankAccount.Properties.DataSource = new LedgerRepository().GetLedgerList(Utility.CurrentEntity.ID);
            luBankAccount.Properties.DisplayMember = "LEDGERNAME";
            luBankAccount.Properties.ValueMember = "LEDGERID";

            txtRefNo.EditValue = voucherObj.VoucherNumber;
            txtAmountIRupees.EditValue = voucherObj.Amount;
            luPaymentMadeto.EditValue = voucherObj.PaymentTo;
            luBankAccount.EditValue = voucherObj.BankName;
            txtPurposeofPayment.EditValue = voucherObj.Purpose;
            dtpVoucherDate.EditValue = voucherObj.VoucherDate ?? DateTime.Now;

            Text = string.IsNullOrEmpty(voucherObj.VoucherNumber?.ToString()) ? Text : $"{Text} - {voucherObj.VoucherNumber}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            voucherObj.VoucherNumber = txtRefNo.EditValue;
            voucherObj.Amount = txtAmountIRupees.EditValue;
            voucherObj.PaymentTo = luPaymentMadeto.EditValue;
            voucherObj.BankName = luBankAccount.EditValue;
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
                rpt.Parameters["LedgerName"].Value = luPaymentMadeto.Text;
                rpt.Parameters["BankName"].Value = luBankAccount.Text;
                rpt.Parameters["Purpose"].Value = voucherObj.Purpose;

                switch (Convert.ToInt32(voucherObj.VoucherTypeID))
                {
                    case 55:
                        rpt.Parameters["VoucherCaption"].Value = "CASH PAYMENT VOUCHER";
                        rpt.Parameters["IsBankVoucher"].Value = false;
                        rpt.Parameters["LedgerNameCaption"].Value = "Payment Made to : ";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the Payment : ";
                        break;
                    case 56:
                        rpt.Parameters["VoucherCaption"].Value = "BANK PAYMENT VOUCHER";
                        rpt.Parameters["IsBankVoucher"].Value = true;
                        rpt.Parameters["LedgerNameCaption"].Value = "Payment Made to : ";
                        rpt.Parameters["BankNameCaption"].Value = "Payment Made from : ";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the Payment : ";
                        break;
                    case 57:
                        rpt.Parameters["VoucherCaption"].Value = "CASH RECIEPT VOUCHER";
                        rpt.Parameters["IsBankVoucher"].Value = false;
                        rpt.Parameters["LedgerNameCaption"].Value = "Amount received From : ";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the Reciept : ";
                        break;
                    case 58:
                        rpt.Parameters["VoucherCaption"].Value = "BANK RECIEPT VOUCHER";
                        rpt.Parameters["IsBankVoucher"].Value = true;
                        rpt.Parameters["LedgerNameCaption"].Value = "Amount received From : ";
                        rpt.Parameters["BankNameCaption"].Value = "Amount Credit to : ";
                        rpt.Parameters["PurposeCaption"].Value = "Purpose of the Reciept : ";
                        break;
                    default:
                        break;
                }
                rpt.ShowRibbonPreview();
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmountIRupees_Leave(object sender, EventArgs e)
        {
            try
            {
                voucherObj.AmountInWords = string.Empty;
                if (long.TryParse(Convert.ToString(txtAmountIRupees.EditValue), out long dValue))
                {
                    voucherObj.AmountInWords = Utility.ConvertNum(dValue);
                }

                txtAmountInWords.Text = Convert.ToString(voucherObj.AmountInWords);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error while converting numbers to words : " + ex.Message);
            }
        }
    }
}