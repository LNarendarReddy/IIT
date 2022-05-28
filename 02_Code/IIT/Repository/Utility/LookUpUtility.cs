using System.Data;

namespace Repository
{
    public static class LookUpUtility
    {
        private static DataTable dtMethodOfAccounting = null;
        private static DataTable dtCurrency = null;
        private static DataTable dtStates = null;
        private static DataTable dtResidentStatus = null;
        private static DataTable dtClassification = null;
        private static DataTable dtVoucherType = null;
        private static DataTable dtBanks = null;
        private static DataTable dtNatureOfBanks = null;
        private static DataTable dtSector = null;

        private static LookUpRepository lookUpRepository = new LookUpRepository();

        public static DataTable GetMethodOfAccountings()
        {
            return dtMethodOfAccounting = 
                dtMethodOfAccounting ?? lookUpRepository.GetLookUpData("METHODOFACCOUNTING"); ;
        }

        public static DataTable GetCurrencies()
        {
            return dtCurrency =
                dtCurrency ?? lookUpRepository.GetLookUpData("CURRENCY"); ;
        }

        public static DataTable GetStates()
        {
            return dtStates =
                dtStates ?? lookUpRepository.GetLookUpData("State"); ;
        }

        public static DataTable GetResidentStatus()
        {
            return dtResidentStatus =
                dtResidentStatus ?? lookUpRepository.GetLookUpData("RESIDENT STATUS"); ;
        }

        public static DataTable GetClassification()
        {
            return dtClassification =
                dtClassification ?? lookUpRepository.GetLookUpData("CLASSIFICATION"); ;
        }

        public static DataTable GetVoucherType()
        {
            return dtVoucherType =
                dtVoucherType ?? lookUpRepository.GetLookUpData("VOUCHERTYPE"); ;
        }

        public static DataTable GetBanks()
        {
            return dtBanks =
                dtBanks ?? lookUpRepository.GetLookUpData("BANKS");
        }

        public static DataTable GetNatureOfBanks()
        {
            return dtNatureOfBanks =
                dtNatureOfBanks ?? lookUpRepository.GetLookUpData("NATUREOFBANKS");
        }

        public static DataTable GetSector()
        {
            return dtSector =
                dtSector ?? lookUpRepository.GetSector();
        }
    }
}
