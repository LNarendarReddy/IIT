using DevExpress.XtraEditors;
using Entity;
using Repository;
using System;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmSector : XtraForm
    {
        Sector sectorObj = new Sector();

        public frmSector(Sector sector)
        {
            InitializeComponent();
            sectorObj = sector;
        }

        private void frmSector_Load(object sender, EventArgs e)
        {
            txtSectorName.EditValue = sectorObj.Name;
            meDescription.EditValue = sectorObj.Description;

            if (sectorObj.ID == null)
                Text = $"Add {Text}";
            else
            Text = string.IsNullOrEmpty(sectorObj.Name?.ToString()) ? Text : $"Edit {Text} - {sectorObj.Name}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            try
            {
                sectorObj.Name = txtSectorName.EditValue;
                sectorObj.Description = meDescription.EditValue;
                sectorObj.UserName = Utility.UserName;
                new SectorRepository().Save(sectorObj);
                sectorObj.IsSave = true;
                Close();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}