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
            this.txtIGST.Spin += base.textedit_Spin;
            this.txtSGST.Spin += base.textedit_Spin;
            this.txtCGST.Spin += base.textedit_Spin;
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucRawMaterials_Load(object sender, EventArgs e)
        {
            cmbUnits.Properties.DataSource = LookUpUtility.GetRMUnits();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbGSTApplicable.Properties.DataSource = 
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbUnits.EditValue = ledger.RawMaterialsInfo.UnitID;
            txtHSNCode.EditValue = ledger.RawMaterialsInfo.HSNCode;
            cmbGSTApplicable.EditValue = ledger.RawMaterialsInfo.IsGSTApplicable;
            txtCGST.EditValue = ledger.RawMaterialsInfo.CGST;
            txtSGST.EditValue = ledger.RawMaterialsInfo.SGST;
            txtIGST.EditValue = ledger.RawMaterialsInfo.IGST;
            cmbTDSApplicable.EditValue = ledger.RawMaterialsInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.RawMaterialsInfo.TDSRate;
            txtOpeningBalance.EditValue = ledger.RawMaterialsInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.RawMaterialsInfo.UnitID = cmbUnits.EditValue;
            ledger.RawMaterialsInfo.HSNCode = txtHSNCode.EditValue;
            ledger.RawMaterialsInfo.IsGSTApplicable = cmbGSTApplicable.EditValue;
            ledger.RawMaterialsInfo.CGST = txtCGST.EditValue;
            ledger.RawMaterialsInfo.SGST = txtSGST.EditValue;
            ledger.RawMaterialsInfo.IGST = txtIGST.EditValue;
            ledger.RawMaterialsInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.RawMaterialsInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.RawMaterialsInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_RawMaterials;
            Save();
        }
    }
}
