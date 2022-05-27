
using Entity;
using Repository;

namespace IIT.LedgerType
{
    public class ucLedgerTypeBase : NavigationBase
    {
        protected Ledger ledger = null;
        private bool _isEdit = false;

        public ucLedgerTypeBase(Ledger _ledger)
        {
            ledger = _ledger;
            _isEdit = ledger?.ID != null && int.TryParse(ledger.ID.ToString(), out int id) && id > 0;
        }

        protected void Save()
        {
            ledger.UserName = Utility.UserName;
            new LedgerRepository().Save(ledger);
            ledger.IsSave = true;
            Utility.ClearLedgerCache();
            (PreviousControl as frmLedgerCreation)?.RefreshTreeData(ledger, _isEdit, 3);
            frmSingularMain.Instance.RollbackControl();
        }
    }
}
