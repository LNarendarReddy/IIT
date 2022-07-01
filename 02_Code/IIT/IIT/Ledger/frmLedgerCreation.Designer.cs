namespace IIT
{
    partial class frmLedgerCreation
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedgerCreation));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tlcLedgerLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlLedger = new DevExpress.XtraTreeList.TreeList();
            this.tlcLedgerName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcParentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcLedgerID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnAdd = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.tlLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlcLedgerLevel
            // 
            this.tlcLedgerLevel.Caption = "LedgerLevel";
            this.tlcLedgerLevel.FieldName = "LedgerLevel";
            this.tlcLedgerLevel.MinWidth = 17;
            this.tlcLedgerLevel.Name = "tlcLedgerLevel";
            this.tlcLedgerLevel.Width = 64;
            // 
            // tlLedger
            // 
            this.tlLedger.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(109)))), ((int)(((byte)(190)))));
            this.tlLedger.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.tlLedger.Appearance.FocusedCell.Options.UseBackColor = true;
            this.tlLedger.Appearance.FocusedCell.Options.UseForeColor = true;
            this.tlLedger.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(12)));
            this.tlLedger.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.tlLedger.Appearance.HeaderPanel.Options.UseFont = true;
            this.tlLedger.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.tlLedger, 0);
            this.tlLedger.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcLedgerName,
            this.tlcParentID,
            this.tlcLedgerID,
            this.tlcLedgerLevel,
            this.treeListColumn1,
            this.treeListColumn2});
            this.tlLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            treeListFormatRule1.ApplyToRow = true;
            treeListFormatRule1.Column = this.tlcLedgerLevel;
            treeListFormatRule1.Name = "GroupFormat";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Green;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = ((short)(1));
            treeListFormatRule1.Rule = formatConditionRuleValue1;
            treeListFormatRule2.ApplyToRow = true;
            treeListFormatRule2.Column = this.tlcLedgerLevel;
            treeListFormatRule2.Name = "subGroupFormat";
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = ((short)(2));
            treeListFormatRule2.Rule = formatConditionRuleValue2;
            this.tlLedger.FormatRules.Add(treeListFormatRule1);
            this.tlLedger.FormatRules.Add(treeListFormatRule2);
            this.tlLedger.Location = new System.Drawing.Point(3, 3);
            this.tlLedger.MinWidth = 17;
            this.tlLedger.Name = "tlLedger";
            this.tlLedger.OptionsCustomization.AllowSort = false;
            this.tlLedger.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAdd});
            this.tablePanel1.SetRow(this.tlLedger, 0);
            this.tlLedger.RowHeight = 23;
            this.tlLedger.Size = new System.Drawing.Size(776, 437);
            this.tlLedger.TabIndex = 4;
            this.tlLedger.TreeLevelWidth = 15;
            this.tlLedger.CustomNodeCellEdit += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(this.tlLedger_CustomNodeCellEdit);
            this.tlLedger.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.tlLedger_BeforeExpand);
            this.tlLedger.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.tlLedger_ShowingEditor);
            this.tlLedger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tlLedger_KeyDown);
            // 
            // tlcLedgerName
            // 
            this.tlcLedgerName.Caption = "Ledger";
            this.tlcLedgerName.FieldName = "LedgerName";
            this.tlcLedgerName.MinWidth = 17;
            this.tlcLedgerName.Name = "tlcLedgerName";
            this.tlcLedgerName.OptionsColumn.AllowEdit = false;
            this.tlcLedgerName.Visible = true;
            this.tlcLedgerName.VisibleIndex = 0;
            this.tlcLedgerName.Width = 507;
            // 
            // tlcParentID
            // 
            this.tlcParentID.Caption = "ParentID";
            this.tlcParentID.FieldName = "ParentID";
            this.tlcParentID.MinWidth = 17;
            this.tlcParentID.Name = "tlcParentID";
            this.tlcParentID.Width = 64;
            // 
            // tlcLedgerID
            // 
            this.tlcLedgerID.Caption = "LedgerID";
            this.tlcLedgerID.FieldName = "LedgerID";
            this.tlcLedgerID.MinWidth = 17;
            this.tlcLedgerID.Name = "tlcLedgerID";
            this.tlcLedgerID.Width = 64;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.treeListColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeListColumn1.Caption = "Add Ledger";
            this.treeListColumn1.FieldName = "Add";
            this.treeListColumn1.MaxWidth = 77;
            this.treeListColumn1.MinWidth = 17;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 1;
            this.treeListColumn1.Width = 77;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "LEDGERTYPE";
            this.treeListColumn2.FieldName = "LEDGERTYPE";
            this.treeListColumn2.MinWidth = 17;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Width = 64;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnAdd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAdd.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAdd_ButtonClick);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.tlLedger);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(782, 443);
            this.tablePanel1.TabIndex = 1;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // frmLedgerCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmLedgerCreation";
            this.Size = new System.Drawing.Size(782, 443);
            this.Load += new System.EventHandler(this.frmLedgerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList tlLedger;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLedgerName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcParentID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLedgerID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcLedgerLevel;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}