namespace Repository.Utility
{
    public static class LookUpIDMap
    {

        #region Entity Type

        public const int EntityType_IndividualEntity = 11;

        public const int EntityType_Firm = 12;

        public const int EntityType_Company = 13;

        public const int EntityType_AOPBOI = 14;

        #endregion Entity Type

        #region Classification

        public const int Classification_Assets = 15;

        public const int Classification_Liabilities = 16;

        public const int Classification_Incomes = 17;

        public const int Classification_Expenses = 18;

        #endregion Classification

        #region Voucher Type

        public const int VoucherType_CashPayment = 55;

        public const int VoucherType_BankPayment = 56;

        public const int VoucherType_CashReciept = 57;

        public const int VoucherType_BankReciept = 58;

        public const int VoucherType_ContraVoucher_Withdrawal = 59;

        public const int VoucherType_ContraVoucher_Deposit = 60;

        public const int VoucherType_JournalVoucher = 166;

        #endregion Voucher Type

        #region Ledger Type

        public const int LedgerType_BankAccount = 61;

        public const int LedgerType_CapitalAccount = 62;

        public const int LedgerType_CCOrODC = 63;

        public const int LedgerType_Creditors = 64;

        public const int LedgerType_Debitors = 65;

        public const int LedgerType_FixedAsset = 66;

        public const int LedgerType_Investment = 68;

        public const int LedgerType_Loan = 69;

        public const int LedgerType_ServiceOrDuesToSubContractors = 70;

        public const int LedgerType_RawMaterials = 167;

        public const int LedgerType_EmployeePaySheet = 168;

        public const int LedgerType_ReservesandSurplus = 169;

        public const int LedgerType_Regular = 170;

        public const int LedgerType_IndirectIncomes = 171;

        public const int LedgerType_DirectIncomes = 172;

        public const int LedgerType_CurrentAccountFirm = 173;

        public const int LedgerType_CashInHand = 176;

        public const int LedgerType_StatutoryDues = 225;

        public const int LedgerType_Depreciation = 226;
        public const int LedgerType_Commission = 234;
        public const int LedgerType_Dividend = 235;

        #endregion Ledger Type

    }
}
