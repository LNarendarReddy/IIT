﻿using DevExpress.XtraEditors;
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
    public partial class ucEmployeePaysheet : ucLedgerTypeBase
    {
        public ucEmployeePaysheet(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucEmployeePaysheet_Load(object sender, EventArgs e)
        {
            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbNameoftheBank.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbNameoftheBank.Properties.DisplayMember = "LOOKUPVALUE";

            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSRates.Properties.ValueMember = "ENTITYLOOKUPID";
            cmbTDSRates.Properties.DisplayMember = "LOOKUPVALUE";

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            dtpJoiningDate.EditValue = ledger.EmployeePaySheetInfo.JoiningDate;
            txtEmployeeCode.EditValue = ledger.EmployeePaySheetInfo.EmployeeCode;
            txtPANNumber.EditValue = ledger.EmployeePaySheetInfo.PanNo;
            txtAadharNumber.EditValue = ledger.EmployeePaySheetInfo.AadharNo;
            rgTDSApplicable.EditValue = ledger.EmployeePaySheetInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.EmployeePaySheetInfo.TDSRate;
            rgProvisionalEntryRequired.EditValue = ledger.EmployeePaySheetInfo.provisionalEntryRequired;
            txtPFNumber.EditValue = ledger.EmployeePaySheetInfo.PFNumber;
            txtOpeningBalance.EditValue = ledger.EmployeePaySheetInfo.OpeningBalance;
            txtDoorNumber.EditValue = ledger.EmployeePaySheetInfo.DoorNumber;
            txtArea.EditValue = ledger.EmployeePaySheetInfo.Area;
            txtCity.EditValue = ledger.EmployeePaySheetInfo.City;
            txtPinCode.EditValue = ledger.EmployeePaySheetInfo.PinCode;
            txtContactNo.EditValue = ledger.EmployeePaySheetInfo.ContactNumber;
            cmbNameoftheBank.EditValue = ledger.EmployeePaySheetInfo.BankID;
            txtAccountNumber.EditValue = ledger.EmployeePaySheetInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.EmployeePaySheetInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.EmployeePaySheetInfo.IFSCCode;
            txtBranch.EditValue = ledger.EmployeePaySheetInfo.BranchName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.EmployeePaySheetInfo.JoiningDate = dtpJoiningDate.EditValue;
            ledger.EmployeePaySheetInfo.EmployeeCode = txtEmployeeCode.EditValue;
            ledger.EmployeePaySheetInfo.PanNo = txtPANNumber.EditValue;
            ledger.EmployeePaySheetInfo.AadharNo = txtAadharNumber.EditValue;
            ledger.EmployeePaySheetInfo.IsTDSApplicable = rgTDSApplicable.EditValue;
            ledger.EmployeePaySheetInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.EmployeePaySheetInfo.provisionalEntryRequired = rgProvisionalEntryRequired.EditValue;
            ledger.EmployeePaySheetInfo.PFNumber = txtPFNumber.EditValue;
            ledger.EmployeePaySheetInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.EmployeePaySheetInfo.DoorNumber = txtDoorNumber.EditValue;
            ledger.EmployeePaySheetInfo.Area = txtArea.EditValue;
            ledger.EmployeePaySheetInfo.City = txtCity.EditValue;
            ledger.EmployeePaySheetInfo.PinCode = txtPinCode.EditValue;
            ledger.EmployeePaySheetInfo.ContactNumber = txtContactNo.EditValue;
            ledger.EmployeePaySheetInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.EmployeePaySheetInfo.AccountNumber = txtAccountNumber.EditValue;
            ledger.EmployeePaySheetInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.EmployeePaySheetInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.EmployeePaySheetInfo.BranchName = txtBranch.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_EmployeePaySheet                                                     ;
            Save();
        }
        private void textExit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
        private void radioGroup_Enter(object sender, EventArgs e)
        {
            RadioGroup rg = sender as RadioGroup;
            rg.SelectedIndex = rg.EditValue == null ? 0 : rg.SelectedIndex;
        }
    }
}