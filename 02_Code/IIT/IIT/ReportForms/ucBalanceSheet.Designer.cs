namespace IIT.ReportForms
{
    partial class ucBalanceSheet
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
            this.tlAssets = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcBalanceSheetAssetsLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn11 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlLiabilities = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcBalanceSheetLiabilitiesLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlLiabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tlAssets);
            this.layoutControl1.Controls.Add(this.tlLiabilities);
            this.layoutControl1.Controls.Add(this.lblHeader);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(903, 463);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tlAssets
            // 
            this.tlAssets.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn4,
            this.treeListColumn7,
            this.treeListColumn8,
            this.tlcBalanceSheetAssetsLevel,
            this.treeListColumn10,
            this.treeListColumn11});
            this.tlAssets.Location = new System.Drawing.Point(410, 24);
            this.tlAssets.Name = "tlAssets";
            this.tlAssets.OptionsBehavior.Editable = false;
            this.tlAssets.OptionsView.ShowSummaryFooter = true;
            this.tlAssets.Size = new System.Drawing.Size(489, 435);
            this.tlAssets.TabIndex = 5;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "BSID";
            this.treeListColumn4.FieldName = "BSID";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "PARENTID";
            this.treeListColumn7.FieldName = "PARENTID";
            this.treeListColumn7.Name = "treeListColumn7";
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "CURRENTID";
            this.treeListColumn8.FieldName = "CURRENTID";
            this.treeListColumn8.Name = "treeListColumn8";
            // 
            // tlcBalanceSheetAssetsLevel
            // 
            this.tlcBalanceSheetAssetsLevel.Caption = "BSLEVEL";
            this.tlcBalanceSheetAssetsLevel.FieldName = "BSLEVEL";
            this.tlcBalanceSheetAssetsLevel.Name = "tlcBalanceSheetAssetsLevel";
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.Caption = "Particular";
            this.treeListColumn10.FieldName = "BSNAME";
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.Visible = true;
            this.treeListColumn10.VisibleIndex = 0;
            // 
            // treeListColumn11
            // 
            this.treeListColumn11.Caption = "Opening balance";
            this.treeListColumn11.FieldName = "OPENINGBAL";
            this.treeListColumn11.Name = "treeListColumn11";
            this.treeListColumn11.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.treeListColumn11.Visible = true;
            this.treeListColumn11.VisibleIndex = 1;
            // 
            // tlLiabilities
            // 
            this.tlLiabilities.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.tlcBalanceSheetLiabilitiesLevel,
            this.treeListColumn5,
            this.treeListColumn6});
            this.tlLiabilities.Location = new System.Drawing.Point(4, 24);
            this.tlLiabilities.Name = "tlLiabilities";
            this.tlLiabilities.OptionsBehavior.Editable = false;
            this.tlLiabilities.OptionsView.ShowSummaryFooter = true;
            this.tlLiabilities.Size = new System.Drawing.Size(402, 435);
            this.tlLiabilities.TabIndex = 4;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "BSID";
            this.treeListColumn1.FieldName = "BSID";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "PARENTID";
            this.treeListColumn2.FieldName = "PARENTID";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "CURRENTID";
            this.treeListColumn3.FieldName = "CURRENTID";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // tlcBalanceSheetLiabilitiesLevel
            // 
            this.tlcBalanceSheetLiabilitiesLevel.Caption = "BSLEVEL";
            this.tlcBalanceSheetLiabilitiesLevel.FieldName = "BSLEVEL";
            this.tlcBalanceSheetLiabilitiesLevel.Name = "tlcBalanceSheetLiabilitiesLevel";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Particular";
            this.treeListColumn5.FieldName = "BSNAME";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 0;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Opening Balance";
            this.treeListColumn6.FieldName = "OPENINGBAL";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(387, 4);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(128, 16);
            this.lblHeader.StyleController = this.layoutControl1;
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Balance sheet as on";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(903, 463);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tlLiabilities;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 20);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(406, 439);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tlAssets;
            this.layoutControlItem2.Location = new System.Drawing.Point(406, 20);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(493, 439);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.Control = this.lblHeader;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(899, 20);
            this.layoutControlItem3.Text = "layoutControlItem2";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // ucBalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucBalanceSheet";
            this.Size = new System.Drawing.Size(903, 463);
            this.Load += new System.EventHandler(this.ucBalanceSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlLiabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraTreeList.TreeList tlAssets;
        private DevExpress.XtraTreeList.TreeList tlLiabilities;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcBalanceSheetLiabilitiesLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcBalanceSheetAssetsLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn11;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
