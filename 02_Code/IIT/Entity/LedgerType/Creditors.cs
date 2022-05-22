
namespace Entity.LedgerType
{
    public class Creditors : LedgerTypeBase
    {
        public object NameOfSundryCreditors { get; set; }

        public object GSTRegistrationStatus { get; set; }

        public object GSTRegistrationNumber { get; set; }

        public object SupplierAddress { get; set; }

        public object PANNumber { get; set; }
        
        public object BankAccountDetails { get; set; }

        public object CreditPeriod { get; set; }

        public object InterestClause { get; set; }
    }
}
