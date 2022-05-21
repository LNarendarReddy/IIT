using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Repository;
using Entity;
using DevExpress.XtraReports.UI;

namespace IIT
{
    public partial class frmVoucherList : NavigationBase
    {
        VoucherRepository voucherRepository = new VoucherRepository();

        public frmVoucherList()
        {
            InitializeComponent();
        }

        private void btnModifyVoucher_Click(object sender, EventArgs e)
        {
            if (gvVoucher.FocusedRowHandle < 0) return;

            Voucher voucherObj = voucherRepository.Load(gvVoucher.GetFocusedDataRow());
            Utility.ShowDialog(new frmVoucher(voucherObj));
            if (voucherObj.IsSave)
            {
                gcVoucher.DataSource = voucherRepository.GetVoucherList(Utility.CurrentEntity.ID);
                gvVoucher.FocusedRowHandle = gvVoucher.LocateByValue("VOUCHERID", voucherObj.ID);
            }
        }

        private void frmVoucherList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvVoucher);
            gcVoucher.DataSource = voucherRepository.GetVoucherList(Utility.CurrentEntity.ID);
        }

        private void btnView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvVoucher.FocusedRowHandle < 0)
                return;
            rptVoucher rpt = new rptVoucher();
            rpt.Parameters["OrgName"].Value = Utility.CurrentEntity.EntityName;
            rpt.Parameters["VoucherTypeID"].Value = gvVoucher.GetFocusedRowCellValue("VOUCHERTYPEID");
            rpt.Parameters["VoucherDate"].Value = gvVoucher.GetFocusedRowCellValue("VOUCHERDATE");
            rpt.Parameters["VoucherNumber"].Value = gvVoucher.GetFocusedRowCellValue("VOUCHERNUMBER");
            rpt.Parameters["AmountInRupees"].Value = gvVoucher.GetFocusedRowCellValue("AMOUNT");
            rpt.Parameters["AmountInWords"].Value = Utility.ConvertNum(Convert.ToDouble(gvVoucher.GetFocusedRowCellValue("AMOUNT")));
            rpt.Parameters["PaymentMadeFrom"].Value = gvVoucher.GetFocusedRowCellValue("FROMLEDGER");
            rpt.Parameters["PaymentMadeTo"].Value = gvVoucher.GetFocusedRowCellValue("TOLEDGER");
            rpt.Parameters["Purpose"].Value = gvVoucher.GetFocusedRowCellValue("PURPOSE");

            switch (Convert.ToInt32(gvVoucher.GetFocusedRowCellValue("VOUCHERTYPEID")))
            {
                case 55:
                    rpt.Parameters["VoucherCaption"].Value = "CASH PAYMENT VOUCHER";
                    rpt.Parameters["IsBankVoucher"].Value = false;
                    rpt.Parameters["IsContraVoucher"].Value = false;
                    rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount debited form :";
                    rpt.Parameters["PaymentMadeToCaption"].Value = "Payment made to :";
                    rpt.Parameters["PurposeCaption"].Value = "Narration of the payment :";
                    break;
                case 56:
                    rpt.Parameters["VoucherCaption"].Value = "BANK PAYMENT VOUCHER";
                    rpt.Parameters["IsBankVoucher"].Value = true;
                    rpt.Parameters["IsContraVoucher"].Value = false;
                    rpt.Parameters["PaymentMadeFromCaption"].Value = "Bank account :";
                    rpt.Parameters["PaymentMadeToCaption"].Value = "Payment made to :";
                    rpt.Parameters["PurposeCaption"].Value = "Narration of the payment :";
                    break;
                case 57:
                    rpt.Parameters["VoucherCaption"].Value = "CASH RECIEPT VOUCHER";
                    rpt.Parameters["IsBankVoucher"].Value = false;
                    rpt.Parameters["IsContraVoucher"].Value = false;
                    rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount recieved from :";
                    rpt.Parameters["PaymentMadeToCaption"].Value = "Amount credited to :";
                    rpt.Parameters["PurposeCaption"].Value = "Narration of the reciept :";
                    break;
                case 58:
                    rpt.Parameters["VoucherCaption"].Value = "BANK RECIEPT VOUCHER";
                    rpt.Parameters["IsBankVoucher"].Value = true;
                    rpt.Parameters["IsContraVoucher"].Value = false;
                    rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount recieved from :";
                    rpt.Parameters["PaymentMadeToCaption"].Value = "Bank account :";
                    rpt.Parameters["PurposeCaption"].Value = "Narration of the reciept :";
                    break;
                case 59:
                    rpt.Parameters["VoucherCaption"].Value = "CONTRA VOUCHER - Withdrawal";
                    rpt.Parameters["IsBankVoucher"].Value = true;
                    rpt.Parameters["IsContraVoucher"].Value = true;
                    rpt.Parameters["PaymentMadeFromCaption"].Value = "Bank account :";
                    rpt.Parameters["PaymentMadeToCaption"].Value = "Amount credited to :";
                    rpt.Parameters["PurposeCaption"].Value = "Narration :";
                    break;
                case 60:
                    rpt.Parameters["VoucherCaption"].Value = "CONTRA VOUCHER - Deposit";
                    rpt.Parameters["IsBankVoucher"].Value = true;
                    rpt.Parameters["IsContraVoucher"].Value = true;
                    rpt.Parameters["PaymentMadeFromCaption"].Value = "Amount recieved from :";
                    rpt.Parameters["PaymentMadeToCaption"].Value = "Bank account :";
                    rpt.Parameters["PurposeCaption"].Value = "Narration :";
                    break;
                default:
                    break;
            }
            rpt.ShowRibbonPreview();
        }

        private void gvVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnModifyVoucher_Click(null, null);
        }
    }
}