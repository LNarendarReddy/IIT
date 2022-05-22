using Entity.LedgerType;

namespace Repository.Utility
{
    public static class ObjectFactory
    {
        public static LedgerTypeBase GetLedgerType(object objLedgerTypeID, object ledgerTypeData)
        {
            if (string.IsNullOrEmpty(ledgerTypeData?.ToString()) || !int.TryParse(objLedgerTypeID.ToString(), out int ledgerTypeID))
                return null;

            LedgerTypeBase targetType = null;
            switch(ledgerTypeID)
            {
                case LookUpIDMap.LedgerType_BankAccount:
                    targetType = ledgerTypeData.ToString().DeserializeXml<BankAccount>();
                    break;
                case LookUpIDMap.LedgerType_CapitalAccount:
                    targetType = ledgerTypeData.ToString().DeserializeXml<CapitalAccount>();
                    break;
            }

            return targetType;
        }
    }
}
