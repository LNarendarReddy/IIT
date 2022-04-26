using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using Entity;
using IIT;
using Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmLedgerList : XtraForm
    {
        object HeadID = null;
        DataTable dt = null;
        public frmLedgerList(object _HeadID)
        {
            InitializeComponent();
            HeadID = _HeadID;
        }

        private void frmLedgerList_Load(object sender, EventArgs e)
        {
            BindDataSource();
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
                        Group groupdObj = IsEdit ? new GroupRepository().GetGroupDetails(entityID, Utility.CurrentEntity.ID) : 
                            new Group() { ClassificationID = HeadID };
                        Utility.ShowDialog(new frmGroup(groupdObj));
                        RefreshTreeData(groupdObj, IsEdit, ledgerlevel);
                    }
                    break;
                case 2:
                    {
                        SubGroup subGroupdObj = IsEdit ? new SubGroupRepository().GetSubGroupDetails(entityID, Utility.CurrentEntity.ID) : 
                            new SubGroup() { ClassificationID = HeadID, GroupID = tlLedger.FocusedNode.ParentNode["LedgerID"] };
                        Utility.ShowDialog(new frmSubGroup(subGroupdObj));
                        RefreshTreeData(subGroupdObj, IsEdit, ledgerlevel);
                    }
                    break;
                case 3:
                    {
                        Ledger ledgerObj = IsEdit ? new LedgerRepository().GetLedger(entityID,Utility.CurrentEntity.ID) :
                            new Ledger() { ClassificationID = HeadID, 
                                GroupID = tlLedger.FocusedNode.ParentNode.ParentNode["LedgerID"],
                                SubGroupID = tlLedger.FocusedNode.ParentNode["LedgerID"]
                            };
                        Utility.ShowDialog(new frmLedger(ledgerObj));
                        RefreshTreeData(ledgerObj, IsEdit, ledgerlevel);
                    }
                    break;
                default:
                    break;
            }
        }

        private void RefreshTreeData(MasterBase entityObj, bool IsEdit, int ledgerlevel)
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
                              tlLedger.FocusedNode.ParentNode?["ID"] ?? HeadID,
                              entityObj.ID
                              , entityObj.Name
                              , ledgerlevel
                            }
                        , tlLedger.FocusedNode.ParentNode);

                if(ledgerlevel < 3)
                {
                    string nodeText = "Add ";
                    nodeText += ledgerlevel == 1 ? "Sub Group" : string.Empty;
                    nodeText += ledgerlevel == 2 ? "Ledger" : string.Empty;

                    newnode.Nodes.Add(new object[] { ++max, max, -1, nodeText, ++ledgerlevel });
                }

                tlLedger.SetNodeIndex(newnode, (tlLedger.FocusedNode.ParentNode?.Nodes?.Count ?? tlLedger.Nodes.Count) - 2);
            }
        }

        private void BindDataSource()
        {
            dt = new LedgerRepository().GetLedgerData(HeadID, Utility.CurrentEntity.ID);
            tlLedger.DataSource = dt;
            tlLedger.KeyFieldName = "ID";
            tlLedger.ParentFieldName = "ParentID";
            tlLedger.ExpandToLevel(0);
        }

        private void CheckAndReBindTreeData(object ID)
        {
            if (ID == null || ID.Equals(tlLedger.FocusedNode.ParentNode?["LedgerID"])) return;
     
            BindDataSource();
        }

        private void frmLedgerList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}