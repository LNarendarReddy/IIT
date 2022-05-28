using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmLedger : XtraForm
    {
        readonly Ledger ledgerObj;
        readonly frmLedgerCreation ledgerCreation;
        readonly bool callFromAddButton;

        public frmLedger(Ledger ledger, frmLedgerCreation ledgerForm, bool _callFromAddButton)
        {
            InitializeComponent();
            ledgerObj = ledger;
            ledgerCreation = ledgerForm;
            callFromAddButton = _callFromAddButton;

            luClassification.Properties.DataSource = LookUpUtility.GetClassification();
            luClassification.Properties.DisplayMember = "LOOKUPVALUE";
            luClassification.Properties.ValueMember = "ENTITYLOOKUPID";

            luGroup.CascadingOwner = luClassification;
            luGroup.Properties.CascadingMember = "CLASSIFICATIONID";

            luGroup.Properties.DataSource = new GroupRepository().GetGroupList(Utility.CurrentEntity.ID);
            luGroup.Properties.DisplayMember = "GROUPNAME";
            luGroup.Properties.ValueMember = "GROUPID";

            cmbSubGroup.CascadingOwner = luGroup;
            cmbSubGroup.Properties.CascadingMember = "GROUPID";

            cmbSubGroup.Properties.DataSource = new SubGroupRepository().GetSubGroupList(Utility.CurrentEntity.ID);
            cmbSubGroup.Properties.DisplayMember = "SUBGROUPNAME";
            cmbSubGroup.Properties.ValueMember = "SUBGROUPID";

            txtLedgerName.EditValue = ledgerObj.Name;
            luClassification.EditValue = ledgerObj.ClassificationID;
            luGroup.EditValue = ledgerObj.GroupID;
            cmbSubGroup.EditValue = ledgerObj.SubGroupID;

            if (ledgerObj.ID == null)
            {
                this.Text = $"Add { this.Text}";
                luClassification.Enabled  = ledgerObj.ClassificationID == null? true : false;
                luGroup.Enabled = ledgerObj.GroupID == null ? true : false; 
                cmbSubGroup.Enabled = ledgerObj.SubGroupID == null ? true : false;  
            }
            else
                Text = string.IsNullOrEmpty(ledgerObj.Name?.ToString()) ? Text : $"Edit {Text} - {ledgerObj.Name}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            ledgerObj.Name = txtLedgerName.EditValue;
            ledgerObj.SubGroupID = cmbSubGroup.EditValue;
            ledgerObj.Description = txtLedgerName.EditValue;
            ledgerObj.UserName = Utility.UserName;

            try
            {
                bool isEdit = ledgerObj.IsEdit;
                new LedgerRepository().Save(ledgerObj);
                ledgerObj.IsSave = true;
                ledgerCreation?.RefreshTreeData(ledgerObj, isEdit, 3, callFromAddButton);
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLedger_Load(object sender, EventArgs e)
        {

        }

        private void luClassification_EditValueChanged(object sender, EventArgs e)
        {
            luGroup.EditValue = null;
        }

        private void luGroup_EditValueChanged(object sender, EventArgs e)
        {
            cmbSubGroup.EditValue = null;
        }

    }
}