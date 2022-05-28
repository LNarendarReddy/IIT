
using Entity;
using Repository;

namespace IIT
{
    public class ucLedgerTypeBase : NavigationBase
    {
        protected Ledger ledger = null;
        private bool _isEdit = false;
        private bool _isCallFromAddButton = false;

        public ucLedgerTypeBase()
        {

        }
        public ucLedgerTypeBase(Ledger _ledger, bool isCallFromAddButton) 
        {
            ledger = _ledger;
            _isEdit = ledger.IsEdit;
            _isCallFromAddButton = isCallFromAddButton;
        }

        protected void Save()
        {
            ledger.UserName = Utility.UserName;
            new LedgerRepository().Save(ledger);
            ledger.IsSave = true;
            Utility.ClearLedgerCache();
            (PreviousControl as frmLedgerCreation)?.RefreshTreeData(ledger, _isEdit, 3, _isCallFromAddButton);
            frmSingularMain.Instance.RollbackControl();
        }
    }
}
