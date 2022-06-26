using DevExpress.XtraEditors;
using Entity;
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
        public ucCapitalAccountPropietor(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucCpaitalAccountPropietor_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            rgRecieptForAdditions.EditValue = ledger.CapitalAccountPropietorInfo.RecieptforAdditions;
            rgDrawings.EditValue = ledger.CapitalAccountPropietorInfo.Drawings;
            rgInterestonCapital.EditValue = ledger.CapitalAccountPropietorInfo.InterestonCaptital;
            rgOthersifany.EditValue = ledger.CapitalAccountPropietorInfo.OthersifAny;
            txtOpeningBalance.EditValue = ledger.CapitalAccountPropietorInfo.OpeningBalance;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountPropietorInfo.RecieptforAdditions = rgRecieptForAdditions.EditValue;
            ledger.CapitalAccountPropietorInfo.Drawings = rgDrawings.EditValue;
            ledger.CapitalAccountPropietorInfo.InterestonCaptital = rgInterestonCapital.EditValue;
            ledger.CapitalAccountPropietorInfo.OthersifAny = rgOthersifany.EditValue;
            ledger.CapitalAccountPropietorInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
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
