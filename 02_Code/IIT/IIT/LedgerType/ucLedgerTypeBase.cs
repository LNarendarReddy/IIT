
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout;
using Entity;
using Repository;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IIT
{
    public class ucLedgerTypeBase : NavigationBase
    {
        protected Ledger ledger = null;
        private bool _isEdit = false;
        private bool _isCallFromAddButton = false;
        public List<Control> requiredFields = new List<Control>();
        DXValidationProvider ControlValidator = new DXValidationProvider();
        public ucLedgerTypeBase()
        {

        }
        public ucLedgerTypeBase(Ledger _ledger, bool isCallFromAddButton, string caption) : base($"{ caption} Ledger Creation")
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
        public bool ValidateControls()
        {
            ConditionValidationRule requiredValidationRule = new ConditionValidationRule();
            requiredValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            requiredValidationRule.ErrorText = "Mondatory";
            requiredValidationRule.ErrorType = ErrorType.Critical;
            foreach (Control ctrl in requiredFields)
                ControlValidator.SetValidationRule(ctrl, ctrl.Enabled ? requiredValidationRule : null);
            return ControlValidator.Validate();

        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "ucLedgerTypeBase";
            this.ResumeLayout(false);

        }
        public void AddControls(LayoutControl control)
        {
            foreach (Control ctrl in control.Controls)
                if (ctrl.GetType() == typeof(LookUpEdit) || ctrl.GetType() == typeof(TextEdit))
                {
                    (ctrl.GetType().Equals(typeof(LookUpEdit)) ? (LookUpEdit)ctrl : (TextEdit)ctrl).EnterMoveNextControl = true;
                    requiredFields.Add(ctrl);
                    if(ctrl.GetType() == typeof(LookUpEdit))
                    {
                        ((LookUpEdit)ctrl).Properties.ValueMember = "ENTITYLOOKUPID";
                        ((LookUpEdit)ctrl).Properties.DisplayMember = "LOOKUPVALUE";
                    }
                }
        }
        public void textedit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

    }
}
