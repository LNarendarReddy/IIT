using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : NavigationBase
    {
        public object EntityID;
        public object EntityName;
        public bool IsEntitySelected = false;
        EntityDataRepository entityDataRepository = new EntityDataRepository();

        private List<ActionText> helpText = new List<ActionText>() 
            { 
                new ActionText("Create", buildShort: false, shortCut: "(Alt + C)"),
                new ActionText("Modify", buildShort: false, shortCut: "(Alt + M)"),
                new ActionText("Select", buildShort: false, shortCut: "(Alt + S)")
            };

        public override NavigationBase PreviousControl { get => base.PreviousControl; set { } }
        public override IEnumerable<ActionText> HelpText => helpText;

        public override string Caption => "(Home)";

        public frmEntityList() 
        {    
            InitializeComponent();
        }
        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            List<string> actions = new List<string>()
            {
                "Individual / Proprietor Firm"
                , "Partnership Firm"
                , "AOP / BOI"
                , "Company"
            };

            ucNavigationRouter router = new ucNavigationRouter(actions, "Entity Selection", ActionExecute);
            Utility.ShowDialog(router);

            //frmEntityType objEntityType = new frmEntityType();
            //Utility.ShowDialog(objEntityType);
            //BindDatasource();
        }

        private void ActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch(actionText)
            {
                case "Individual / Proprietor Firm":
                    formObj = new frmEntityIndividual(11);
                    break;
                case "Partnership Firm":
                    formObj = new frmPartnershipFirm(12);
                    break;
                case "AOP / BOI":
                    formObj = new frmPartnershipFirm(14);
                    break;
                case "Company":
                    formObj = new frmPartnershipFirm(13);
                    break;
            }
            Utility.ShowDialog(formObj);
        }

        private void frmEntityList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvEntityList);
            frmSingularMain.Instance.KeyPress += frmEntityList_KeyPress;
            BindDatasource();
        }
        private void gvEntityList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            bool enabled = gvEntityList.FocusedRowHandle >= 0;
            btnModifyEntity.Enabled = enabled;
            btnSelect.Enabled = enabled;
            btnExport.Enabled = enabled;
        }
        private void btnModifyEntity_Click(object sender, EventArgs e)
        {
            if(gvEntityList.FocusedRowHandle < 0)
                return;
            if (gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID").Equals(11))
            {
                frmEntityIndividual obj = new frmEntityIndividual(1,
                    Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                Utility.ShowDialog(obj);
            }
            else
            {
                frmPartnershipFirm obj = new frmPartnershipFirm(Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID")),
                    Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                Utility.ShowDialog(obj);
            }

            BindDatasource();
        }
        private void btnExportEntity_Click(object sender, EventArgs e)
        {
            if (gvEntityList.FocusedRowHandle < 0)
                return;

            try
            {
                XtraSaveFileDialog xtraSaveFileDialog = new XtraSaveFileDialog();
                xtraSaveFileDialog.FileName = gvEntityList.GetFocusedRowCellValue("ENTITYNAME").ToString() + ".bin";
                if (xtraSaveFileDialog.ShowDialog() != DialogResult.OK) return;

                DataSet entityDataSource = entityDataRepository.GetEntityExportData(gvEntityList.GetFocusedRowCellValue("ENTITYID"));
                entityDataSource.RemotingFormat = SerializationFormat.Binary;

                FileStream fs = new FileStream(xtraSaveFileDialog.FileName, FileMode.Create);
                BinaryFormatter fmt = new BinaryFormatter();
                fmt.Serialize(fs, entityDataSource);
                fs.Close();

                XtraMessageBox.Show("Export completed");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Export failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            DataSet dsEntityDataFromFile;
            XtraOpenFileDialog xtraOpenFileDialog = new XtraOpenFileDialog();
            try
            {
                if (xtraOpenFileDialog.ShowDialog() != DialogResult.OK) return;

                using (Stream stream = xtraOpenFileDialog.OpenFile())
                {
                    BinaryFormatter format = new BinaryFormatter();
                    dsEntityDataFromFile = (DataSet)format.Deserialize(stream);
                }

                var output = entityDataRepository.ImportEntityData(dsEntityDataFromFile);
                BindDatasource();
                XtraMessageBox.Show(output);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }    
        }
        private void BindDatasource()
        {
            gcEntityList.DataSource = entityDataRepository.GetEntityList();
            gvEntityList_FocusedRowChanged(null, null);
        }
        private void gvEntityList_DoubleClick(object sender, EventArgs e)
        {        
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                btnSelect_Click(null, null);
            }
        }
        private void frmEntityList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Parent == null)
                return;
            if (e.KeyChar == (char)Keys.C)
                btnCreateEntity_Click(null, null);
            else if (e.KeyChar == (char)Keys.M && btnModifyEntity.Enabled)
                btnModifyEntity_Click(null, null);
        }
        private void frmEntityList_ParentChanged(object sender, EventArgs e)
        {
            if (Parent == null) return;

            BindDatasource();
            Utility.CurrentEntity = null;
            frmSingularMain.Instance.Text = "IIT";
        }
        private void btnviewLogo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (gvEntityList.FocusedRowHandle < 0)
            //    return;
            //Utility.ShowDialog(new frmEntityLogo(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
        }
        private void gvEntityList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            btnSelect_Click(null, null);
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gvEntityList.FocusedRowHandle < 0)
                return;

            Utility.CurrentEntity = entityDataRepository.GetEntityData(
            gvEntityList.GetFocusedRowCellValue("ENTITYID"));
            Utility.CurrentEntity.LogoData = entityDataRepository.GetEntityLogo(gvEntityList.GetFocusedRowCellValue("ENTITYID"));            
            Utility.ShowDialog(new ucAccountInfo());
        }
    }
}