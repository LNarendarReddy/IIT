using Entity;
using Repository;
using System;
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
            cmbCurrency.Properties.DisplayMember = "ENTITYLOOKUPID";
            cmbCurrency.Properties.ValueMember = "LOOKUPVALUE";

            cmbMethod.Properties.DataSource = LookUpUtility.GetMethodOfAccountings();
            cmbMethod.Properties.DisplayMember = "ENTITYLOOKUPID";
            cmbMethod.Properties.ValueMember = "LOOKUPVALUE";

            cmbStateR.Properties.DataSource = LookUpUtility.GetStates();
            cmbStateR.Properties.DisplayMember = "ENTITYLOOKUPID";
            cmbStateR.Properties.ValueMember = "LOOKUPVALUE";

            cmbStateB.Properties.DataSource = LookUpUtility.GetStates();
            cmbStateB.Properties.DisplayMember = "ENTITYLOOKUPID";
            cmbStateB.Properties.ValueMember = "LOOKUPVALUE";
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            entityData.EntityTypeID = 1;
            entityData.EntityName = txtEntityName.EditValue;
            entityData.PersonData.PersonName = txtPersonName.EditValue;
            entityData.PersonData.PANNumber = txtPanNumber.EditValue;
            entityData.PersonData.AadharNumber = txtAadharNumber.EditValue;
            entityData.PersonData.MobileNumber = txtMobileNumber.EditValue;

            entityData.PersonData.MethodOfAccounting = cmbMethod.EditValue;
            entityData.PersonData.Currency = cmbCurrency.EditValue;
            entityData.PersonData.EmailID = txtEmail.EditValue;
            entityData.PersonData.ResidentStatus = rgResidenceStatus.EditValue;

            entityData.PersonData.PermanentAddress.HNo = txtHNoR.EditValue;
            entityData.PersonData.PermanentAddress.District = txtDistrictR.EditValue;
            entityData.PersonData.PermanentAddress.StateID = cmbStateR.EditValue;
            entityData.PersonData.PermanentAddress.LandMark = txtLandMarkR.EditValue;
            entityData.PersonData.PermanentAddress.PinCode = txtPincodeR.EditValue;

            entityData.PersonData.BusinessAddress.HNo = txtHNoB.EditValue;
            entityData.PersonData.BusinessAddress.District = txtDistrictB.EditValue;
            entityData.PersonData.BusinessAddress.StateID = cmbStateB.EditValue;
            entityData.PersonData.BusinessAddress.LandMark = txtLandMarkB.EditValue;
            entityData.PersonData.BusinessAddress.PinCode = txtPincodeB.EditValue;


        }

        private void frmEntityIndividual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }
    }
}