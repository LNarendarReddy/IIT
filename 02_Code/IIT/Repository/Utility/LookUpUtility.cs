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
        private static DataTable dtTDSRates = null;
        private static DataTable dtNartureofSupplier = null;
        private static DataTable dtNartureofCustomer = null;
        private static DataTable dtRMUnits = null;
        private static DataTable dtIncomeType = null;
        private static DataTable dtNatureOfReserves = null;
        private static DataTable dtInvestmentType = null;
        private static DataTable dtDueType = null;

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
        public static DataTable GetTDSRates()
        {
            return dtTDSRates =
                dtTDSRates ?? lookUpRepository.GetLookUpData("TDSRates");
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
        public static DataTable GetNatureOfSupplier()
        {
            return dtNartureofSupplier =
                dtNartureofSupplier ?? lookUpRepository.GetLookUpData("SUPPLIERNATURE");
        }
        public static DataTable GetNatureOfCustomer()
        {
            return dtNartureofCustomer =
                dtNartureofCustomer ?? lookUpRepository.GetLookUpData("CUSTOMERNATURE");
        }
        public static DataTable GetRMUnits()
        {
            return dtRMUnits =
                dtRMUnits ?? lookUpRepository.GetLookUpData("RMUnits");
        }
        public static DataTable GetIncomeType()
        {
            return dtIncomeType =
                dtIncomeType ?? lookUpRepository.GetLookUpData("IMCOMETYPE");
        }
        public static DataTable GetNatureOfReserves()
        {
            return dtNatureOfReserves =
                dtNatureOfReserves ?? lookUpRepository.GetLookUpData("NATUREOFRESERVE");
        }
        public static DataTable GetInvestmentType()
        {
            return dtInvestmentType =
                dtInvestmentType ?? lookUpRepository.GetLookUpData("InvestmentType");
        }
        public static DataTable GetDueType()
        {
            return dtDueType =
                dtDueType ?? lookUpRepository.GetLookUpData("DueType");
        }
    }
}
