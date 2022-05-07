using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmGroup : XtraForm
    {
        Group groupObj;

        public frmGroup(Group group)
        {
            InitializeComponent();
            groupObj = group;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            groupObj.Name = txtGroupName.EditValue;
            groupObj.ClassificationID = luClassification.EditValue;
            groupObj.Description = txtGroupName.EditValue;
            groupObj.UserName = Utility.UserName;
            groupObj.EntityID = Utility.CurrentEntity?.ID;

            try
            {
                new GroupRepository().Save(groupObj);
                groupObj.IsSave = true;
                Close();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
            luClassification.Properties.DataSource = LookUpUtility.GetClassification();
            luClassification.Properties.DisplayMember = "LOOKUPVALUE";
            luClassification.Properties.ValueMember = "ENTITYLOOKUPID";

            txtGroupName.EditValue = groupObj.Name;
            luClassification.EditValue = groupObj.ClassificationID;

            if (groupObj.ID == null)
            {
                luClassification.Enabled = false;
                Text = $"Add {Text}";
            }
            else
                Text = string.IsNullOrEmpty(groupObj.Name?.ToString()) ? Text : $"Edit {Text} - {groupObj.Name}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}