using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Repository;
using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : XtraForm
    {
        public object EntityID;
        public object EntityName;
        EntityDataRepository entityDataRepository = new EntityDataRepository();

        public frmEntityList()
        {
            InitializeComponent();
        }

        private void frmEntityList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
            else if (e.KeyData == Keys.C)
                btnCreateEntity_Click(null, null);
            else if (e.KeyData == Keys.M && btnModifyEntity.Enabled)
                btnModifyEntity_Click(null, null);
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
    }
}