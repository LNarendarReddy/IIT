namespace IIT
{
    partial class frmLedgerList
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
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule5 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue5 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule6 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue6 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.tlcLedgerLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tlLedger = new DevExpress.XtraTreeList.TreeList();
            this.tlcLedgerName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcParentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcLedgerID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlcLedgerLevel
            // 
            this.tlcLedgerLevel.Caption = "LedgerLevel";
            this.tlcLedgerLevel.FieldName = "LedgerLevel";
            this.tlcLedgerLevel.Name = "tlcLedgerLevel";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tlLedger);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(653, 765);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tlLedger
            // 
            this.tlLedger.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(12)));
            this.tlLedger.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.tlLedger.Appearance.HeaderPanel.Options.UseFont = true;
            this.tlLedger.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tlLedger.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tlLedger.Appearance.Row.Options.UseFont = true;
            this.tlLedger.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcLedgerName,
            this.tlcParentID,
            this.tlcLedgerID,
            this.tlcLedgerLevel});
            treeListFormatRule5.ApplyToRow = true;
            treeListFormatRule5.Column = this.tlcLedgerLevel;
            treeListFormatRule5.Name = "GroupFormat";
            formatConditionRuleValue5.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue5.Appearance.ForeColor = System.Drawing.Color.Green;
            formatConditionRuleValue5.Appearance.Options.UseFont = true;
            formatConditionRuleValue5.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = ((short)(1));
            treeListFormatRule5.Rule = formatConditionRuleValue5;
            treeListFormatRule6.ApplyToRow = true;
            treeListFormatRule6.Column = this.tlcLedgerLevel;
            treeListFormatRule6.Name = "subGroupFormat";
            formatConditionRuleValue6.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue6.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            formatConditionRuleValue6.Appearance.Options.UseFont = true;
            formatConditionRuleValue6.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue6.Value1 = ((short)(2));
            treeListFormatRule6.Rule = formatConditionRuleValue6;
            this.tlLedger.FormatRules.Add(treeListFormatRule5);
            this.tlLedger.FormatRules.Add(treeListFormatRule6);
            this.tlLedger.Location = new System.Drawing.Point(4, 4);
            this.tlLedger.Name = "tlLedger";
            this.tlLedger.OptionsBehavior.Editable = false;
            this.tlLedger.OptionsCustomization.AllowSort = false;
            this.tlLedger.RowHeight = 25;
            this.tlLedger.Size = new System.Drawing.Size(645, 757);
            this.tlLedger.TabIndex = 4;
            this.tlLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tlLedger_KeyDown);
            // 
            // tlcLedgerName
            // 
            this.tlcLedgerName.Caption = "Ledger";
            this.tlcLedgerName.FieldName = "LedgerName";
            this.tlcLedgerName.Name = "tlcLedgerName";
            this.tlcLedgerName.Visible = true;
            this.tlcLedgerName.VisibleIndex = 0;
            // 
            // tlcParentID
            // 
            this.tlcParentID.Caption = "ParentID";
            this.tlcParentID.FieldName = "ParentID";
            this.tlcParentID.Name = "tlcParentID";
            // 
            // tlcLedgerID
            // 
            this.tlcLedgerID.Caption = "LedgerID";
            this.tlcLedgerID.FieldName = "LedgerID";
            this.tlcLedgerID.Name = "tlcLedgerID";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(653, 765);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tlLedger;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(649, 761);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmLedgerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 765);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "frmLedgerList";
            this.Text = "Ledger Creation";
            this.Load += new System.EventHandler(this.frmLedgerList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLedgerList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraTreeList.TreeList tlLedger;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLedgerName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcParentID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLedgerID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLedgerLevel;
    }
}