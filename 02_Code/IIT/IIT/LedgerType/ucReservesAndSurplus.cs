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
    public partial class ucReservesAndSurplus : ucLedgerTypeBase
    {
        public ucReservesAndSurplus(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton,caption)
        {
            InitializeComponent();
            this.txtOpeningBalance.Spin += base.textedit_Spin;
        }
        private void ucReservesAndSurplus_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbNatureOfReserve.Properties.DataSource = LookUpUtility.GetNatureOfReserves();
            cmbNatureOfReserve.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNatureOfReserve.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            cmbNatureOfReserve.EditValue = ledger.ReservesAndSurplusInfo.NatureOfReserves;
            txtOpeningBalance.EditValue = ledger.ReservesAndSurplusInfo.OpeningBalance;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.ReservesAndSurplusInfo.NatureOfReserves = cmbNatureOfReserve.EditValue;
            ledger.ReservesAndSurplusInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_ReservesandSurplus;
            Save();
        }
    }
}
