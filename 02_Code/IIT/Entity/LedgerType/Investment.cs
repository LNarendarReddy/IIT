
namespace Entity.LedgerType
{
    public class Investment : LedgerTypeBase
    {
        public object Name { get; set; }

        public object TypeOfInvestment { get; set; }

        public object Tenure { get; set; }

        public object RateOfInterest { get; set; }

        public object NameOfCompany { get; set; }

        public object NoOfSharesHeld { get; set; }

        public object BuyingValueOfShare { get; set; }

        public object CommisionOrBrokerageCost { get; set; }

        public object NameOfPlan { get; set; }

        public object TermOfPlan { get; set; }

        public object InstallmentAmount { get; set; }

        public object MoratoriumPeriod { get; set; }

    }
}
