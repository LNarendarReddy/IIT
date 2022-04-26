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
            this.bbiVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLiabilities = new DevExpress.XtraBars.BarButtonItem();
            this.btnAssets = new DevExpress.XtraBars.BarButtonItem();
            this.btnIncome = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpenses = new DevExpress.XtraBars.BarButtonItem();
            this.btnCashPaymentVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankPaymentVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.btnCashRecieptVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankRecieptVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.btnVoucherList = new DevExpress.XtraBars.BarButtonItem();
            this.btnExitCompany = new DevExpress.XtraBars.BarButtonItem();
            this.rpIIT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAccounts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnCashPaymentLedger = new DevExpress.XtraBars.BarButtonItem();
            this.btnCashRecieptLedger = new DevExpress.XtraBars.BarButtonItem();
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
            this.bbiVoucher,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnLiabilities,
            this.btnAssets,
            this.btnIncome,
            this.btnExpenses,
            this.btnCashPaymentVoucher,
            this.btnBankPaymentVoucher,
            this.btnCashRecieptVoucher,
            this.btnBankRecieptVoucher,
            this.btnVoucherList,
            this.btnExitCompany,
            this.btnCashPaymentLedger,
            this.btnCashRecieptLedger});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl1.MaxItemId = 26;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpIIT,
            this.rpAccounts});
            this.ribbonControl1.Size = new System.Drawing.Size(1332, 164);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnEntity
            // 
            this.btnEntity.Caption = "&Entity List";
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
            // bbiVoucher
            // 
            this.bbiVoucher.Caption = "Voucher";
            this.bbiVoucher.Id = 8;
            this.bbiVoucher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiVoucher.ImageOptions.Image")));
            this.bbiVoucher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVoucher.ImageOptions.LargeImage")));
            this.bbiVoucher.Name = "bbiVoucher";
            this.bbiVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiVoucher_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnLiabilities
            // 
            this.btnLiabilities.Caption = "Liabilities";
            this.btnLiabilities.Id = 13;
            this.btnLiabilities.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLiabilities.ImageOptions.SvgImage")));
            this.btnLiabilities.Name = "btnLiabilities";
            this.btnLiabilities.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLiabilities_ItemClick);
            // 
            // btnAssets
            // 
            this.btnAssets.Caption = "Assets";
            this.btnAssets.Id = 14;
            this.btnAssets.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAssets.ImageOptions.SvgImage")));
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAssets_ItemClick);
            // 
            // btnIncome
            // 
            this.btnIncome.Caption = "Income";
            this.btnIncome.Id = 15;
            this.btnIncome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIncome.ImageOptions.SvgImage")));
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIncome_ItemClick);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Caption = "Expenses";
            this.btnExpenses.Id = 16;
            this.btnExpenses.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExpenses.ImageOptions.SvgImage")));
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpenses_ItemClick);
            // 
            // btnCashPaymentVoucher
            // 
            this.btnCashPaymentVoucher.Caption = "Cash Payment Voucher";
            this.btnCashPaymentVoucher.Id = 17;
            this.btnCashPaymentVoucher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCashPaymentVoucher.ImageOptions.SvgImage")));
            this.btnCashPaymentVoucher.Name = "btnCashPaymentVoucher";
            this.btnCashPaymentVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCashPaymentVoucher_ItemClick);
            // 
            // btnBankPaymentVoucher
            // 
            this.btnBankPaymentVoucher.Caption = "Bank Payment Voucher";
            this.btnBankPaymentVoucher.Id = 18;
            this.btnBankPaymentVoucher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBankPaymentVoucher.ImageOptions.SvgImage")));
            this.btnBankPaymentVoucher.Name = "btnBankPaymentVoucher";
            this.btnBankPaymentVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankPaymentVoucher_ItemClick);
            // 
            // btnCashRecieptVoucher
            // 
            this.btnCashRecieptVoucher.Caption = "Cash Reciept Voucher";
            this.btnCashRecieptVoucher.Id = 19;
            this.btnCashRecieptVoucher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCashRecieptVoucher.ImageOptions.SvgImage")));
            this.btnCashRecieptVoucher.Name = "btnCashRecieptVoucher";
            this.btnCashRecieptVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCashRecieptVoucher_ItemClick);
            // 
            // btnBankRecieptVoucher
            // 
            this.btnBankRecieptVoucher.Caption = "Bank Reciept Voucher";
            this.btnBankRecieptVoucher.Id = 20;
            this.btnBankRecieptVoucher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBankRecieptVoucher.ImageOptions.SvgImage")));
            this.btnBankRecieptVoucher.Name = "btnBankRecieptVoucher";
            this.btnBankRecieptVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankRecieptVoucher_ItemClick);
            // 
            // btnVoucherList
            // 
            this.btnVoucherList.Caption = "Voucher List";
            this.btnVoucherList.Id = 21;
            this.btnVoucherList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVoucherList.ImageOptions.SvgImage")));
            this.btnVoucherList.Name = "btnVoucherList";
            this.btnVoucherList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVoucherList_ItemClick);
            // 
            // btnExitCompany
            // 
            this.btnExitCompany.Caption = "Exit Company";
            this.btnExitCompany.Id = 23;
            this.btnExitCompany.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExitCompany.ImageOptions.SvgImage")));
            this.btnExitCompany.Name = "btnExitCompany";
            this.btnExitCompany.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExitCompany_ItemClick);
            // 
            // rpIIT
            // 
            this.rpIIT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.rpIIT.Name = "rpIIT";
            this.rpIIT.Text = "IIT";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNOB);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEntity);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiGroup);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiSubGroup);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Group options";
            this.ribbonPageGroup3.Visible = false;
            // 
            // rpAccounts
            // 
            this.rpAccounts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup4,
            this.ribbonPageGroup9});
            this.rpAccounts.Name = "rpAccounts";
            this.rpAccounts.Text = "Accounts";
            this.rpAccounts.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnAssets);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLiabilities);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnIncome);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnExpenses);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Ledger Creation";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnCashPaymentVoucher);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnCashRecieptVoucher);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnBankPaymentVoucher);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnBankRecieptVoucher);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnVoucherList);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Voucher Entry";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnExitCompany);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
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
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup9.ImageOptions.SvgImage")));
            this.ribbonPageGroup9.ItemLinks.Add(this.btnCashPaymentLedger);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnCashRecieptLedger);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Reports";
            // 
            // btnCashPaymentLedger
            // 
            this.btnCashPaymentLedger.Caption = "Cash Payment Ledger";
            this.btnCashPaymentLedger.Id = 24;
            this.btnCashPaymentLedger.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.btnCashPaymentLedger.Name = "btnCashPaymentLedger";
            this.btnCashPaymentLedger.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCashPaymentLedger_ItemClick);
            // 
            // btnCashRecieptLedger
            // 
            this.btnCashRecieptLedger.Caption = "Cash Reciept Ledger";
            this.btnCashRecieptLedger.Id = 25;
            this.btnCashRecieptLedger.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCashRecieptLedger.ImageOptions.SvgImage")));
            this.btnCashRecieptLedger.Name = "btnCashRecieptLedger";
            this.btnCashRecieptLedger.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCashRecieptLedger_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 863);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "IIT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpIIT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnEntity;
        private DevExpress.XtraBars.BarStaticItem lblDateTime;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.XtraBars.BarStaticItem lblVersion;
        private DevExpress.XtraBars.BarButtonItem bbiNOB;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAccounts;
        private DevExpress.XtraBars.BarButtonItem bbiGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiSubGroup;
        private DevExpress.XtraBars.BarButtonItem bbiVoucher;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnLiabilities;
        private DevExpress.XtraBars.BarButtonItem btnAssets;
        private DevExpress.XtraBars.BarButtonItem btnIncome;
        private DevExpress.XtraBars.BarButtonItem btnExpenses;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnCashPaymentVoucher;
        private DevExpress.XtraBars.BarButtonItem btnBankPaymentVoucher;
        private DevExpress.XtraBars.BarButtonItem btnCashRecieptVoucher;
        private DevExpress.XtraBars.BarButtonItem btnBankRecieptVoucher;
        private DevExpress.XtraBars.BarButtonItem btnVoucherList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnExitCompany;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnCashPaymentLedger;
        private DevExpress.XtraBars.BarButtonItem btnCashRecieptLedger;
    }
}

