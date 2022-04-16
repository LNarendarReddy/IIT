﻿using System.Data;

namespace Repository
{
    public static class LookUpUtility
    {
        private static DataTable dtMethodOfAccounting = null;
        private static DataTable dtCurrency = null;
        private static DataTable dtStates = null;
        private static DataTable dtResidentStatus = null;
        private static DataTable dtClassification = null;
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
    }
}
