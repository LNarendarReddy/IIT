using Entity.LedgerType;

namespace Entity
{
    public class Ledger : MasterBase
    {
        public object SubGroupID { get; set; }

        public object SubGroupName { get; set; }

        public object GroupID { get; set; }

        public object GroupName { get; set; }

        public object ClassificationID { get; set; }

        public object Classification { get; set; }

        public object LedgerTypeID { get; set; }

        public LedgerTypeBase LedgerTypeInfo { get; set; }

        public BankAccount BankAccountInfo
        {
            get { return LedgerTypeInfo as BankAccount; }
            set { LedgerTypeInfo = value; }
        }

        public CapitalAccount CapitalAccountInfo
        {
            get { return LedgerTypeInfo as CapitalAccount; }
            set { LedgerTypeInfo = value; }
        }

        public CCorODC CCorODCInfo
        {
            get { return LedgerTypeInfo as CCorODC; }
            set { LedgerTypeInfo = value; }
        }

        public Creditors CreditorsInfo
        {
            get { return LedgerTypeInfo as Creditors; }
            set { LedgerTypeInfo = value; }
        }

        public Debitors DebitorsInfo
        {
            get { return LedgerTypeInfo as Debitors; }
            set { LedgerTypeInfo = value; }
        }

        public FixedAssetsCompany FixedAssetsCompanyInfo
        {
            get { return LedgerTypeInfo as FixedAssetsCompany; }
            set { LedgerTypeInfo = value; }
        }

        public FixedAssetsIndividual FixedAssetsIndividualInfo
        {
            get { return LedgerTypeInfo as FixedAssetsIndividual; }
            set { LedgerTypeInfo = value; }
        }

        public Investment InvestmentInfo
        {
            get { return LedgerTypeInfo as Investment; }
            set { LedgerTypeInfo = value; }
        }
        public Loan LoanInfo
        {
            get { return LedgerTypeInfo as Loan; }
            set { LedgerTypeInfo = value; }
        }

        public ServicesOrDuesToSubContractors ServicesOrDuesToSubContractorsInfo
        {
            get { return LedgerTypeInfo as ServicesOrDuesToSubContractors; }
            set { LedgerTypeInfo = value; }
        }
    }
}
