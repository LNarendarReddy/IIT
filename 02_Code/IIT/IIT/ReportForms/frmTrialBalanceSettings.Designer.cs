namespace IIT.ReportForms
{
    partial class frmTrialBalanceSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrialBalanceSettings));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.chkShowOpeningBalance = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowTransactions = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowClosingBalances = new DevExpress.XtraEditors.CheckEdit();
            this.chkShowPercentages = new DevExpress.XtraEditors.CheckEdit();
            this.chkExpand = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOpeningBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTransactions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowClosingBalances.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPercentages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnApply);
            this.layoutControl1.Controls.Add(this.chkShowOpeningBalance);
            this.layoutControl1.Controls.Add(this.chkShowTransactions);
            this.layoutControl1.Controls.Add(this.chkShowClosingBalances);
            this.layoutControl1.Controls.Add(this.chkShowPercentages);
            this.layoutControl1.Controls.Add(this.chkExpand);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(341, 224);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(213, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 36);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            // 
            // btnApply
            // 
            this.btnApply.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.ImageOptions.Image")));
            this.btnApply.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnApply.Location = new System.Drawing.Point(92, 176);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(117, 36);
            this.btnApply.StyleController = this.layoutControl1;
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkShowOpeningBalance
            // 
            this.chkShowOpeningBalance.EditValue = true;
            this.chkShowOpeningBalance.Location = new System.Drawing.Point(182, 16);
            this.chkShowOpeningBalance.Name = "chkShowOpeningBalance";
            this.chkShowOpeningBalance.Properties.Caption = "";
            this.chkShowOpeningBalance.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkShowOpeningBalance.Size = new System.Drawing.Size(143, 18);
            this.chkShowOpeningBalance.StyleController = this.layoutControl1;
            this.chkShowOpeningBalance.TabIndex = 0;
            // 
            // chkShowTransactions
            // 
            this.chkShowTransactions.Location = new System.Drawing.Point(182, 46);
            this.chkShowTransactions.Name = "chkShowTransactions";
            this.chkShowTransactions.Properties.Caption = "";
            this.chkShowTransactions.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkShowTransactions.Size = new System.Drawing.Size(143, 18);
            this.chkShowTransactions.StyleController = this.layoutControl1;
            this.chkShowTransactions.TabIndex = 1;
            // 
            // chkShowClosingBalances
            // 
            this.chkShowClosingBalances.EditValue = true;
            this.chkShowClosingBalances.Location = new System.Drawing.Point(182, 76);
            this.chkShowClosingBalances.Name = "chkShowClosingBalances";
            this.chkShowClosingBalances.Properties.Caption = "";
            this.chkShowClosingBalances.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkShowClosingBalances.Size = new System.Drawing.Size(143, 18);
            this.chkShowClosingBalances.StyleController = this.layoutControl1;
            this.chkShowClosingBalances.TabIndex = 2;
            // 
            // chkShowPercentages
            // 
            this.chkShowPercentages.Location = new System.Drawing.Point(182, 106);
            this.chkShowPercentages.Name = "chkShowPercentages";
            this.chkShowPercentages.Properties.Caption = "";
            this.chkShowPercentages.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkShowPercentages.Size = new System.Drawing.Size(143, 18);
            this.chkShowPercentages.StyleController = this.layoutControl1;
            this.chkShowPercentages.TabIndex = 3;
            // 
            // chkExpand
            // 
            this.chkExpand.EditValue = true;
            this.chkExpand.Location = new System.Drawing.Point(182, 136);
            this.chkExpand.Name = "chkExpand";
            this.chkExpand.Properties.Caption = "";
            this.chkExpand.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.chkExpand.Size = new System.Drawing.Size(143, 18);
            this.chkExpand.StyleController = this.layoutControl1;
            this.chkExpand.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(341, 224);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkShowOpeningBalance;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem1.Size = new System.Drawing.Size(321, 30);
            this.layoutControlItem1.Text = "Show Opening balance";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(154, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chkShowTransactions;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "Show Opening balance";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem2.Size = new System.Drawing.Size(321, 30);
            this.layoutControlItem2.Text = "Show Transactions";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(154, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chkShowClosingBalances;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "Show Opening balance";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem3.Size = new System.Drawing.Size(321, 30);
            this.layoutControlItem3.Text = "Show Closing balance";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(154, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkShowPercentages;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "Show Opening balance";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem4.Size = new System.Drawing.Size(321, 30);
            this.layoutControlItem4.Text = "Show percentages";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(154, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chkExpand;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "Show Opening balance";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem5.Size = new System.Drawing.Size(321, 30);
            this.layoutControlItem5.Text = "Expand all levels in Detail format";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(154, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnApply;
            this.layoutControlItem6.Location = new System.Drawing.Point(80, 164);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(121, 40);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(121, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(121, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnCancel;
            this.layoutControlItem7.Location = new System.Drawing.Point(201, 164);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(120, 40);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(120, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(120, 40);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 164);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(80, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 150);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(321, 14);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmTrialBalanceSettings
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(341, 224);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmTrialBalanceSettings";
            this.Text = "Trial Balance Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkShowOpeningBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTransactions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowClosingBalances.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowPercentages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;        
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}