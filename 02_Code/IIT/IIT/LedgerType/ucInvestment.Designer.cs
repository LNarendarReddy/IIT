namespace IIT
{
    partial class ucInvestment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInvestment));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtOpeningBalance = new DevExpress.XtraEditors.TextEdit();
            this.txtTenure = new DevExpress.XtraEditors.TextEdit();
            this.txtLedgerName = new DevExpress.XtraEditors.TextEdit();
            this.cmbTypeOfInvestment = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTCSRate = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTDSApplicable = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpeningBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeOfInvestment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTCSRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTDSApplicable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(435, 346);
            this.tablePanel1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.tablePanel1.SetColumn(this.layoutControl1, 0);
            this.layoutControl1.Controls.Add(this.lblHeader);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtOpeningBalance);
            this.layoutControl1.Controls.Add(this.txtTenure);
            this.layoutControl1.Controls.Add(this.txtLedgerName);
            this.layoutControl1.Controls.Add(this.cmbTypeOfInvestment);
            this.layoutControl1.Controls.Add(this.cmbTCSRate);
            this.layoutControl1.Controls.Add(this.cmbTDSApplicable);
            this.layoutControl1.Location = new System.Drawing.Point(3, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.layoutControl1, 0);
            this.layoutControl1.Size = new System.Drawing.Size(416, 327);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(72, 5);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(272, 22);
            this.lblHeader.StyleController = this.layoutControl1;
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Investments ledgers Creation";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(307, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 34);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.EnterMoveNextControl = true;
            this.txtOpeningBalance.Location = new System.Drawing.Point(137, 228);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Properties.DisplayFormat.FormatString = "n2";
            this.txtOpeningBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOpeningBalance.Properties.EditFormat.FormatString = "n2";
            this.txtOpeningBalance.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtOpeningBalance.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtOpeningBalance.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtOpeningBalance.Properties.MaskSettings.Set("mask", "n2");
            this.txtOpeningBalance.Size = new System.Drawing.Size(267, 20);
            this.txtOpeningBalance.StyleController = this.layoutControl1;
            this.txtOpeningBalance.TabIndex = 11;
            // 
            // txtTenure
            // 
            this.txtTenure.EnterMoveNextControl = true;
            this.txtTenure.Location = new System.Drawing.Point(137, 114);
            this.txtTenure.Name = "txtTenure";
            this.txtTenure.Properties.MaxLength = 11;
            this.txtTenure.Size = new System.Drawing.Size(267, 20);
            this.txtTenure.StyleController = this.layoutControl1;
            this.txtTenure.TabIndex = 7;
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.EnterMoveNextControl = true;
            this.txtLedgerName.Location = new System.Drawing.Point(137, 38);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtLedgerName.Properties.MaskSettings.Set("mask", "[a-zA-Z0-9]{0,16}");
            this.txtLedgerName.Size = new System.Drawing.Size(267, 20);
            this.txtLedgerName.StyleController = this.layoutControl1;
            this.txtLedgerName.TabIndex = 2;
            // 
            // cmbTypeOfInvestment
            // 
            this.cmbTypeOfInvestment.EnterMoveNextControl = true;
            this.cmbTypeOfInvestment.Location = new System.Drawing.Point(137, 76);
            this.cmbTypeOfInvestment.Name = "cmbTypeOfInvestment";
            this.cmbTypeOfInvestment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTypeOfInvestment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTITYLOOKUPID", "ENTITYLOOKUPID", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOOKUPVALUE", "LOOKUPVALUE", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbTypeOfInvestment.Properties.NullText = "";
            this.cmbTypeOfInvestment.Properties.ShowHeader = false;
            this.cmbTypeOfInvestment.Size = new System.Drawing.Size(267, 20);
            this.cmbTypeOfInvestment.StyleController = this.layoutControl1;
            this.cmbTypeOfInvestment.TabIndex = 1;
            // 
            // cmbTCSRate
            // 
            this.cmbTCSRate.EnterMoveNextControl = true;
            this.cmbTCSRate.Location = new System.Drawing.Point(137, 190);
            this.cmbTCSRate.Name = "cmbTCSRate";
            this.cmbTCSRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTCSRate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTITYLOOKUPID", "ENTITYLOOKUPID", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOOKUPVALUE", "LOOKUPVALUE", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbTCSRate.Properties.NullText = "";
            this.cmbTCSRate.Properties.PopupSizeable = false;
            this.cmbTCSRate.Properties.ShowHeader = false;
            this.cmbTCSRate.Size = new System.Drawing.Size(267, 20);
            this.cmbTCSRate.StyleController = this.layoutControl1;
            this.cmbTCSRate.TabIndex = 9;
            // 
            // cmbTDSApplicable
            // 
            this.cmbTDSApplicable.EnterMoveNextControl = true;
            this.cmbTDSApplicable.Location = new System.Drawing.Point(137, 152);
            this.cmbTDSApplicable.Name = "cmbTDSApplicable";
            this.cmbTDSApplicable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTDSApplicable.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ENTITYLOOKUPID", "ENTITYLOOKUPID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOOKUPVALUE", "LOOKUPVALUE")});
            this.cmbTDSApplicable.Properties.NullText = "";
            this.cmbTDSApplicable.Properties.ShowHeader = false;
            this.cmbTDSApplicable.Size = new System.Drawing.Size(267, 20);
            this.cmbTDSApplicable.StyleController = this.layoutControl1;
            this.cmbTDSApplicable.TabIndex = 8;
            this.cmbTDSApplicable.EditValueChanged += new System.EventHandler(this.cmbTDSApplicable_EditValueChanged);
            // 
            // Root
            // 
            this.Root.AppearanceGroup.BorderColor = System.Drawing.Color.Silver;
            this.Root.AppearanceGroup.Options.UseBorderColor = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(416, 327);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbTypeOfInvestment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlItem1.Size = new System.Drawing.Size(410, 38);
            this.layoutControlItem1.Text = "Type of Investment";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(113, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 254);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(295, 67);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTenure;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlItem4.Size = new System.Drawing.Size(410, 38);
            this.layoutControlItem4.Text = "Tenure";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(113, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbTCSRate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 178);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlItem6.Size = new System.Drawing.Size(410, 38);
            this.layoutControlItem6.Text = "TCS Rate";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(113, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtOpeningBalance;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlItem11.Size = new System.Drawing.Size(410, 38);
            this.layoutControlItem11.Text = "Opening Balance ";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(113, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnSave;
            this.layoutControlItem12.Location = new System.Drawing.Point(295, 254);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(115, 52);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(115, 52);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlItem12.Size = new System.Drawing.Size(115, 67);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem13.Control = this.lblHeader;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(410, 26);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtLedgerName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlItem2.Size = new System.Drawing.Size(410, 38);
            this.layoutControlItem2.Text = "Name of the Investment";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(113, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cmbTDSApplicable;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "Reciepts or Additions";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlItem5.Size = new System.Drawing.Size(410, 38);
            this.layoutControlItem5.Text = "Is TDS is applicable ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(113, 14);
            // 
            // ucInvestment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ucInvestment";
            this.Size = new System.Drawing.Size(435, 346);
            this.Load += new System.EventHandler(this.ucInvestment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOpeningBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeOfInvestment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTCSRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTDSApplicable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtOpeningBalance;
        private DevExpress.XtraEditors.TextEdit txtTenure;
        private DevExpress.XtraEditors.TextEdit txtLedgerName;
        private DevExpress.XtraEditors.LookUpEdit cmbTypeOfInvestment;
        private DevExpress.XtraEditors.LookUpEdit cmbTCSRate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraEditors.LookUpEdit cmbTDSApplicable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
