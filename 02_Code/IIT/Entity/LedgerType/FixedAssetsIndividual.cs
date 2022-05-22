namespace Entity.LedgerType
{
    public class FixedAssetsIndividual : LedgerTypeBase
    {
        public object NameOfAsset { get; set; }

        public object RateOfDepreciation { get; set; }

        public object IsGSTConsidered { get; set; }

        public object IsOperatingAsset { get; set; }

    }
}
