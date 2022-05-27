using Entity;
using Repository.Utility;
using System.Collections.Generic;

namespace IIT.Routes
{
    public class VoucherEntryRoute : ucNavigationRouter
    {
        public VoucherEntryRoute() : base(new List<string>()
                    {
                        "Bank Reciept Voucher"
                        , "Bank Payments Voucher"
                        , "Cash Reciepts Voucher"
                        , "Cash Payments Voucher"
                        , "Contra Withdrawal Voucher"
                        , "Contra Deposit Voucher"
                        , "Journal Entry"
                        , "Inventory Entry"
                        , "Misc. Vouchers"
                    }, "Vouchers Entry")
        {
        }

        public override void ActionExecute(string actionText)
        {
            Voucher voucherObj = new Voucher();
            switch (actionText)
            {
                case "Bank Reciept Voucher":
                    voucherObj.VoucherTypeID = LookUpIDMap.VoucherType_BankReciept;
                    break;
                case "Bank Payments Voucher":
                    voucherObj.VoucherTypeID = LookUpIDMap.VoucherType_BankPayment;
                    break;
                case "Cash Reciepts Voucher":
                    voucherObj.VoucherTypeID = LookUpIDMap.VoucherType_CashReciept;
                    break;
                case "Cash Payments Voucher":
                    voucherObj.VoucherTypeID = LookUpIDMap.VoucherType_CashPayment;
                    break;
                case "Contra Withdrawal Voucher":
                    voucherObj.VoucherTypeID = LookUpIDMap.VoucherType_ContraVoucher_Withdrawal;
                    break;
                case "Contra Deposit Voucher":
                    voucherObj.VoucherTypeID = LookUpIDMap.VoucherType_ContraVoucher_Deposit;
                    break;
                case "Journal Entry":
                    voucherObj.VoucherTypeID = LookUpIDMap.VoucherType_JournalVoucher;
                    break;
                case "Inventory Entry":
                    break;
                case "Misc. Vouchers":
                    break;
            }
            if (voucherObj.VoucherTypeID != null)
                Utility.ShowDialog(new frmVoucher(voucherObj));
        }
    }
}
