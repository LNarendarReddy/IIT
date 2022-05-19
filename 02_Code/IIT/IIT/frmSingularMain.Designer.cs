﻿namespace IIT
{
    partial class frmSingularMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingularMain));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.btnBack = new DevExpress.XtraEditors.LabelControl();
            this.lblNavigationHeader = new DevExpress.XtraEditors.LabelControl();
            this.lblEntityName = new DevExpress.XtraEditors.LabelControl();
            this.pcMain = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.gcHelpText = new DevExpress.XtraGrid.GridControl();
            this.cvHelpText = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lblCompanyPath = new DevExpress.XtraEditors.LabelControl();
            this.lblReportsPath = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHelpText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvHelpText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AutoSize = true;
            this.lcMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.lcMain.Controls.Add(this.tablePanel3);
            this.lcMain.Controls.Add(this.tablePanel2);
            this.lcMain.Controls.Add(this.tablePanel1);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(332, 400, 650, 400);
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(1147, 702);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 43F)});
            this.tablePanel3.Controls.Add(this.btnBack);
            this.tablePanel3.Controls.Add(this.lblNavigationHeader);
            this.tablePanel3.Controls.Add(this.lblEntityName);
            this.tablePanel3.Controls.Add(this.pcMain);
            this.tablePanel3.Location = new System.Drawing.Point(5, 5);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 36F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel3.Size = new System.Drawing.Size(945, 561);
            this.tablePanel3.TabIndex = 7;
            // 
            // btnBack
            // 
            this.tablePanel3.SetColumn(this.btnBack, 1);
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBack.ImageOptions.SvgImage")));
            this.btnBack.Location = new System.Drawing.Point(905, 43);
            this.btnBack.Name = "btnBack";
            this.tablePanel3.SetRow(this.btnBack, 1);
            this.btnBack.Size = new System.Drawing.Size(37, 30);
            this.btnBack.TabIndex = 9;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblNavigationHeader
            // 
            this.lblNavigationHeader.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblNavigationHeader.Appearance.Options.UseFont = true;
            this.tablePanel3.SetColumn(this.lblNavigationHeader, 0);
            this.lblNavigationHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNavigationHeader.Location = new System.Drawing.Point(3, 43);
            this.lblNavigationHeader.Name = "lblNavigationHeader";
            this.tablePanel3.SetRow(this.lblNavigationHeader, 1);
            this.lblNavigationHeader.Size = new System.Drawing.Size(85, 30);
            this.lblNavigationHeader.TabIndex = 8;
            this.lblNavigationHeader.Text = "labelControl3";
            // 
            // lblEntityName
            // 
            this.lblEntityName.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblEntityName.Appearance.Options.UseFont = true;
            this.lblEntityName.Appearance.Options.UseTextOptions = true;
            this.lblEntityName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablePanel3.SetColumn(this.lblEntityName, 0);
            this.tablePanel3.SetColumnSpan(this.lblEntityName, 2);
            this.lblEntityName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityName.Location = new System.Drawing.Point(3, 3);
            this.lblEntityName.Name = "lblEntityName";
            this.tablePanel3.SetRow(this.lblEntityName, 0);
            this.lblEntityName.Size = new System.Drawing.Size(939, 34);
            this.lblEntityName.TabIndex = 7;
            this.lblEntityName.Text = "labelControl2";
            // 
            // pcMain
            // 
            this.tablePanel3.SetColumn(this.pcMain, 0);
            this.tablePanel3.SetColumnSpan(this.pcMain, 2);
            this.pcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcMain.Location = new System.Drawing.Point(3, 79);
            this.pcMain.Name = "pcMain";
            this.tablePanel3.SetRow(this.pcMain, 2);
            this.pcMain.Size = new System.Drawing.Size(939, 479);
            this.pcMain.TabIndex = 4;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.tablePanel2.Appearance.Options.UseBackColor = true;
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 55F)});
            this.tablePanel2.Controls.Add(this.gcHelpText);
            this.tablePanel2.Location = new System.Drawing.Point(952, 3);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel2.Size = new System.Drawing.Size(192, 696);
            this.tablePanel2.TabIndex = 5;
            // 
            // gcHelpText
            // 
            this.tablePanel2.SetColumn(this.gcHelpText, 0);
            this.gcHelpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHelpText.Location = new System.Drawing.Point(3, 3);
            this.gcHelpText.MainView = this.cvHelpText;
            this.gcHelpText.Name = "gcHelpText";
            this.tablePanel2.SetRow(this.gcHelpText, 0);
            this.gcHelpText.Size = new System.Drawing.Size(186, 690);
            this.gcHelpText.TabIndex = 0;
            this.gcHelpText.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cvHelpText});
            // 
            // cvHelpText
            // 
            this.cvHelpText.CardCaptionFormat = "{Action}";
            this.cvHelpText.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.cvHelpText.GridControl = this.gcHelpText;
            this.cvHelpText.Name = "cvHelpText";
            this.cvHelpText.OptionsView.ShowQuickCustomizeButton = false;
            this.cvHelpText.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Short cut";
            this.gridColumn2.FieldName = "Shortcut";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Action";
            this.gridColumn1.FieldName = "Action";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 147F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80.87F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 24.13F)});
            this.tablePanel1.Controls.Add(this.lblCompanyPath);
            this.tablePanel1.Controls.Add(this.lblReportsPath);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.pictureEdit1);
            this.tablePanel1.Location = new System.Drawing.Point(8, 573);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(939, 121);
            this.tablePanel1.TabIndex = 0;
            // 
            // lblCompanyPath
            // 
            this.tablePanel1.SetColumn(this.lblCompanyPath, 1);
            this.lblCompanyPath.Location = new System.Drawing.Point(150, 57);
            this.lblCompanyPath.Name = "lblCompanyPath";
            this.tablePanel1.SetRow(this.lblCompanyPath, 2);
            this.lblCompanyPath.Size = new System.Drawing.Size(0, 15);
            this.lblCompanyPath.TabIndex = 3;
            // 
            // lblReportsPath
            // 
            this.tablePanel1.SetColumn(this.lblReportsPath, 1);
            this.lblReportsPath.Location = new System.Drawing.Point(150, 31);
            this.lblReportsPath.Name = "lblReportsPath";
            this.tablePanel1.SetRow(this.lblReportsPath, 1);
            this.lblReportsPath.Size = new System.Drawing.Size(0, 15);
            this.lblReportsPath.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(150, 5);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(141, 15);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Application Version : 1.0.0";
            // 
            // pictureEdit1
            // 
            this.tablePanel1.SetColumn(this.pictureEdit1, 0);
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.tablePanel1.SetRow(this.pictureEdit1, 0);
            this.tablePanel1.SetRowSpan(this.pictureEdit1, 4);
            this.pictureEdit1.Size = new System.Drawing.Size(141, 115);
            this.pictureEdit1.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(1147, 702);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tablePanel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 565);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 131);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(21, 131);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(949, 131);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tablePanel2;
            this.layoutControlItem3.Location = new System.Drawing.Point(949, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(192, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(192, 11);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(192, 696);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel3;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(949, 565);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // frmSingularMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1147, 702);
            this.Controls.Add(this.lcMain);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSingularMain.IconOptions.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSingularMain";
            this.Text = "IIT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSingularMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSingularMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHelpText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvHelpText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        public DevExpress.XtraEditors.PanelControl pcMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblReportsPath;
        private DevExpress.XtraEditors.LabelControl lblCompanyPath;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraEditors.LabelControl lblNavigationHeader;
        public DevExpress.XtraEditors.LabelControl lblEntityName;
        public DevExpress.XtraEditors.LabelControl btnBack;
        public DevExpress.XtraGrid.GridControl gcHelpText;
        private DevExpress.XtraGrid.Views.Card.CardView cvHelpText;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}