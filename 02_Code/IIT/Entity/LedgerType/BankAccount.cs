
namespace Entity.LedgerType
{
    public class BankAccount : LedgerTypeBase
    {
        public object BankName { get; set; }
        
        public object AccountNumber { get; set; }

        public object BranchAddress { get; set; }

        public object IFSCCode { get; set; }

        public object MICRCode { get; set; }

        public object NatureOfBankAccountID { get; set; }

        public object ChequeBookDetails { get; set; }

        public object FirstChequeNumber { get; set; }
                
        public object NoOfChequeLeafs { get; set; }

    }
}
