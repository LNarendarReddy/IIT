using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using Entity.Masters;
using IIT.Masters;
using Repository.Ledger;
using Repository.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT.Ledger
{
    public partial class frmLedgerList : DevExpress.XtraEditors.XtraForm
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
            dt = new LedgerRepository().GetLedgerData(HeadID);
            tlLedger.DataSource = dt;
            tlLedger.KeyFieldName = "ID";
            tlLedger.ParentFieldName = "ParentID";
            AddNewNodes();
            tlLedger.ExpandToLevel(0);
        }

        private void AddNewNodes()
        {

            foreach (TreeListNode node in tlLedger.Nodes)
            {
                if (node.HasChildren)
                    AddRecursiveNodes(node);
            }

            tlLedger.AppendNode(new object[] { -1, 0, -1, "Add Group", 1 }, null);
        }

        private void AddRecursiveNodes(TreeListNode pnode)
        {
            if (Convert.ToInt16(pnode["LedgerLevel"]) == 3)
                return;
            if (Convert.ToInt32(pnode["ID"]) > 0)
                tlLedger.AppendNode(new object[] { -1, pnode["ID"], -1, 
                    Convert.ToInt16(pnode["LedgerLevel"]) == 1 ? "Add Sub Group" : "Add Ledger", 
                    Convert.ToInt16(pnode["LedgerLevel"]) + 1 }, pnode);
            if (pnode.HasChildren && Convert.ToInt16(pnode["LedgerLevel"]) < 2)
            {
                foreach (TreeListNode node in pnode.Nodes)
                    AddRecursiveNodes(node);
            }
        }

        private void tlLedger_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && tlLedger.FocusedNode != null)
            {
                int ledgerlevel = Convert.ToInt32(tlLedger.FocusedNode["LedgerLevel"]);
                switch (ledgerlevel)
                {
                    case 1:
                        {
                            Group groupdObj = null;
                            bool IsEdit = false;
                            if (Convert.ToInt32(tlLedger.FocusedNode["LedgerID"]) > 0)
                            {
                                groupdObj = new GroupRepository().GetGroupDetails(tlLedger.FocusedNode["LedgerID"]);
                                IsEdit = true;
                            }
                            else
                                groupdObj = new Group();
                            Utility.ShowDialog(new frmGroup(groupdObj));
                            if (groupdObj.IsSave)
                            {
                                if (IsEdit)
                                {

                                }
                                else
                                {
                                    var max = dt.AsEnumerable().Max(ID => ID[1]);
                                    TreeListNode newnode = tlLedger.AppendNode(new object[] { Convert.ToInt32(max) + 1,
                                    tlLedger.FocusedNode.ParentNode == null? HeadID : tlLedger.FocusedNode.ParentNode["ID"],
                                    groupdObj.ID, groupdObj.Name, ledgerlevel}, tlLedger.FocusedNode.ParentNode);
                                    tlLedger.SetNodeIndex(newnode,
                                        tlLedger.FocusedNode.ParentNode == null? tlLedger.Nodes.Count - 2 
                                        : tlLedger.FocusedNode.ParentNode.Nodes.Count - 2);
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}