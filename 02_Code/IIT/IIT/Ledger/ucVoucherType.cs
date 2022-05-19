using Entity;
using System;
using System.Collections.Generic;

namespace IIT
{
    public partial class ucVoucherType : NavigationBase
    {
        private List<ActionText> helpText = new List<ActionText>() { new ActionText("Navigate", buildShort: false, shortCut: "Up/Down") };
        public override IEnumerable<ActionText> HelpText => helpText;
        public ucVoucherType()
        {
            InitializeComponent();
        }

        private void btnCashPayment_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 55 }));
        }

        private void btnCashReciept_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 57 }));
        }

        private void btnBankPayment_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 56 }));
        }

        private void btnBankReciept_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 58 }));
        }

        private void btnContraWithdrawal_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 59 }));
        }

        private void btnContraDeposit_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmVoucher(new Voucher() { VoucherTypeID = 60 }));
        }
    }
}
