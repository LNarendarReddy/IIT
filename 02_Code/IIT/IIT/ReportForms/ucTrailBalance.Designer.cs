namespace IIT.ReportForms
{
    partial class ucTrailBalance
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tlTrailBalance = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcTrialBalanceLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlTrailBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tlTrailBalance);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(807, 419);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tlTrailBalance
            // 
            this.tlTrailBalance.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn9,
            this.treeListColumn1,
            this.treeListColumn2,
            this.tlcTrialBalanceLevel,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn7,
            this.treeListColumn6,
            this.treeListColumn8});
            this.tlTrailBalance.Location = new System.Drawing.Point(4, 4);
            this.tlTrailBalance.Name = "tlTrailBalance";
            this.tlTrailBalance.OptionsBehavior.Editable = false;
            this.tlTrailBalance.OptionsBehavior.PopulateServiceColumns = true;
            this.tlTrailBalance.Size = new System.Drawing.Size(799, 411);
            this.tlTrailBalance.TabIndex = 4;
            this.tlTrailBalance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tlTrailBalance_KeyDown);
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "TBID";
            this.treeListColumn9.FieldName = "TBID";
            this.treeListColumn9.Name = "treeListColumn9";
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "PARENTID";
            this.treeListColumn1.FieldName = "PARENTID";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "CURRENTID";
            this.treeListColumn2.FieldName = "CURRENTID";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // tlcTrialBalanceLevel
            // 
            this.tlcTrialBalanceLevel.Caption = "TBLEVEL";
            this.tlcTrialBalanceLevel.FieldName = "TBLEVEL";
            this.tlcTrialBalanceLevel.Name = "tlcTrialBalanceLevel";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Particular";
            this.treeListColumn4.FieldName = "TBNAME";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 0;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Opening Balance";
            this.treeListColumn5.FieldName = "OPENINGBAL";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 1;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Credit Amount";
            this.treeListColumn6.FieldName = "CREDITAMOUNT";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 3;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Debit Amount";
            this.treeListColumn7.FieldName = "DEBITAMOUNT";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 2;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Closing Balance";
            this.treeListColumn8.FieldName = "CLOSINGBAL";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(807, 419);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tlTrailBalance;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(803, 415);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucTrailBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucTrailBalance";
            this.Size = new System.Drawing.Size(807, 419);
            this.Load += new System.EventHandler(this.ucTrailBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlTrailBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraTreeList.TreeList tlTrailBalance;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcTrialBalanceLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
    }
}
