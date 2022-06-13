using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Entity;
using IIT.Routes;
using Repository;
using Repository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmEntityList : NavigationBase
    {
        public object EntityID;
        public object EntityName;
        public bool IsEntitySelected = false;
        private const int GridMinWidth = 300;
        private const int GridMinHeight = 100;
        EntityDataRepository entityDataRepository = new EntityDataRepository();

        List<string> entitylistactions = new List<string>()
            {
                "Create"
                , "Modify"
                , "Select"
                , "Export"
                , "Import"
                , "Shut"
                ,"Admin Settings"
            };

        private List<ActionText> helpText = new List<ActionText>();
        public override NavigationBase PreviousControl { get => base.PreviousControl; set { } }
        public override IEnumerable<ActionText> HelpText => helpText;
        
        public override bool ShowQuickOptions => false;

        public override string Caption => "(Home)";

        public frmEntityList() 
        {    
            InitializeComponent();
        }
        private void frmEntityList_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvEntityList);
            int i = 1;
            gcButtons.DataSource = helpText = entitylistactions.Select(x => new ActionText(x, i++)).ToList();
            gvButtons.BestFitColumns();
            UpdateGridSize();
            BindDatasource();
            frmSingularMain.Instance.lblDBStatus.Text = "Database Connected";
        }
        private void EntityListActionExecute(string actionText)
        {
            NavigationBase formObj = null;
            switch (actionText)
            {
                case "Create":                    
                    formObj = new EntityTypeRoute();
                    break;
                case "Modify":
                    if (gvEntityList.FocusedRowHandle < 0)
                        return;
                    if (gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID").Equals(LookUpIDMap.EntityType_IndividualEntity))
                        formObj = new frmEntityIndividual(LookUpIDMap.EntityType_IndividualEntity, Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                    else
                        formObj = new frmPartnershipFirm(Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYTYPEID")),
                            Convert.ToInt32(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
                    break;
                case "Select":
                    formObj = SelectEntity();
                    break;
                case "Export":
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
                    break;
                case "Import":
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
                    break;
                case "Shut":
                    break;
                case "Admin Settings":
                    Utility.ShowDialog(new frmSettings());
                    break;
            }
            Utility.ShowDialog(formObj);
        }

        private void BindDatasource()
        {
            gcEntityList.DataSource = entityDataRepository.GetEntityList();
        }
        private void gvEntityList_DoubleClick(object sender, EventArgs e)
        {        
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                Utility.ShowDialog(SelectEntity());
            }
        }
        private NavigationBase SelectEntity()
        {
            if (gvEntityList.FocusedRowHandle < 0) return null;
            Utility.ClearLedgerCache();
            Utility.CurrentEntity = entityDataRepository.GetEntityData(gvEntityList.GetFocusedRowCellValue("ENTITYID"));
            return new AccountingRoute();
        }

        private void frmEntityList_ParentChanged(object sender, EventArgs e)
        {
            if (Parent == null) return;

            BindDatasource();
            Utility.CurrentEntity = null;
            frmSingularMain.Instance.Text = Utility.Caption;
        }

        private void btnviewLogo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (gvEntityList.FocusedRowHandle < 0)
            //    return;
            //Utility.ShowDialog(new frmEntityLogo(gvEntityList.GetFocusedRowCellValue("ENTITYID")));
        }
        private void gvEntityList_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != (char)Keys.Enter)
            //    return;
            //Utility.ShowDialog(SelectEntity());
        }
        private void UpdateGridSize()
        {
            GridViewInfo viewInfo = (GridViewInfo)gvButtons.GetViewInfo();
            FieldInfo fi = typeof(GridView).GetField("scrollInfo", BindingFlags.Instance | BindingFlags.NonPublic);
            ScrollInfo scrollInfo = (ScrollInfo)fi.GetValue(gvButtons);
            int width = viewInfo.ViewRects.IndicatorWidth;
            foreach (GridColumn column in gvButtons.VisibleColumns)
            {
                if (viewInfo.GetColumnLeftCoord(column) < viewInfo.ViewRects.ColumnPanelWidth)
                    gvButtons.LeftCoord = width;
                try
                {
                    width += viewInfo.ColumnsInfo[column].Bounds.Width;
                }
                catch (Exception ex) { }
            }
            if (scrollInfo.VScrollVisible) width += scrollInfo.VScrollSize;
            int height = viewInfo.CalcRealViewHeight(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), true);
            if (scrollInfo.HScrollVisible) height += scrollInfo.HScrollSize;
            width = Math.Max(GridMinWidth, width);
            width = Math.Min(ClientSize.Width - gcButtons.Location.X, width);
            height = Math.Max(GridMinHeight, height);
            height = Math.Min(ClientSize.Height - gcButtons.Location.Y, height);
            gcButtons.Size = new Size(width, height);
            gvButtons.LayoutChanged();
        }

        private void gcButtons_Click(object sender, EventArgs e)
        {
            EntityListActionExecute(Convert.ToString(gvButtons.GetRowCellValue(gvButtons.FocusedRowHandle, "Action")));
        }

        private void gcButtons_KeyDown(object sender, KeyEventArgs e)
        {
            int inputNumber = gvButtons.FocusedRowHandle + 1;
            if (e.KeyCode != Keys.Enter)
            {
                if (!e.Control || !char.IsNumber((char)e.KeyCode)
                    || !int.TryParse(((char)e.KeyCode).ToString(), out inputNumber) || !(inputNumber > 0) || !(inputNumber <= gvButtons.RowCount))
                    return;
            }

            gvButtons.FocusedRowHandle = inputNumber - 1;
            gcButtons_Click(sender, e);
        }
    }
}