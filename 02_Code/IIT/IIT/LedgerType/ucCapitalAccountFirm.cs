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
    public partial class ucCapitalAccountFirm : ucLedgerTypeBase
    {
        public ucCapitalAccountFirm(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucCapitalAccountFirm_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            txtCapitalShare.EditValue = ledger.CapitalAccountFirmInfo.CapitalShare;
            rgCurrentAccountInBooks.EditValue = ledger.CapitalAccountFirmInfo.CurrentAccountInBooks;
            rgRecieptForAdditions .EditValue = ledger.CapitalAccountFirmInfo.RecieptForAdditions;
            rgRemuneration.EditValue = ledger.CapitalAccountFirmInfo.Remuneration;
            rgShareofProfit.EditValue = ledger.CapitalAccountFirmInfo.ShareofProfit;
            rgDrawings.EditValue = ledger.CapitalAccountFirmInfo.Drawings;
            rgInterestonCapital.EditValue = ledger.CapitalAccountFirmInfo.InterestonCapital;
            rgOthersifany.EditValue = ledger.CapitalAccountFirmInfo.Othersifany;
            txtOpeningBalance.EditValue = ledger.CapitalAccountFirmInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountFirmInfo.CapitalShare = txtCapitalShare.EditValue;
            ledger.CapitalAccountFirmInfo.CurrentAccountInBooks = rgCurrentAccountInBooks.EditValue;
            ledger.CapitalAccountFirmInfo.RecieptForAdditions = rgRecieptForAdditions.EditValue;
            ledger.CapitalAccountFirmInfo.Remuneration = rgRemuneration.EditValue;
            ledger.CapitalAccountFirmInfo.ShareofProfit = rgShareofProfit.EditValue;
            ledger.CapitalAccountFirmInfo.Drawings = rgDrawings.EditValue;
            ledger.CapitalAccountFirmInfo.InterestonCapital = rgInterestonCapital.EditValue;
            ledger.CapitalAccountFirmInfo.Othersifany = rgOthersifany.EditValue;
            ledger.CapitalAccountFirmInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
            Save();
        }
        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
        private void textedit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
