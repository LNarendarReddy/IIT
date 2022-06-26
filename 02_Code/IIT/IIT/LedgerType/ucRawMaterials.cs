using DevExpress.XtraEditors;
using Entity;
using Repository;
using Repository.Utility;
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
    public partial class ucRawMaterials : ucLedgerTypeBase
    {
        public ucRawMaterials(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton,caption)
        {
            InitializeComponent();
        }
        private void ucRawMaterials_Load(object sender, EventArgs e)
        {
            cmbUnits.Properties.DataSource = LookUpUtility.GetRMUnits();
            cmbUnits.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbUnits.Properties.DisplayMember = "LOOKUPVALUE";

            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbUnits.EditValue = ledger.RawMaterialsInfo.UnitID;
            txtHSNCode.EditValue = ledger.RawMaterialsInfo.HSNCode;
            rgGSTApplicable.EditValue = ledger.RawMaterialsInfo.IsGSTApplicable;
            txtCGST.EditValue = ledger.RawMaterialsInfo.CGST;
            txtSGST.EditValue = ledger.RawMaterialsInfo.SGST;
            txtIGST.EditValue = ledger.RawMaterialsInfo.IGST;
            rgTDSApplicable.EditValue = ledger.RawMaterialsInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.RawMaterialsInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.RawMaterialsInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.RawMaterialsInfo.UnitID = cmbUnits.EditValue;
            ledger.RawMaterialsInfo.HSNCode = txtHSNCode.EditValue;
            ledger.RawMaterialsInfo.IsGSTApplicable = rgGSTApplicable.EditValue;
            ledger.RawMaterialsInfo.CGST = txtCGST.EditValue;
            ledger.RawMaterialsInfo.SGST = txtSGST.EditValue;
            ledger.RawMaterialsInfo.IGST = txtIGST.EditValue;
            ledger.RawMaterialsInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.RawMaterialsInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.RawMaterialsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_RawMaterials;
            Save();
        }
        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
        private void textEdit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
