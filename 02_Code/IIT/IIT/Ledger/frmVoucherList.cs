using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Repository.Ledger;
using Entity;

namespace IIT.Ledger
{
    public partial class frmVoucherList : XtraForm
    {
        VoucherRepository voucherRepository = new VoucherRepository();

        public frmVoucherList()
        {
            InitializeComponent();
        }

        private void gvVoucher_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnModifyVoucher.Enabled = gvVoucher.FocusedRowHandle >= 0;
        }

        private void gcVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
            else if (e.KeyData == Keys.C)
                btnCreateVoucher_Click(null, null);
            else if (e.KeyData == Keys.M && btnModifyVoucher.Enabled)
                btnModifyVoucher_Click(null, null);
        }

        private void btnCreateVoucher_Click(object sender, EventArgs e)
        {
            Voucher voucherObj = new Voucher();
            Utility.ShowDialog(new frmVoucher(voucherObj));
            if (voucherObj.IsSave)
            {
                gcVoucher.DataSource = voucherRepository.GetVoucherList();
                gvVoucher.FocusedRowHandle = gvVoucher.LocateByValue("VOUCHERID", voucherObj.ID);
            }
        }

        private void btnModifyVoucher_Click(object sender, EventArgs e)
        {
            if (gvVoucher.FocusedRowHandle < 0) return;

            Voucher voucherObj = voucherRepository.Load(gvVoucher.GetFocusedDataRow());
            Utility.ShowDialog(new frmVoucher(voucherObj));
            if (voucherObj.IsSave)
            {
                gcVoucher.DataSource = voucherRepository.GetVoucherList();
                gvVoucher.FocusedRowHandle = gvVoucher.LocateByValue("VOUCHERID", voucherObj.ID);
            }
        }

        private void frmVoucherList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvVoucher);
            gcVoucher.DataSource = voucherRepository.GetVoucherList();
            gvVoucher_FocusedRowChanged(null, null);
        }
    }
}