using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmLedger : DevExpress.XtraEditors.XtraForm
    {
        Ledger ledgerObj;
        public frmLedger(Ledger ledger)
        {
            InitializeComponent();
            ledgerObj = ledger;

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
            meDescription.EditValue = ledgerObj.Description;

            if(ledgerObj.ID == null)
            {
                luClassification.Enabled = false;
                luGroup.Enabled = false;
                cmbSubGroup.Enabled = false;
            }

            Text = string.IsNullOrEmpty(ledgerObj.Name?.ToString()) ? Text : $"{Text} - {ledgerObj.Name}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            ledgerObj.Name = txtLedgerName.EditValue;
            ledgerObj.SubGroupID = cmbSubGroup.EditValue;
            ledgerObj.Description = meDescription.EditValue;
            ledgerObj.UserName = Utility.UserName;

            try
            {
                new LedgerRepository().Save(ledgerObj);
                ledgerObj.IsSave = true;
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
    }
}