namespace IIT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEntity = new DevExpress.XtraBars.BarButtonItem();
            this.lblDateTime = new DevExpress.XtraBars.BarStaticItem();
            this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.lblVersion = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNOB = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGroup = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSubGroup = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiVoucher = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnEntity,
            this.lblDateTime,
            this.lblStatus,
            this.lblVersion,
            this.bbiNOB,
            this.bbiGroup,
            this.bbiSubGroup,
            this.bbiVoucher});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.Size = new System.Drawing.Size(1332, 164);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnEntity
            // 
            this.btnEntity.Caption = "&Entity";
            this.btnEntity.Id = 1;
            this.btnEntity.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEntity.ImageOptions.SvgImage")));
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEntity_ItemClick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblDateTime.Id = 2;
            this.lblDateTime.Name = "lblDateTime";
            // 
            // lblStatus
            // 
            this.lblStatus.Id = 3;
            this.lblStatus.Name = "lblStatus";
            // 
            // lblVersion
            // 
            this.lblVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblVersion.Id = 4;
            this.lblVersion.Name = "lblVersion";
            // 
            // bbiNOB
            // 
            this.bbiNOB.Caption = "Nature of Business";
            this.bbiNOB.Id = 5;
            this.bbiNOB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNOB.ImageOptions.Image")));
            this.bbiNOB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNOB.ImageOptions.LargeImage")));
            this.bbiNOB.Name = "bbiNOB";
            this.bbiNOB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNOB_ItemClick);
            // 
            // bbiGroup
            // 
            this.bbiGroup.Caption = "Group";
            this.bbiGroup.Id = 6;
            this.bbiGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGroup.ImageOptions.Image")));
            this.bbiGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGroup.ImageOptions.LargeImage")));
            this.bbiGroup.Name = "bbiGroup";
            this.bbiGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGroup_ItemClick);
            // 
            // bbiSubGroup
            // 
            this.bbiSubGroup.Caption = "Sub Group";
            this.bbiSubGroup.Id = 7;
            this.bbiSubGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSubGroup.ImageOptions.Image")));
            this.bbiSubGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSubGroup.ImageOptions.LargeImage")));
            this.bbiSubGroup.Name = "bbiSubGroup";
            this.bbiSubGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSubGroup_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "IIT";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEntity);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Masters";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiNOB);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Nature of business";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiGroup);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiSubGroup);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Group options";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lblDateTime);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblStatus);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblVersion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 841);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1332, 22);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Ledger";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiVoucher);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Ledger options";
            // 
            // bbiVoucher
            // 
            this.bbiVoucher.Caption = "Voucher";
            this.bbiVoucher.Id = 8;
            this.bbiVoucher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiVoucher.ImageOptions.Image")));
            this.bbiVoucher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVoucher.ImageOptions.LargeImage")));
            this.bbiVoucher.Name = "bbiVoucher";
            this.bbiVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiVoucher_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 863);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnEntity;
        private DevExpress.XtraBars.BarStaticItem lblDateTime;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.XtraBars.BarStaticItem lblVersion;
        private DevExpress.XtraBars.BarButtonItem bbiNOB;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiSubGroup;
        private DevExpress.XtraBars.BarButtonItem bbiVoucher;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}

