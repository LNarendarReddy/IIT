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
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule2 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
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
            this.layoutControl1.Size = new System.Drawing.Size(527, 654);
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
            treeListFormatRule1.ApplyToRow = true;
            treeListFormatRule1.Column = this.tlcLedgerLevel;
            treeListFormatRule1.Name = "GroupFormat";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Green;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = ((short)(1));
            treeListFormatRule1.Rule = formatConditionRuleValue1;
            treeListFormatRule2.ApplyToRow = true;
            treeListFormatRule2.Column = this.tlcLedgerLevel;
            treeListFormatRule2.Name = "subGroupFormat";
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = ((short)(2));
            treeListFormatRule2.Rule = formatConditionRuleValue2;
            this.tlLedger.FormatRules.Add(treeListFormatRule1);
            this.tlLedger.FormatRules.Add(treeListFormatRule2);
            this.tlLedger.Location = new System.Drawing.Point(4, 4);
            this.tlLedger.Name = "tlLedger";
            this.tlLedger.OptionsBehavior.Editable = false;
            this.tlLedger.OptionsCustomization.AllowSort = false;
            this.tlLedger.RowHeight = 25;
            this.tlLedger.Size = new System.Drawing.Size(519, 646);
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
            this.Root.Size = new System.Drawing.Size(527, 654);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tlLedger;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(523, 650);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmLedgerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 654);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmLedgerList";
            this.Text = "Ledger Creation";
            this.Load += new System.EventHandler(this.frmLedgerList_Load);
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