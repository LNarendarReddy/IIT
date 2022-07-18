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
        public RawMaterials RawMaterialsInfo
        {
            get { return LedgerTypeInfo as RawMaterials; }
            set { LedgerTypeInfo = value; }
        }
        public ServicesOrDuesToSubContractors ServicesOrDuesToSubContractorsInfo
        {
            get { return LedgerTypeInfo as ServicesOrDuesToSubContractors; }
            set { LedgerTypeInfo = value; }
        }
        public EmployeePaySheet EmployeePaySheetInfo
        {
            get { return LedgerTypeInfo as EmployeePaySheet; }
            set { LedgerTypeInfo = value; }
        }
        public ReservesAndSurplus ReservesAndSurplusInfo
        {
            get { return LedgerTypeInfo as ReservesAndSurplus; }
            set { LedgerTypeInfo = value; }
        }
        public StatutoryDues StatutoryDuesInfo
        {
            get { return LedgerTypeInfo as StatutoryDues; }
            set { LedgerTypeInfo = value; }
        }
        public Depreciation DepreciationInfo
        {
            get { return LedgerTypeInfo as Depreciation; }
            set { LedgerTypeInfo = value; }
        }
        public Regular RegularInfo
        {
            get { return LedgerTypeInfo as Regular; }
            set { LedgerTypeInfo = value; }
        }
        public IndirectIncomes IndirectIncomesInfo
        {
            get { return LedgerTypeInfo as IndirectIncomes; }
            set { LedgerTypeInfo = value; }
        }
        public DirectIncomes DirectIncomesInfo
        {
            get { return LedgerTypeInfo as DirectIncomes; }
            set { LedgerTypeInfo = value; }
        }
        public CurrentAccountFirm CurrentAccountFirmInfo
        {
            get { return LedgerTypeInfo as CurrentAccountFirm; }
            set { LedgerTypeInfo = value; }
        }
        public CapitalAccountPropietor CapitalAccountPropietorInfo
        {
            get { return LedgerTypeInfo as CapitalAccountPropietor; }
            set { LedgerTypeInfo = value; }
        }
        public CapitalAccountFirm CapitalAccountFirmInfo
        {
            get { return LedgerTypeInfo as CapitalAccountFirm; }
            set { LedgerTypeInfo = value; }
        }
        public CashinHand CashinHandInfo
        {
            get { return LedgerTypeInfo as CashinHand; }
            set { LedgerTypeInfo = value; }
        }
        public Commission CommissionInfo
        {
            get { return LedgerTypeInfo as Commission; }
            set { LedgerTypeInfo = value; }
        }
        public Dividend DividendInfo
        {
            get { return LedgerTypeInfo as Dividend; }
            set { LedgerTypeInfo = value; }
        }
    }
}
