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
    public partial class ucInvestment : ucLedgerTypeBase
    {
        public ucInvestment(Ledger ledger,bool callfromEvent,string caption):base(ledger, callfromEvent, caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
            this.txtTenure.Spin += base.textedit_Spin;
        }
        private void ucInvestment_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbTypeOfInvestment.Properties.DataSource = LookUpUtility.GetInvestmentType();
            cmbTCSRate.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbTypeOfInvestment.EditValue = ledger.InvestmentInfo.TypeOfInvestment;
            txtTenure.EditValue = ledger.InvestmentInfo.Tenure;
            cmbTDSApplicable .EditValue = ledger.InvestmentInfo.IsTCSApplicable;
            cmbTCSRate.EditValue = ledger.InvestmentInfo.TCSRate;
            txtOpeningBalance.EditValue = ledger.InvestmentInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.InvestmentInfo.TypeOfInvestment = cmbTypeOfInvestment.EditValue;
            ledger.InvestmentInfo.Tenure = txtTenure.EditValue;
            ledger.InvestmentInfo.IsTCSApplicable = cmbTDSApplicable.EditValue;
            ledger.InvestmentInfo.TCSRate = cmbTCSRate.EditValue;
            ledger.InvestmentInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Investment;
            Save();
        }
    }
}
