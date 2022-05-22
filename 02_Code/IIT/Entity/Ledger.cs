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

    }
}
