
namespace Entity.LedgerType
{
    public class Creditors : LedgerTypeBase
    {
        public object NatureOfSupplier { get; set; }
        public object GSTRegistrationStatus { get; set; }
        public object GSTRegistrationNumber { get; set; }
        public object PANNumber { get; set; }
        public object CreditPeriod { get; set; }
        public object InterestClause { get; set; }

    }
}
