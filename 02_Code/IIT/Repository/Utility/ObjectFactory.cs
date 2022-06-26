using Entity.LedgerType;

namespace Repository.Utility
{
    public static class ObjectFactory
    {
        public static LedgerTypeBase GetLedgerType(object objLedgerTypeID, object ledgerTypeData,object EntityTypeID)
        {
            if (string.IsNullOrEmpty(ledgerTypeData?.ToString()) || !int.TryParse(objLedgerTypeID.ToString(), out int ledgerTypeID))
            {
                return null;
            }

            LedgerTypeBase ledgerInfo = null;
            switch (ledgerTypeID)
            {
                case LookUpIDMap.LedgerType_BankAccount:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<BankAccount>();
                    break;
                case LookUpIDMap.LedgerType_CapitalAccount:
                    if (EntityTypeID.Equals(LookUpIDMap.EntityType_Company))
                        ledgerInfo = ledgerTypeData.ToString().DeserializeXml<CapitalAccount>();
                    else if (EntityTypeID.Equals(LookUpIDMap.EntityType_Firm))
                        ledgerInfo = ledgerTypeData.ToString().DeserializeXml<CapitalAccountFirm>();
                    else 
                        ledgerInfo = ledgerTypeData.ToString().DeserializeXml<CapitalAccountPropietor>();
                    break;
                case LookUpIDMap.LedgerType_CCOrODC:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<CCorODC>();
                    break;
                case LookUpIDMap.LedgerType_Creditors:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<Creditors>();
                    break;
                case LookUpIDMap.LedgerType_Debitors:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<Debitors>();
                    break;
                case LookUpIDMap.LedgerType_FixedAsset:
                    if (EntityTypeID.Equals(LookUpIDMap.EntityType_IndividualEntity))
                        ledgerInfo = ledgerTypeData.ToString().DeserializeXml<FixedAssetsIndividual>();
                    else
                        ledgerInfo = ledgerTypeData.ToString().DeserializeXml<FixedAssetsCompany>();
                    break;
                case LookUpIDMap.LedgerType_Investment:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<Investment>();
                    break;
                case LookUpIDMap.LedgerType_Loan:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<Loan>();
                    break;
                case LookUpIDMap.LedgerType_ServiceOrDuesToSubContractors:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<ServicesOrDuesToSubContractors>();
                    break;
                case LookUpIDMap.LedgerType_RawMaterials:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<RawMaterials>();
                    break;
                case LookUpIDMap.LedgerType_EmployeePaySheet:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<EmployeePaySheet>();
                    break;
                case LookUpIDMap.LedgerType_ReservesandSurplus:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<ReservesAndSurplus>();
                    break;
                case LookUpIDMap.LedgerType_Regular:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<Regular>();
                    break;
                case LookUpIDMap.LedgerType_IndirectIncomes:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<IndirectIncomes>();
                    break;
                case LookUpIDMap.LedgerType_DirectIncomes:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<DirectIncomes>();
                    break;
                case LookUpIDMap.LedgerType_CurrentAccountFirm:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<CurrentAccountFirm>();
                    break;
                case LookUpIDMap.LedgerType_CashInHand:
                    ledgerInfo = ledgerTypeData.ToString().DeserializeXml<CashinHand>();
                    break;
            }

            return ledgerInfo;
        }
    }
}
