
namespace Entity.LedgerType
{
    public class BankAccount : LedgerTypeBase
    {
        public object BankID { get; set; }
        
        public object AccountNumber { get; set; }

        public object BranchAddress { get; set; }

        public object IFSCCode { get; set; }

        public object MICRCode { get; set; }

        public object NatureOfBankAccountID { get; set; }

        public object InterestRate { get; set; }

    }
}
