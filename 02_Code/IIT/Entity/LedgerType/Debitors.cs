﻿
namespace Entity.LedgerType
{
    public class Debitors : LedgerTypeBase
    {
        public object NameOfSundryDebitors { get; set; }

        public object GSTRegistrationStatus { get; set; }

        public object GSTRegistrationNumber { get; set; }

        public object DebitorAddress { get; set; }

        public object PANNumber { get; set; }

        public object CreditPeriod { get; set; }

        public object InterestClause { get; set; }
    }
}
