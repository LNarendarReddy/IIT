using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSubGroup : XtraForm
    {
        SubGroup subGroupObj;

        public frmSubGroup(SubGroup subGroup)
        {
            InitializeComponent();
            subGroupObj = subGroup;
        }

        private void frmSubGroup_Load(object sender, EventArgs e)
        {
            luClassification.Properties.DataSource = LookUpUtility.GetClassification();
            luClassification.Properties.DisplayMember = "LOOKUPVALUE";
            luClassification.Properties.ValueMember = "ENTITYLOOKUPID";

            luGroup.CascadingOwner = luClassification;
            luGroup.Properties.CascadingMember = "CLASSIFICATIONID";

            luGroup.Properties.DataSource = new GroupRepository().GetGroupList(Utility.CurrentEntity.ID);
            luGroup.Properties.DisplayMember = "GROUPNAME";
            luGroup.Properties.ValueMember = "GROUPID";

            txtSubGroupName.EditValue = subGroupObj.Name;
            luClassification.EditValue = subGroupObj.ClassificationID;
            luGroup.EditValue = subGroupObj.GroupID;

            if (subGroupObj.ID == null)
            {
                luClassification.Enabled = false;
                luGroup.Enabled = false;
                Text = $"Add {Text}";
            }
            else
            Text = string.IsNullOrEmpty(subGroupObj.Name?.ToString()) ? Text : $"Edit {Text} - {subGroupObj.Name}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            subGroupObj.Name = txtSubGroupName.EditValue;
            subGroupObj.GroupID = luGroup.EditValue;
            subGroupObj.Description = txtSubGroupName.EditValue;
            subGroupObj.UserName = Utility.UserName;

            try
            {
                new SubGroupRepository().Save(subGroupObj);
                subGroupObj.IsSave = true;
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}