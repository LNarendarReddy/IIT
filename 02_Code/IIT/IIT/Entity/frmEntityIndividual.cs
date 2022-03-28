using Entity;
using Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityIndividual : DevExpress.XtraEditors.XtraForm
    {
        int entityType = 0;
        EntityData entityData = new EntityData();
        public frmEntityIndividual()
        {
            InitializeComponent();
            frmEntityType frmentitytype = new frmEntityType();
            Utility.showDialog(frmentitytype);
            entityType = frmentitytype.entityType;
        }

        private void frmEntityIndividual_Load(object sender, EventArgs e)
        {
            cmbCurrency.Properties.DataSource = LookUpUtility.GetCurrencies();
            cmbCurrency.Properties.DisplayMember = "LOOKUPVALUE";
            cmbCurrency.Properties.ValueMember = "ENTITYLOOKUPID";

            cmbMethod.Properties.DataSource = LookUpUtility.GetMethodOfAccountings();
            cmbMethod.Properties.DisplayMember = "LOOKUPVALUE";
            cmbMethod.Properties.ValueMember = "ENTITYLOOKUPID";

            cmbStateR.Properties.DataSource = LookUpUtility.GetStates();
            cmbStateR.Properties.DisplayMember = "LOOKUPVALUE";
            cmbStateR.Properties.ValueMember = "ENTITYLOOKUPID";

            cmbStateB.Properties.DataSource = LookUpUtility.GetStates();
            cmbStateB.Properties.DisplayMember = "LOOKUPVALUE";
            cmbStateB.Properties.ValueMember = "ENTITYLOOKUPID";

            DataTable dtResidentStatus = LookUpUtility.GetResidentStatus();
            foreach (DataRow drResidentStatus in dtResidentStatus.Rows)
            {
                rgResidenceStatus.Properties.Items.Add(
                    new DevExpress.XtraEditors.Controls.RadioGroupItem(
                        drResidentStatus["ENTITYLOOKUPID"], drResidentStatus["LOOKUPVALUE"].ToString()));
            }
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            entityData.EntityTypeID = 1;
            entityData.EntityName = txtEntityName.EditValue;
            entityData.PANNumber = txtPanNumber.EditValue;
            entityData.AadharNumber = txtAadharNumber.EditValue;
            entityData.MobileNumber = txtMobileNumber.EditValue;

            entityData.PersonData.First().PersonName = txtPersonName.EditValue;
            entityData.PersonData.First().PANNumber = txtPanNumber.EditValue;
            entityData.PersonData.First().AadharNumber = txtAadharNumber.EditValue;

            entityData.MethodOfAccounting = cmbMethod.EditValue;
            entityData.Currency = cmbCurrency.EditValue;
            entityData.EmailID = txtEmail.EditValue;
            entityData.ResidentStatus = rgResidenceStatus.EditValue;

            entityData.PermanentAddress.HNo = txtHNoR.EditValue;
            entityData.PermanentAddress.Area = txtAreaR.EditValue;
            entityData.PermanentAddress.City = txtCityR.EditValue;
            entityData.PermanentAddress.District = txtDistrictR.EditValue;
            entityData.PermanentAddress.StateID = cmbStateR.EditValue;
            entityData.PermanentAddress.LandMark = txtLandMarkR.EditValue;
            entityData.PermanentAddress.PinCode = txtPincodeR.EditValue;

            entityData.BusinessAddress.HNo = txtHNoB.EditValue;
            entityData.BusinessAddress.Area = txtAreaB.EditValue;
            entityData.BusinessAddress.City = txtCityB.EditValue;
            entityData.BusinessAddress.District = txtDistrictB.EditValue;
            entityData.BusinessAddress.StateID = cmbStateB.EditValue;
            entityData.BusinessAddress.LandMark = txtLandMarkB.EditValue;
            entityData.BusinessAddress.PinCode = txtPincodeB.EditValue;

            new EntityDataRepository().Save(entityData);
        }

        private void frmEntityIndividual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            entityData.BusinessAddress = chkSameAddress.Checked ? entityData.PermanentAddress : new Address();
            Utility.BindAddress(entityData.BusinessAddress, !chkSameAddress.Checked, txtHNoB, txtAreaB, txtCityB, txtDistrictB
                , cmbStateB, txtLandMarkB, txtPincodeB);
        }

        private void txtHNoR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtHNoR, txtHNoB);
        }

        private void txtAreaR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtAreaR, txtAreaB);
        }

        private void txtCityR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtCityR, txtCityB);
        }

        private void txtDistrictR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtDistrictR, txtDistrictB);
        }

        private void cmbStateR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, cmbStateR, cmbStateB);
        }

        private void txtLandMarkR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtLandMarkR, txtLandMarkB);
        }

        private void txtPincodeR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtPincodeR, txtPincodeB);
        }
    }
}