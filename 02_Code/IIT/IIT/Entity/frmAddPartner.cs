using DevExpress.XtraEditors;
using Entity;
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
    public partial class frmAddPartner : DevExpress.XtraEditors.XtraForm
    {
        Person person = null;
        public frmAddPartner(Person _person, bool IsCompany = false)
        {
            InitializeComponent();
            txtDINNumber.Enabled = IsCompany;
            txtNumberOfSharesHeld.Enabled = IsCompany;
            person = _person;
        }

        private void frmAddPartner_Load(object sender, EventArgs e)
        {
            if(!person.ID.Equals(0))
            {
                txtNameofthepartner.EditValue = person.PersonName;
                txtFatherName.EditValue = person.FatherName;
                txtAddress.EditValue = person.Address;
                txtDINNumber.EditValue = person.DINNo;
                txtPanNumber.EditValue = person.PANNumber;
                txtAadharNumber.EditValue = person.AadharNumber;
                txtNumberOfSharesHeld.EditValue = person.NoOfShares;
                txtShare.EditValue = person.PercentageShares;
                chkAuthor.EditValue = person.IsAuthorizedSignatory;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            person.PersonName = txtNameofthepartner.EditValue;
            person.FatherName = txtFatherName.EditValue;
            person.Address = txtAddress.EditValue;
            person.DINNo = txtDINNumber.EditValue;
            person.PANNumber = txtPanNumber.EditValue;
            person.AadharNumber = txtAadharNumber.EditValue;
            person.NoOfShares = txtNumberOfSharesHeld.EditValue;
            person.PercentageShares = txtShare.EditValue;
            person.IsAuthorizedSignatory = chkAuthor.EditValue;
            person.UserName = Utility.UserName;
            person.IsSave = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            person.IsSave = false;
            this.Close();
        }
    }
}