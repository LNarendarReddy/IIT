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
    public partial class ucCurrentAccountFirm : ucLedgerTypeBase
    {
        public ucCurrentAccountFirm(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucCurrentcAccount_Load(object sender, EventArgs e)
        {
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            rgRecieptForAdditions.EditValue = ledger.CurrentAccountFirmInfo.RecieptforAdditions;
            rgRemuneration.EditValue = ledger.CurrentAccountFirmInfo.Remuneration;
            rgShareofProfit.EditValue = ledger.CurrentAccountFirmInfo.ShareofProfit;
            rgDrawings.EditValue = ledger.CurrentAccountFirmInfo.Drawings;
            rgInterestonCapital.EditValue = ledger.CurrentAccountFirmInfo.InterestonCaptital;
            rgOthersifany.EditValue = ledger.CurrentAccountFirmInfo.OthersifAny;
            txtOpeningBalance.EditValue = ledger.CurrentAccountFirmInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CurrentAccountFirmInfo.RecieptforAdditions = rgRecieptForAdditions.EditValue;
            ledger.CurrentAccountFirmInfo.Remuneration = rgRemuneration.EditValue;
            ledger.CurrentAccountFirmInfo.ShareofProfit = rgShareofProfit.EditValue;
            ledger.CurrentAccountFirmInfo.Drawings = rgDrawings.EditValue;
            ledger.CurrentAccountFirmInfo.InterestonCaptital = rgInterestonCapital.EditValue;
            ledger.CurrentAccountFirmInfo.OthersifAny = rgOthersifany.EditValue;
            ledger.CurrentAccountFirmInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CurrentAccountFirm;
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
