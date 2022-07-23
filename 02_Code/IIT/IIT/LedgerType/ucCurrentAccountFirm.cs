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
    public partial class ucCurrentAccountFirm : ucLedgerTypeBase
    {
        public ucCurrentAccountFirm(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucCurrentcAccount_Load(object sender, EventArgs e)
        {
            cmbRecieptForAdditions.Properties.DataSource =
            cmbRemuneration.Properties.DataSource =
            cmbShareofProfit.Properties.DataSource =
            cmbDrawings.Properties.DataSource =
            cmbInterestonCapital.Properties.DataSource =
            cmbOthersifany.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbRecieptForAdditions.EditValue = ledger.CurrentAccountFirmInfo.RecieptforAdditions;
            cmbRemuneration.EditValue = ledger.CurrentAccountFirmInfo.Remuneration;
            cmbShareofProfit.EditValue = ledger.CurrentAccountFirmInfo.ShareofProfit;
            cmbDrawings.EditValue = ledger.CurrentAccountFirmInfo.Drawings;
            cmbInterestonCapital.EditValue = ledger.CurrentAccountFirmInfo.InterestonCaptital;
            cmbOthersifany.EditValue = ledger.CurrentAccountFirmInfo.OthersifAny;
            txtOpeningBalance.EditValue = ledger.CurrentAccountFirmInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CurrentAccountFirmInfo.RecieptforAdditions = cmbRecieptForAdditions .EditValue;
            ledger.CurrentAccountFirmInfo.Remuneration = cmbRemuneration.EditValue;
            ledger.CurrentAccountFirmInfo.ShareofProfit = cmbShareofProfit.EditValue;
            ledger.CurrentAccountFirmInfo.Drawings = cmbDrawings.EditValue;
            ledger.CurrentAccountFirmInfo.InterestonCaptital = cmbInterestonCapital.EditValue;
            ledger.CurrentAccountFirmInfo.OthersifAny = cmbOthersifany.EditValue;
            ledger.CurrentAccountFirmInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CurrentAccountFirm;
            Save();
        }
    }
}
