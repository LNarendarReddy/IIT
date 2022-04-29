using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
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

        public override NavigationBase PreviousControl { get => base.PreviousControl; set { } }
        public override List<string> HelpText => new List<string> { "Create", "Modify", "test" };
        public frmEntityList() 
        {    
            InitializeComponent();
        }
        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            frmEntityType objEntityType = new frmEntityType();
            Utility.ShowDialog(objEntityType);
            BindDatasource();
        }
        private void frmEntityList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvEntityList);
            frmSingularMain.Instance.KeyPress += frmEntityList_KeyPress;
            BindDatasource();
        }
        private void gvEntityList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            btnModifyEntity.Enabled = gvEntityList.FocusedRowHandle >= 0;
            btnExportEntity.Enabled = gvEntityList.FocusedRowHandle >= 0;
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
            if (gvEntityList.FocusedRowHandle < 0)
                return;
            Utility.CurrentEntity = new EntityDataRepository().GetEntityData(
                gvEntityList.GetFocusedRowCellValue("ENTITYID"));
            Utility.CurrentEntity.LogoData = new EntityDataRepository().GetEntityLogo(
                gvEntityList.GetFocusedRowCellValue("ENTITYID"));
            frmSingularMain.Instance.Text = Utility.CurrentEntity?.EntityName == null ? "IIT" : Convert.ToString(Utility.CurrentEntity.EntityName);
            Utility.ShowDialog(new ucAccountInfo());
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
            if (gvEntityList.FocusedRowHandle < 0)
                return;
            Utility.ShowDialog(new frmEntityLogo(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
        }
        private void gvEntityList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            gvEntityList_DoubleClick(null, null);
        }
    }
}