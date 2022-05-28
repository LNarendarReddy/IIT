using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmPartnershipFirm : NavigationBase
    {
        int entityType = 0;
        public bool IsSave = false;
        EntityData entityData = new EntityData();
        bool isLoading = false;
        bool IsCompany;
        private List<ActionText> helpText = new List<ActionText>() 
            { 
                new ActionText("Save", buildShort: false, shortCut: "Ctrl + S"),
                new ActionText("Add Logo", buildShort: false, shortCut: "Ctrl + L")
            };

        public override string Caption => @"Create\Modify Entity";
        public override IEnumerable<ActionText> HelpText => helpText;
        public frmPartnershipFirm(int _entityType, int EntityID = 0)
        {
            InitializeComponent();
            IsCompany = _entityType == 13;
            entityType = _entityType;
            txtCompanyNumber.Enabled = IsCompany;
            lcgPrimaryAddress.Text = IsCompany ? "Registered Office as per ROC" : "Office Address";
            chkSameAddress.Text = IsCompany ? "Business Address same as ROC" : chkSameAddress.Text;
            gcDIN.Visible = IsCompany;
            gcNOOfShares.Visible = IsCompany;
            lciNoOfPartners.Text = IsCompany ? "Number of Directors" : lciNoOfPartners.Text;
            lciNameOfTheFirm.Text = IsCompany ? "Name of the Company" : lciNameOfTheFirm.Text;
            btnAddPartner.Text = IsCompany ? "Add Director" : btnAddPartner.Text;
            lblFormHeading.Text = entityType == 12 ? "Partnership Firm" : entityType == 14 ? "AOP / BOI" : "Company";

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

        private void frmPartnershipFirm_Load(object sender, EventArgs e)
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

            cmbNatureOfBuisness.Properties.DataSource = LookUpUtility.GetSector();
            cmbNatureOfBuisness.Properties.DisplayMember = "SUBSECTORNAME";
            cmbNatureOfBuisness.Properties.ValueMember = "SUBSECTORID";

            if (!entityData.ID.Equals(0))
            {
                isLoading = true;
                entityData.EntityTypeID = entityType;
                txtEntityName.EditValue = entityData.EntityName;
                txtPanNumber.EditValue = entityData.PANNumber;
                cmbNumberOfPartners.EditValue = entityData.NoOfPartners;
                txtOfficeNumber.EditValue = entityData.OfficeNumber;
                txtMobileNumber.EditValue = entityData.MobileNumber;
                txtEmail.EditValue = entityData.EmailID;
                cmbNatureOfBuisness.EditValue = entityData.SubSectorID;
                cmbMethod.EditValue = entityData.MethodOfAccounting;
                cmbCurrency.EditValue = entityData.Currency;
                txtCompanyNumber.EditValue = entityData.CompanyNumber;

                gcPartners.DataSource = entityData.PersonData;

                cmbGSTNumber.Properties.DataSource = entityData.GSTRegNo;
                cmbGSTNumber.Properties.ValueMember = "ID";
                cmbGSTNumber.Properties.DisplayMember = "GSTNo";
                cmbGSTNumber.EditValue = entityData.GSTRegNo.FirstOrDefault()?.ID;

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

                if (chkSameAddress.Checked)
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
            entityData.NoOfPartners = cmbNumberOfPartners.EditValue;
            entityData.OfficeNumber = txtOfficeNumber.EditValue;
            entityData.MobileNumber = txtMobileNumber.EditValue;
            entityData.EmailID = txtEmail.EditValue;
            entityData.PrimaryGST = entityData.GSTRegNo.First(X=> X.ID.Equals(cmbGSTNumber.EditValue));
            entityData.SubSectorID = cmbNatureOfBuisness.EditValue;
            entityData.MethodOfAccounting = cmbMethod.EditValue;
            entityData.Currency = cmbCurrency.EditValue;
            entityData.CompanyNumber = txtCompanyNumber.EditValue;
            entityData.SameAddress = chkSameAddress.EditValue;

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

            if (!entityData.PersonData.Any())
                entityData.PersonData.Add(new Person());

            if (!entityData.GSTRegNo.Any())
                entityData.GSTRegNo.Add(new GSTRegistrationNumber());

            entityData.PersonData.ForEach(x => x.UserName = Utility.UserName);
            entityData.GSTRegNo.ForEach(x => x.UserName = Utility.UserName);

            new EntityDataRepository().Save(entityData);
            IsSave = true;
            frmSingularMain.Instance.RollbackControl();
            frmSingularMain.Instance.RollbackControl();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmSingularMain.Instance.RollbackControl();
            frmSingularMain.Instance.RollbackControl();
        }

        private void chkSameAddress_CheckedChanged(object sender, EventArgs e)
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
            Utility.PropogateAddress(chkSameAddress, txtHNoR, txtHNoB);
            entityData.PermanentAddress.HNo = txtHNoR.EditValue;
        }

        private void txtAreaR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtAreaR, txtAreaB);
            entityData.PermanentAddress.Area = txtAreaR.EditValue;
        }

        private void txtCityR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtCityR, txtCityB);
            entityData.PermanentAddress.City = txtCityR.EditValue;
        }

        private void txtDistrictR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtDistrictR, txtDistrictB);
            entityData.PermanentAddress.District = txtDistrictR.EditValue;
        }

        private void cmbStateR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, cmbStateR, cmbStateB);
            entityData.PermanentAddress.StateID = cmbStateR.EditValue;
        }

        private void txtPincodeR_EditValueChanged(object sender, EventArgs e)
        {
            Utility.PropogateAddress(chkSameAddress, txtPincodeR, txtPincodeB);
            entityData.PermanentAddress.PinCode = txtPincodeR.EditValue;
        }

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            if (cmbNumberOfPartners.EditValue == null 
                || Convert.ToInt32(cmbNumberOfPartners.EditValue) == gvPartners.RowCount)
                return;
            Person person = new Person();
            person.ID = 0;
            frmAddPartner obj = new frmAddPartner(person,entityType == 13 ? true : false);
            Utility.ShowDialog(obj);
            if (person.IsSave)
            {
                entityData.PersonData.Add(person);
                gcPartners.DataSource = entityData.PersonData;
                gcPartners.RefreshDataSource();
            }
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
                entityData.PrimaryGST = gst;

                cmbGSTNumber.Properties.DataSource = entityData.GSTRegNo;
                cmbGSTNumber.Properties.ValueMember = "ID";
                cmbGSTNumber.Properties.DisplayMember = "GSTNo";
                cmbGSTNumber.EditValue = entityData.PrimaryGST.ID;
            }
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            Utility.ShowDialog(new frmEntityLogo(entityData));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSaveCompany_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.L))
            {
                btnAddLogo_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}