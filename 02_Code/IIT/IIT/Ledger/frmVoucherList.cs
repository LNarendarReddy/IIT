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
            rpt.Parameters["AmountInWords"].Value = Utility.ConvertNum(Convert.ToInt64(gvVoucher.GetFocusedRowCellValue("AMOUNT")));
            rpt.Parameters["LedgerName"].Value = gvVoucher.GetFocusedRowCellValue("TOLEDGER");
            rpt.Parameters["BankName"].Value = gvVoucher.GetFocusedRowCellValue("FROMLEDGER");
            rpt.Parameters["Purpose"].Value = gvVoucher.GetFocusedRowCellValue("PURPOSE");

            switch (Convert.ToInt32(gvVoucher.GetFocusedRowCellValue("VOUCHERTYPEID")))
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
        }

        private void gvVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnModifyVoucher_Click(null, null);
        }
    }
}