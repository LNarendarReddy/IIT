
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
        public ucLedgerTypeBase(Ledger _ledger, bool isCallFromAddButton,string caption) : base(caption)
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
            if (!_isEdit && frmSingularMain.Instance.HasRequest("LEDGERID"))
            {
                frmSingularMain.Instance.AddRequestValue("LEDGERID", ledger.ID);
                frmSingularMain.Instance.RollbackControl(false);
                frmSingularMain.Instance.RollbackControl(false);
            }

            frmSingularMain.Instance.RollbackControl(false);
        }
    }
}
