﻿namespace Entity.LedgerType
{
    public class Loan : LedgerTypeBase
    {
        public object NameOfBankOrFinInstiution { get; set; }

        public object TypeOfLoan { get; set; }

        public object LoanAccNo { get; set; }

        public object LoanSanctionDate { get; set; }

        public object MoratoriumPeriod { get; set; }

        public object StartDate { get; set; }

        public object EndDate { get; set; }

        public object InterestRate { get; set; }

        public object Frequency { get; set; }

        public object BankAccOfLoan { get; set; }

        public object EMIDate { get; set; }

        public object EMIAmount { get; set; }

        public object PDCAgainstECS { get; set; }

        public object FinancerGST { get; set; }

        public object PANNo { get; set; }

        public object IsTDSApplicable { get; set; }

    }
}
