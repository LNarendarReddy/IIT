using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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
    public partial class ucCapitalAccountPropietor : ucLedgerTypeBase
    {
        public ucCapitalAccountPropietor(Ledger _ledger, bool isCallFromAddButton,string caption) 
            : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucCpaitalAccountPropietor_Load(object sender, EventArgs e)
        {
            cmbRecieptForAdditions.Properties.DataSource =
                cmbDrawings.Properties.DataSource =
                cmbInterestonCapital.Properties.DataSource =
                cmbOthersifany.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbRecieptForAdditions.EditValue = ledger.CapitalAccountPropietorInfo.RecieptforAdditions;
            cmbDrawings.EditValue = ledger.CapitalAccountPropietorInfo.Drawings;
            cmbInterestonCapital.EditValue = ledger.CapitalAccountPropietorInfo.InterestonCaptital;
            cmbOthersifany.EditValue = ledger.CapitalAccountPropietorInfo.OthersifAny;
            txtOpeningBalance.EditValue = ledger.CapitalAccountPropietorInfo.OpeningBalance;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountPropietorInfo.RecieptforAdditions = cmbRecieptForAdditions.EditValue;
            ledger.CapitalAccountPropietorInfo.Drawings = cmbDrawings.EditValue;
            ledger.CapitalAccountPropietorInfo.InterestonCaptital = cmbInterestonCapital.EditValue;
            ledger.CapitalAccountPropietorInfo.OthersifAny = cmbOthersifany.EditValue;
            ledger.CapitalAccountPropietorInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
            Save();
        }
    }
}
