
namespace Entity.LedgerType
{
    public class BankAccount : LedgerTypeBase
    {
        public object BranchAddress { get; set; }
        public object Location { get; set; }
        public object ContactNumber { get; set; }
        public object MICRCode { get; set; }
        public object NatureOfBankAccountID { get; set; }
        public object InterestRate { get; set; }

    }
}
