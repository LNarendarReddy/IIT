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
    public partial class ucCapitalAccountFirm : ucLedgerTypeBase
    {
        public ucCapitalAccountFirm(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            this.txtCapitalShare.Spin += base.textedit_Spin;
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucCapitalAccountFirm_Load(object sender, EventArgs e)
        {

            cmbCurrentAccountInBooks.Properties.DataSource =
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
            txtCapitalShare.EditValue = ledger.CapitalAccountFirmInfo.CapitalShare;
            cmbCurrentAccountInBooks.EditValue = ledger.CapitalAccountFirmInfo.CurrentAccountInBooks;
            cmbRecieptForAdditions.EditValue = ledger.CapitalAccountFirmInfo.RecieptForAdditions;
            cmbRemuneration.EditValue = ledger.CapitalAccountFirmInfo.Remuneration;
            cmbShareofProfit.EditValue = ledger.CapitalAccountFirmInfo.ShareofProfit;
            cmbDrawings.EditValue = ledger.CapitalAccountFirmInfo.Drawings;
            cmbInterestonCapital.EditValue = ledger.CapitalAccountFirmInfo.InterestonCapital;
            cmbOthersifany.EditValue = ledger.CapitalAccountFirmInfo.Othersifany;
            txtOpeningBalance.EditValue = ledger.CapitalAccountFirmInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountFirmInfo.CapitalShare = txtCapitalShare.EditValue;
            ledger.CapitalAccountFirmInfo.CurrentAccountInBooks = cmbCurrentAccountInBooks.EditValue;
            ledger.CapitalAccountFirmInfo.RecieptForAdditions = cmbRecieptForAdditions.EditValue;
            ledger.CapitalAccountFirmInfo.Remuneration = cmbRemuneration.EditValue;
            ledger.CapitalAccountFirmInfo.ShareofProfit = cmbShareofProfit.EditValue;
            ledger.CapitalAccountFirmInfo.Drawings = cmbDrawings.EditValue;
            ledger.CapitalAccountFirmInfo.InterestonCapital = cmbInterestonCapital.EditValue;
            ledger.CapitalAccountFirmInfo.Othersifany = cmbOthersifany.EditValue;
            ledger.CapitalAccountFirmInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
            Save();
        }
    }
}
