namespace IIT
{
    partial class ucNavigationRouter
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.gcButtons = new DevExpress.XtraGrid.GridControl();
            this.gvButtons = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Is Header";
            this.gridColumn3.FieldName = "IsHeader";
            this.gridColumn3.MinWidth = 17;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 64;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "S No";
            this.gridColumn1.FieldName = "SNo";
            this.gridColumn1.MinWidth = 17;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 64;
            // 
            // tablePanel1
            // 
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.lblHeader);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(862, 679);
            this.tablePanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Appearance.Options.UseTextOptions = true;
            this.lblHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHeader.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tablePanel1.SetColumn(this.lblHeader, 0);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Location = new System.Drawing.Point(3, 3);
            this.lblHeader.Name = "lblHeader";
            this.tablePanel1.SetRow(this.lblHeader, 0);
            this.lblHeader.Size = new System.Drawing.Size(425, 673);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Caption";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 85.69F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.gcButtons);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(434, 3);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 0);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Size = new System.Drawing.Size(425, 673);
            this.tablePanel2.TabIndex = 0;
            // 
            // gcButtons
            // 
            this.tablePanel2.SetColumn(this.gcButtons, 1);
            this.gcButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcButtons.Location = new System.Drawing.Point(41, 316);
            this.gcButtons.MainView = this.gvButtons;
            this.gcButtons.Name = "gcButtons";
            this.tablePanel2.SetRow(this.gcButtons, 1);
            this.gcButtons.Size = new System.Drawing.Size(344, 42);
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvButtons.DetailHeight = 327;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gridColumn3;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Expression = "[IsHeader] = True";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvButtons.FormatRules.Add(gridFormatRule1);
            this.gvButtons.GridControl = this.gcButtons;
            this.gvButtons.Name = "gvButtons";
            this.gvButtons.OptionsBehavior.Editable = false;
            this.gvButtons.OptionsView.ShowColumnHeaders = false;
            this.gvButtons.OptionsView.ShowGroupPanel = false;
            this.gvButtons.OptionsView.ShowIndicator = false;
            this.gvButtons.RowHeight = 25;
            this.gvButtons.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvButtons_FocusedRowChanged);
            this.gvButtons.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvButtons_CustomColumnDisplayText);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Action";
            this.gridColumn2.FieldName = "Action";
            this.gridColumn2.MinWidth = 17;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 64;
            // 
            // ucNavigationRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ucNavigationRouter";
            this.Size = new System.Drawing.Size(862, 679);
            this.Load += new System.EventHandler(this.ucNavigationRouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvButtons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraGrid.GridControl gcButtons;
        private DevExpress.XtraGrid.Views.Grid.GridView gvButtons;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
