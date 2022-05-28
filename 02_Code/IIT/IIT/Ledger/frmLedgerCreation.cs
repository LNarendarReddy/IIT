using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
using Entity;
using Entity.LedgerType;
using Repository;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmLedgerCreation : NavigationBase
    {
        object HeadID = null;
        DataTable dt = null;
        string caption;

        private List<ActionText> helpText = new List<ActionText>() { 
            new ActionText("Navigate", buildShort: false, shortCut: "Up/Down"),
            new ActionText("Expand", buildShort: false, shortCut: "Ctrl + Right"),
            new ActionText("Add ledger", buildShort: false, shortCut: "Alt + N")
        };

        public override IEnumerable<ActionText> HelpText => helpText;

        public override string Caption => caption;

        public frmLedgerCreation(object _HeadID, string HeadName)
        {
            InitializeComponent();
            HeadID = _HeadID;
            tlcLedgerName.Caption = HeadName;
            caption = $"{HeadName} Ledgers";
        }

        private void frmLedgerList_Load(object sender, EventArgs e)
        {
            BindDataSource();
            this.Parent.KeyPress += frmLedgerList_KeyPress;
        }

        private void tlLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || tlLedger.FocusedNode == null)
                return;
            int ledgerlevel = Convert.ToInt32(tlLedger.FocusedNode["LedgerLevel"]);
            bool IsEdit = int.TryParse(tlLedger.FocusedNode["LedgerID"]?.ToString(), out int entityID) && entityID > 0;

            switch (ledgerlevel)
            {
                case 1:
                    {
                        if (IsEdit)
                            return;
                        Group groupdObj = IsEdit ? new GroupRepository().GetGroupDetails(entityID, Utility.CurrentEntity.ID) :
                            new Group() { ClassificationID = HeadID };
                        Utility.ShowDialog(new frmGroup(groupdObj));
                        RefreshTreeData(groupdObj, IsEdit, ledgerlevel);
                    }
                    break;
                case 2:
                    {
                        if (tlLedger.FocusedColumn.FieldName.Equals("Add") &&
                            !tlLedger.FocusedNode["LedgerID"].Equals(-1))
                            btnAdd_ButtonClick(null, null);
                        else
                        {
                            if (IsEdit)
                                return;
                            SubGroup subGroupdObj = IsEdit ? new SubGroupRepository().GetSubGroupDetails(entityID, Utility.CurrentEntity.ID) :
                                new SubGroup() { ClassificationID = HeadID, GroupID = tlLedger.FocusedNode.ParentNode["LedgerID"] };
                            Utility.ShowDialog(new frmSubGroup(subGroupdObj));
                            RefreshTreeData(subGroupdObj, IsEdit, ledgerlevel);
                        }
                    }
                    break;
                case 3:
                    {
                        Ledger ledgerObj = IsEdit ? new LedgerRepository().GetLedger(entityID, 
                            Utility.CurrentEntity.ID,Utility.CurrentEntity.EntityTypeID) :
                            new Ledger()
                            {
                                ClassificationID = HeadID,
                                GroupID = tlLedger.FocusedNode.ParentNode.ParentNode["LedgerID"],
                                SubGroupID = tlLedger.FocusedNode.ParentNode["LedgerID"]
                            };
                        ShowLedgerForm(ledgerObj, true);
                        RefreshTreeData(ledgerObj, IsEdit, ledgerlevel);
                    }
                    break;
                default:
                    break;
            }
        }

        private void ShowLedgerForm(Ledger ledgerObj, bool CallFromEvent = false)
        {
            int LedgerType = 0;
            int.TryParse(Convert.ToString(CallFromEvent ? tlLedger.FocusedNode.ParentNode["LEDGERTYPE"] :
                tlLedger.FocusedNode["LEDGERTYPE"]), out LedgerType);
            switch (LedgerType)
            {
                case LookUpIDMap.LedgerType_BankAccount:
                    if (ledgerObj.BankAccountInfo == null)
                        ledgerObj.BankAccountInfo = new BankAccount();
                    Utility.ShowDialog(new ucBankAccount(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_CapitalAccount:
                    if (ledgerObj.CapitalAccountInfo == null)
                        ledgerObj.CapitalAccountInfo = new CapitalAccount();
                    Utility.ShowDialog(new frmLedger(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_CCOrODC:
                    if (ledgerObj.CCorODCInfo == null)
                        ledgerObj.CCorODCInfo = new CCorODC();
                    Utility.ShowDialog(new frmLedger(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_Creditors:
                    if (ledgerObj.CreditorsInfo == null)
                        ledgerObj.CreditorsInfo = new Creditors();
                    Utility.ShowDialog(new ucCreditors(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_Debitors:
                    if (ledgerObj.DebitorsInfo == null)
                        ledgerObj.DebitorsInfo = new Debitors();
                    Utility.ShowDialog(new ucDebitors(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_FixedAsset:
                    if (Utility.CurrentEntity.EntityTypeID.Equals(LookUpIDMap.EntityType_IndividualEntity))
                    {
                        if (ledgerObj.FixedAssetsIndividualInfo == null)
                            ledgerObj.FixedAssetsIndividualInfo = new FixedAssetsIndividual();
                        Utility.ShowDialog(new ucFixedAssetsIndividual(ledgerObj));
                    }
                    else
                    {
                        if (ledgerObj.FixedAssetsCompanyInfo == null)
                            ledgerObj.FixedAssetsCompanyInfo  = new FixedAssetsCompany();
                        Utility.ShowDialog(new ucFixedAssetsCompany(ledgerObj));
                    }
                    break;
                case LookUpIDMap.LedgerType_Investment:
                    if (ledgerObj.InvestmentInfo == null)
                        ledgerObj.InvestmentInfo  = new Investment();
                    Utility.ShowDialog(new frmLedger(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_Loan:
                    if (ledgerObj.LoanInfo == null)
                        ledgerObj.LoanInfo = new Loan();
                    Utility.ShowDialog(new frmLedger(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_ServiceOrDuesToSubContractors:
                    if (ledgerObj.ServicesOrDuesToSubContractorsInfo == null)
                        ledgerObj.ServicesOrDuesToSubContractorsInfo = new ServicesOrDuesToSubContractors();
                    Utility.ShowDialog(new ucServices(ledgerObj));
                    break;
                case LookUpIDMap.LedgerType_Default:
                    Utility.ShowDialog(new frmLedger(ledgerObj));
                    break;
            }
        }

        public void RefreshTreeData(MasterBase entityObj, bool IsEdit, int ledgerlevel, bool callfrombutton = false)
        {
            if (!entityObj.IsSave)
                return;

            if (IsEdit)
            {
                tlLedger.FocusedNode["LedgerName"] = entityObj.Name;
                CheckAndReBindTreeData((entityObj as Group)?.ClassificationID);
                CheckAndReBindTreeData((entityObj as SubGroup)?.GroupID);
                CheckAndReBindTreeData((entityObj as Ledger)?.SubGroupID);
            }
            else
            {
                var max = dt.Rows.Count + 1;
                TreeListNode newnode = tlLedger.AppendNode(
                        new object[]
                            { max,
                              callfrombutton ? tlLedger.FocusedNode["ID"] : tlLedger.FocusedNode.ParentNode?["ID"] ?? HeadID,
                              entityObj.ID
                              , entityObj.Name
                              , ledgerlevel
                            }
                        , callfrombutton ? tlLedger.FocusedNode : tlLedger.FocusedNode.ParentNode);

                if (ledgerlevel < 3)
                {
                    string nodeText = "Add ";
                    nodeText += ledgerlevel == 1 ? "Sub Group" : string.Empty;
                    nodeText += ledgerlevel == 2 ? "Ledger" : string.Empty;

                    newnode.Nodes.Add(new object[] { ++max, max, -1, nodeText, ++ledgerlevel });
                }

                tlLedger.SetNodeIndex(newnode, 
                    (callfrombutton ? tlLedger.FocusedNode.Nodes.Count : 
                    tlLedger.FocusedNode.ParentNode?.Nodes?.Count ?? tlLedger.Nodes.Count) - 2);
            }
        }

        private void BindDataSource()
        {
            dt = new LedgerRepository().GetLedgerData(HeadID, Utility.CurrentEntity.ID);
            tlLedger.DataSource = dt;
            tlLedger.KeyFieldName = "ID";
            tlLedger.ParentFieldName = "ParentID";
            tlLedger.CollapseAll();
        }

        private void CheckAndReBindTreeData(object ID)
        {
            if (ID == null || ID.Equals(tlLedger.FocusedNode.ParentNode?["LedgerID"])) return;
            BindDataSource();
        }

        private void frmLedgerList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                frmSingularMain.Instance.RollbackControl();
        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Ledger ledgerObj = new Ledger()
                            {
                                ClassificationID = HeadID,
                                GroupID = tlLedger.FocusedNode.ParentNode["LedgerID"],
                                SubGroupID = tlLedger.FocusedNode["LedgerID"]
                            };
            ShowLedgerForm(ledgerObj);
            //RefreshTreeData(ledgerObj, false, 3,true);
        }

        private void tlLedger_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        {
            OperationCollapseAllButThis op = new OperationCollapseAllButThis(e.Node);
            tlLedger.BeginUpdate();
            if (e.Node.ParentNode == null)
                tlLedger.NodesIterator.DoOperation(op);
            else
                tlLedger.NodesIterator.DoLocalOperation(op, e.Node.ParentNode.Nodes);
            tlLedger.EndUpdate();
        }

        private void tlLedger_CustomNodeCellEdit(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Add" && e.Node["LedgerLevel"].Equals(2) && !e.Node["LedgerID"].Equals(-1))
                    e.RepositoryItem = btnAdd;
        }

        private void tlLedger_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (tlLedger.FocusedColumn.FieldName == "Add" &&
                (!tlLedger.FocusedNode["LedgerLevel"].Equals(2) ||
                tlLedger.FocusedNode["LedgerID"].Equals(-1)))
                e.Cancel = true;
        }
    }

    public class OperationCollapseAllButThis : TreeListOperation
    {
        TreeListNode nodeCore;
        public OperationCollapseAllButThis(TreeListNode node)
        {
            nodeCore = node;
        }
        public override bool NeedsVisitChildren(TreeListNode node)
        {
            return true;
        }
        public override bool CanContinueIteration(TreeListNode node)
        {
            return true;
        }
        public override bool NeedsFullIteration
        {
            get { return false; }
        }
        public override void Execute(TreeListNode node)
        {
            if (node == nodeCore)
                return;
            node.Expanded = false;
        }
    }
}