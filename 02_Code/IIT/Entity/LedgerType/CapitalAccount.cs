
namespace Entity.LedgerType
{
    public class CapitalAccount : LedgerTypeBase
    {
        public object NameOfCapital { get; set; }

        public object AuthorizedCapitalAmount { get; set; }

        public object EquityOrPreferenceValue { get; set; }

        public object NoOfShares { get; set; }

        public object FaceValue { get; set; }

        public object PremiumValue { get; set; }
    }
}
