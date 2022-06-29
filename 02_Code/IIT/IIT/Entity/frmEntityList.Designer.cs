namespace IIT
{
    partial class frmEntityList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntityList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gcButtons = new DevExpress.XtraGrid.GridControl();
            this.gvButtons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEntityList = new DevExpress.XtraGrid.GridControl();
            this.gvEntityList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnviewLogo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEntityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnviewLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Controls.Add(this.gcEntityList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(824, 367, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(950, 466);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 24.98F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 97.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75.02F)});
            this.tablePanel1.Controls.Add(this.gcButtons);
            this.tablePanel1.Location = new System.Drawing.Point(703, 4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 245F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(243, 458);
            this.tablePanel1.TabIndex = 0;
            // 
            // gcButtons
            // 
            this.tablePanel1.SetColumn(this.gcButtons, 1);
            this.gcButtons.Location = new System.Drawing.Point(3, 210);
            this.gcButtons.MainView = this.gvButtons;
            this.gcButtons.Name = "gcButtons";
            this.tablePanel1.SetRow(this.gcButtons, 1);
            this.gcButtons.Size = new System.Drawing.Size(239, 39);
            this.gcButtons.TabIndex = 0;
            this.gcButtons.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvButtons});
            this.gcButtons.Click += new System.EventHandler(this.gcButtons_Click);
            this.gcButtons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcButtons_KeyDown);
            // 
            // gvButtons
            // 
            this.gvButtons.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.gvButtons.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gvButtons.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvButtons.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvButtons.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.gvButtons.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvButtons.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvButtons.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvButtons.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.gvButtons.Appearance.Row.Options.UseFont = true;
            this.gvButtons.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gvButtons.DetailHeight = 327;
            this.gvButtons.GridControl = this.gcButtons;
            this.gvButtons.Name = "gvButtons";
            this.gvButtons.OptionsBehavior.Editable = false;
            this.gvButtons.OptionsView.ShowColumnHeaders = false;
            this.gvButtons.OptionsView.ShowGroupPanel = false;
            this.gvButtons.OptionsView.ShowIndicator = false;
            this.gvButtons.RowHeight = 25;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "S No";
            this.gridColumn7.FieldName = "SNo";
            this.gridColumn7.MinWidth = 17;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 64;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Action";
            this.gridColumn8.FieldName = "Action";
            this.gridColumn8.MinWidth = 17;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 64;
            // 
            // gcEntityList
            // 
            this.gcEntityList.Location = new System.Drawing.Point(4, 4);
            this.gcEntityList.MainView = this.gvEntityList;
            this.gcEntityList.Name = "gcEntityList";
            this.gcEntityList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnviewLogo});
            this.gcEntityList.Size = new System.Drawing.Size(695, 458);
            this.gcEntityList.TabIndex = 1;
            this.gcEntityList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEntityList});
            // 
            // gvEntityList
            // 
            this.gvEntityList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gvEntityList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEntityList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvEntityList.DetailHeight = 377;
            this.gvEntityList.GridControl = this.gcEntityList;
            this.gvEntityList.Name = "gvEntityList";
            this.gvEntityList.OptionsFind.AlwaysVisible = true;
            this.gvEntityList.OptionsFind.ShowFindButton = false;
            this.gvEntityList.OptionsView.ShowGroupPanel = false;
            this.gvEntityList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvEntityList_KeyPress);
            this.gvEntityList.DoubleClick += new System.EventHandler(this.gvEntityList_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ENTITYID";
            this.gridColumn1.FieldName = "ENTITYID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "S No";
            this.gridColumn2.FieldName = "SNO";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 56;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name of Entity";
            this.gridColumn3.FieldName = "ENTITYNAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 297;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ENTITYTYPEID";
            this.gridColumn4.FieldName = "ENTITYTYPEID";
            this.gridColumn4.MinWidth = 17;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 64;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Entity Type";
            this.gridColumn5.FieldName = "ENTITYTYPENAME";
            this.gridColumn5.MinWidth = 17;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 133;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "View Logo";
            this.gridColumn6.ColumnEdit = this.btnviewLogo;
            this.gridColumn6.MinWidth = 17;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 81;
            // 
            // btnviewLogo
            // 
            this.btnviewLogo.AutoHeight = false;
            editorButtonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions3.SvgImage")));
            this.btnviewLogo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnviewLogo.Name = "btnviewLogo";
            this.btnviewLogo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnviewLogo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnviewLogo_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(950, 466);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcEntityList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(699, 462);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.tablePanel1;
            this.layoutControlItem8.Location = new System.Drawing.Point(699, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(247, 462);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // frmEntityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmEntityList";
            this.Size = new System.Drawing.Size(950, 466);
            this.Load += new System.EventHandler(this.frmEntityList_Load);
            this.ParentChanged += new System.EventHandler(this.frmEntityList_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEntityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnviewLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcEntityList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEntityList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnviewLogo;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.GridControl gcButtons;
        private DevExpress.XtraGrid.Views.Grid.GridView gvButtons;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}