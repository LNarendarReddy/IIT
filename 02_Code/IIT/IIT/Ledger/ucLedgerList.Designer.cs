namespace IIT
{
    partial class ucLedgerList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcLedgerList = new DevExpress.XtraGrid.GridControl();
            this.gvLedgerList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLedgerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLedgerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.layoutControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(462, 453);
            this.tablePanel1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.tablePanel1.SetColumn(this.layoutControl1, 0);
            this.layoutControl1.Controls.Add(this.gcLedgerList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.layoutControl1, 0);
            this.layoutControl1.Size = new System.Drawing.Size(445, 447);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcLedgerList
            // 
            this.gcLedgerList.Location = new System.Drawing.Point(4, 4);
            this.gcLedgerList.MainView = this.gvLedgerList;
            this.gcLedgerList.Name = "gcLedgerList";
            this.gcLedgerList.Size = new System.Drawing.Size(437, 439);
            this.gcLedgerList.TabIndex = 4;
            this.gcLedgerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLedgerList});
            // 
            // gvLedgerList
            // 
            this.gvLedgerList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18});
            this.gvLedgerList.DetailHeight = 327;
            this.gvLedgerList.GridControl = this.gcLedgerList;
            this.gvLedgerList.Name = "gvLedgerList";
            this.gvLedgerList.OptionsBehavior.Editable = false;
            this.gvLedgerList.OptionsFind.AlwaysVisible = true;
            this.gvLedgerList.OptionsFind.ShowFindButton = false;
            this.gvLedgerList.OptionsView.ShowGroupPanel = false;
            this.gvLedgerList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvLedgerList_KeyPress);
            this.gvLedgerList.DoubleClick += new System.EventHandler(this.gvLedgerList_DoubleClick);
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "LEDGERID";
            this.gridColumn10.FieldName = "LEDGERID";
            this.gridColumn10.MinWidth = 17;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Width = 64;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ledger";
            this.gridColumn11.FieldName = "LEDGERNAME";
            this.gridColumn11.MinWidth = 17;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 64;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Description";
            this.gridColumn12.FieldName = "LEDGERDESCRIPTION";
            this.gridColumn12.MinWidth = 17;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Width = 64;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "SUBGROUPID";
            this.gridColumn13.FieldName = "SUBGROUPID";
            this.gridColumn13.MinWidth = 17;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Width = 64;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Sub Group";
            this.gridColumn14.FieldName = "SUBGROUPNAME";
            this.gridColumn14.MinWidth = 17;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Width = 64;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "GROUPID";
            this.gridColumn15.FieldName = "GROUPID";
            this.gridColumn15.MinWidth = 17;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Width = 64;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Group";
            this.gridColumn16.FieldName = "GROUPNAME";
            this.gridColumn16.MinWidth = 17;
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Width = 64;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "CLASSIFICATIONID";
            this.gridColumn17.FieldName = "CLASSIFICATIONID";
            this.gridColumn17.MinWidth = 17;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Width = 64;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Head";
            this.gridColumn18.FieldName = "CLASSIFICATION";
            this.gridColumn18.MinWidth = 17;
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Width = 64;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(445, 447);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcLedgerList;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(441, 443);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "LEDGERID";
            this.gridColumn1.FieldName = "LEDGERID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ledger";
            this.gridColumn2.FieldName = "LEDGERNAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 394;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "LEDGERDESCRIPTION";
            this.gridColumn3.FieldName = "LEDGERDESCRIPTION";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "SUBGROUPID";
            this.gridColumn4.FieldName = "SUBGROUPID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sub Group";
            this.gridColumn5.FieldName = "SUBGROUPNAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 135;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "GROUPID";
            this.gridColumn6.FieldName = "GROUPID";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Group";
            this.gridColumn7.FieldName = "GROUPNAME";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 121;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "CLASSIFICATIONID";
            this.gridColumn8.FieldName = "CLASSIFICATIONID";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Head";
            this.gridColumn9.FieldName = "CLASSIFICATION";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(734, 738);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucLedgerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ucLedgerList";
            this.Size = new System.Drawing.Size(462, 453);
            this.Load += new System.EventHandler(this.ucLedgerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLedgerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLedgerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcLedgerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLedgerList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
    }
}
