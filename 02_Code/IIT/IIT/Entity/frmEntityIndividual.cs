using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityIndividual : NavigationBase
    {
        int entityType = 0;
        public bool IsSave = false;
        EntityData entityData = null;
        bool isLoading = false;
        private List<string> helpText = new List<string>() { "(Alt + S) ==> Save ", "(Alt + L) ==> Add Logo" };
        public override List<string> HelpText => helpText;
        public frmEntityIndividual(int _entityType, int EntityID = 0)
        {
            InitializeComponent();
            entityType = _entityType;
            if (EntityID > 0)
            {
                entityData = new EntityDataRepository().GetEntityData(EntityID);
                btnAddLogo.Text = entityData.EntitylogoID.Equals(0) ? "Add Logo" : "View Logo";
            }
            else
            {
                entityData = new EntityData();
                entityData.ID = EntityID;
            }
            
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
            if (entityData.ID.Equals(0))
            {
                rgResidenceStatus.SelectedIndex = 0;
            }
            else
            {
                isLoading = true;
                entityData.EntityTypeID = entityType;
                txtEntityName.EditValue = entityData.EntityName;
                txtPanNumber.EditValue = entityData.PANNumber;
                txtMobileNumber.EditValue = entityData.MobileNumber;

                cmbGSTNumber.Properties.DataSource = entityData.GSTRegNo;
                cmbGSTNumber.Properties.ValueMember = "ID";
                cmbGSTNumber.Properties.DisplayMember = "GSTNo";
                cmbGSTNumber.EditValue = entityData.GSTRegNo.FirstOrDefault()?.ID;

                txtPersonName.EditValue = entityData.PersonData.First().PersonName;
                txtPanNumber.EditValue = entityData.PersonData.First().PANNumber;
                txtAadharNumber.EditValue = entityData.PersonData.First().AadharNumber;

                cmbMethod.EditValue = entityData.MethodOfAccounting;
                cmbCurrency.EditValue = entityData.Currency;
                txtEmail.EditValue = entityData.EmailID;
                rgResidenceStatus.EditValue = entityData.ResidentStatus;
                txtNatureOfBussiness.EditValue = entityData.NatureOfBussiness;

                txtHNoR.EditValue = entityData.PermanentAddress.HNo;
                txtAreaR.EditValue = entityData.PermanentAddress.Area;
                txtCityR.EditValue = entityData.PermanentAddress.City;
                txtDistrictR.EditValue = entityData.PermanentAddress.District;
                cmbStateR.EditValue = entityData.PermanentAddress.StateID;
                txtPincodeR.EditValue = entityData.PermanentAddress.PinCode;

                txtHNoB.EditValue = entityData.BusinessAddress.HNo;
                txtAreaB.EditValue = entityData.BusinessAddress.Area;
                txtCityB.EditValue = entityData.BusinessAddress.City;
                txtDistrictB.EditValue = entityData.BusinessAddress.District;
                cmbStateB.EditValue = entityData.BusinessAddress.StateID;
                txtPincodeB.EditValue = entityData.BusinessAddress.PinCode;

                chkSameAddress.EditValue = entityData.SameAddress;

                if(chkSameAddress.Checked)
                {
                    txtHNoB.Enabled = false;
                    txtAreaB.Enabled = false;
                    txtCityB.Enabled = false;
                    txtDistrictB.Enabled = false;
                    cmbStateB.Enabled = false;
                    txtPincodeB.Enabled = false;
                }

                isLoading = false;
            }
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            entityData.EntityTypeID = entityType;
            entityData.EntityName = txtEntityName.EditValue;
            entityData.PANNumber = txtPanNumber.EditValue;
            entityData.MobileNumber = txtMobileNumber.EditValue;
            //entityData.PrimaryGST = entityData.GSTRegNo.First(x => x.ID.Equals(cmbGSTNumber.EditValue));

            if (!entityData.PersonData.Any())
                entityData.PersonData.Add(new Person());
            entityData.PersonData.First().PersonName = txtPersonName.EditValue;
            entityData.PersonData.First().PANNumber = txtPanNumber.EditValue;
            entityData.PersonData.First().AadharNumber = txtAadharNumber.EditValue;
            entityData.PersonData.First().UserName = Utility.UserName;

            entityData.MethodOfAccounting = cmbMethod.EditValue;
            entityData.Currency = cmbCurrency.EditValue;
            entityData.EmailID = txtEmail.EditValue;
            entityData.ResidentStatus = rgResidenceStatus.EditValue;
            entityData.SameAddress = chkSameAddress.EditValue;
            entityData.NatureOfBussiness = txtNatureOfBussiness.EditValue;
            entityData.UserName = Utility.UserName;

            entityData.PermanentAddress.HNo = txtHNoR.EditValue;
            entityData.PermanentAddress.Area = txtAreaR.EditValue;
            entityData.PermanentAddress.City = txtCityR.EditValue;
            entityData.PermanentAddress.District = txtDistrictR.EditValue;
            entityData.PermanentAddress.StateID = cmbStateR.EditValue;
            entityData.PermanentAddress.PinCode = txtPincodeR.EditValue;
            entityData.PermanentAddress.UserName = Utility.UserName;

            entityData.BusinessAddress.HNo = txtHNoB.EditValue;
            entityData.BusinessAddress.Area = txtAreaB.EditValue;
            entityData.BusinessAddress.City = txtCityB.EditValue;
            entityData.BusinessAddress.District = txtDistrictB.EditValue;
            entityData.BusinessAddress.StateID = cmbStateB.EditValue;
            entityData.BusinessAddress.PinCode = txtPincodeB.EditValue;
            entityData.BusinessAddress.UserName = Utility.UserName;

            new EntityDataRepository().Save(entityData);
            IsSave = true;
            frmMain.Instance.UpdateStatusBar("Entity save successful");
            frmSingularMain.Instance.RollbackControl();
            frmSingularMain.Instance.RollbackControl();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            entityData.PermanentAddress.HNo = txtHNoR.EditValue;
            entityData.PermanentAddress.Area = txtAreaR.EditValue;
            entityData.PermanentAddress.City = txtCityR.EditValue;
            entityData.PermanentAddress.District = txtDistrictR.EditValue;
            entityData.PermanentAddress.StateID = cmbStateR.EditValue;
            entityData.PermanentAddress.PinCode = txtPincodeR.EditValue;
            entityData.BusinessAddress = chkSameAddress.Checked ? entityData.PermanentAddress : new Address();
            Utility.BindAddress(entityData.BusinessAddress, !chkSameAddress.Checked, txtHNoB, txtAreaB, txtCityB, txtDistrictB
                , cmbStateB, txtPincodeB);
        }

        private void txtHNoR_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            Utility.PropogateAddress(chkSameAddress, txtHNoR, txtHNoB);
        }

        private void txtAreaR_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            Utility.PropogateAddress(chkSameAddress, txtAreaR, txtAreaB);
        }

        private void txtCityR_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            Utility.PropogateAddress(chkSameAddress, txtCityR, txtCityB);
        }

        private void txtDistrictR_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            Utility.PropogateAddress(chkSameAddress, txtDistrictR, txtDistrictB);
        }

        private void cmbStateR_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            Utility.PropogateAddress(chkSameAddress, cmbStateR, cmbStateB);
        }

        private void txtPincodeR_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            Utility.PropogateAddress(chkSameAddress, txtPincodeR, txtPincodeB);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmSingularMain.Instance.RollbackControl();
            frmSingularMain.Instance.RollbackControl();
        }

        private void btnAddGSTNumber_Click(object sender, EventArgs e)
        {
            GSTRegistrationNumber gst = new GSTRegistrationNumber();
            gst.ID = entityData.GSTRegNo.Count * -1;
            frmAddGSTNumber obj = new frmAddGSTNumber(gst);
            Utility.ShowDialog(obj);
            if (gst.IsSave)
            {
                entityData.GSTRegNo.Add(gst);
                cmbGSTNumber.Properties.DataSource = entityData.GSTRegNo;
                cmbGSTNumber.Properties.ValueMember = "ID";
                cmbGSTNumber.Properties.DisplayMember = "GSTNo";
                cmbGSTNumber.EditValue = entityData.GSTRegNo.FirstOrDefault()?.ID;


            }
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmEntityLogo(entityData));
        }
    }
}