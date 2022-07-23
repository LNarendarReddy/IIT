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
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.tlTrailBalance = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcTrialBalanceLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcOpeningBalance = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcClosingBalance = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlTrailBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblHeader);
            this.layoutControl1.Controls.Add(this.tlTrailBalance);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(807, 419);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(321, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(165, 16);
            this.lblHeader.StyleController = this.layoutControl1;
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Statement of trail balance";
            // 
            // tlTrailBalance
            // 
            this.tlTrailBalance.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn9,
            this.treeListColumn1,
            this.treeListColumn2,
            this.tlcTrialBalanceLevel,
            this.treeListColumn4,
            this.tlcOpeningBalance,
            this.treeListColumn7,
            this.treeListColumn6,
            this.tlcClosingBalance});
            this.tlTrailBalance.Location = new System.Drawing.Point(4, 24);
            this.tlTrailBalance.Name = "tlTrailBalance";
            this.tlTrailBalance.OptionsBehavior.Editable = false;
            this.tlTrailBalance.OptionsBehavior.PopulateServiceColumns = true;
            this.tlTrailBalance.OptionsView.ShowSummaryFooter = true;
            this.tlTrailBalance.Size = new System.Drawing.Size(799, 391);
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
            // tlcOpeningBalance
            // 
            this.tlcOpeningBalance.Caption = "Opening Balance";
            this.tlcOpeningBalance.FieldName = "OPENINGBAL";
            this.tlcOpeningBalance.Name = "tlcOpeningBalance";
            this.tlcOpeningBalance.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.tlcOpeningBalance.Visible = true;
            this.tlcOpeningBalance.VisibleIndex = 1;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Debit Amount";
            this.treeListColumn7.FieldName = "DEBITAMOUNT";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 2;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Credit Amount";
            this.treeListColumn6.FieldName = "CREDITAMOUNT";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 3;
            // 
            // tlcClosingBalance
            // 
            this.tlcClosingBalance.Caption = "Closing Balance";
            this.tlcClosingBalance.FieldName = "CLOSINGBAL";
            this.tlcClosingBalance.Name = "tlcClosingBalance";
            this.tlcClosingBalance.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.tlcClosingBalance.Visible = true;
            this.tlcClosingBalance.VisibleIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(807, 419);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tlTrailBalance;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 20);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(803, 395);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.Control = this.lblHeader;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(803, 20);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
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
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcOpeningBalance;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcClosingBalance;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
