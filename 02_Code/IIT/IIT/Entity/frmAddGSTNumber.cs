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
    public partial class frmAddGSTNumber : DevExpress.XtraEditors.XtraForm
    {
        GSTRegistrationNumber gst = null;
        public frmAddGSTNumber(GSTRegistrationNumber _gst)
        {
            InitializeComponent();
            gst = _gst;
        }

        private void frmAddGSTNumber_Load(object sender, EventArgs e)
        {
            cmbState.Properties.DataSource = LookUpUtility.GetStates();
            cmbState.Properties.DisplayMember = "LOOKUPVALUE";
            cmbState.Properties.ValueMember = "ENTITYLOOKUPID";

            if(!gst.ID.Equals(0))
            {
                txtGSTNumber.EditValue = gst.GSTNo;
                cmbState.EditValue = gst.StateID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!dxValidationProvider1.Validate())
                return;
            gst.GSTNo = txtGSTNumber.EditValue;
            gst.StateID = cmbState.EditValue;
            gst.StateName = cmbState.Text;
            gst.UserName = Utility.UserName;
            gst.IsSave = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gst.IsSave = false;
            this.Close();
        }

    }
}