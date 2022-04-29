namespace IIT
{
    partial class ucAccountInfo
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLedgerPrinting = new DevExpress.XtraEditors.SimpleButton();
            this.btnMISForms = new DevExpress.XtraEditors.SimpleButton();
            this.btnDayBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnInventoryEntry = new DevExpress.XtraEditors.SimpleButton();
            this.btnvoucherEntry = new DevExpress.XtraEditors.SimpleButton();
            this.btnLeadgerCreation = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 390F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.layoutControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 401F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Size = new System.Drawing.Size(1080, 726);
            this.tablePanel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Arial", 14F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.layoutControl1, 1);
            this.layoutControl1.Controls.Add(this.btnLedgerPrinting);
            this.layoutControl1.Controls.Add(this.btnMISForms);
            this.layoutControl1.Controls.Add(this.btnDayBook);
            this.layoutControl1.Controls.Add(this.btnInventoryEntry);
            this.layoutControl1.Controls.Add(this.btnvoucherEntry);
            this.layoutControl1.Controls.Add(this.btnLeadgerCreation);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(348, 166);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.layoutControl1, 1);
            this.layoutControl1.Size = new System.Drawing.Size(384, 395);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLedgerPrinting
            // 
            this.btnLedgerPrinting.Location = new System.Drawing.Point(32, 333);
            this.btnLedgerPrinting.Name = "btnLedgerPrinting";
            this.btnLedgerPrinting.Size = new System.Drawing.Size(320, 27);
            this.btnLedgerPrinting.StyleController = this.layoutControl1;
            this.btnLedgerPrinting.TabIndex = 5;
            this.btnLedgerPrinting.Text = "Ledger Printing";
            this.btnLedgerPrinting.Click += new System.EventHandler(this.btnLedgerPrinting_Click);
            // 
            // btnMISForms
            // 
            this.btnMISForms.Location = new System.Drawing.Point(32, 194);
            this.btnMISForms.Name = "btnMISForms";
            this.btnMISForms.Size = new System.Drawing.Size(320, 27);
            this.btnMISForms.StyleController = this.layoutControl1;
            this.btnMISForms.TabIndex = 3;
            this.btnMISForms.Text = "MIS Forms";
            // 
            // btnDayBook
            // 
            this.btnDayBook.Location = new System.Drawing.Point(32, 286);
            this.btnDayBook.Name = "btnDayBook";
            this.btnDayBook.Size = new System.Drawing.Size(320, 27);
            this.btnDayBook.StyleController = this.layoutControl1;
            this.btnDayBook.TabIndex = 4;
            this.btnDayBook.Text = "Day Book";
            this.btnDayBook.Click += new System.EventHandler(this.btnDayBook_Click);
            // 
            // btnInventoryEntry
            // 
            this.btnInventoryEntry.Location = new System.Drawing.Point(32, 147);
            this.btnInventoryEntry.Name = "btnInventoryEntry";
            this.btnInventoryEntry.Size = new System.Drawing.Size(320, 27);
            this.btnInventoryEntry.StyleController = this.layoutControl1;
            this.btnInventoryEntry.TabIndex = 2;
            this.btnInventoryEntry.Text = "Inventory Entry";
            // 
            // btnvoucherEntry
            // 
            this.btnvoucherEntry.Location = new System.Drawing.Point(32, 100);
            this.btnvoucherEntry.Name = "btnvoucherEntry";
            this.btnvoucherEntry.Size = new System.Drawing.Size(320, 27);
            this.btnvoucherEntry.StyleController = this.layoutControl1;
            this.btnvoucherEntry.TabIndex = 1;
            this.btnvoucherEntry.Text = "Voucher Entry";
            // 
            // btnLeadgerCreation
            // 
            this.btnLeadgerCreation.Location = new System.Drawing.Point(32, 53);
            this.btnLeadgerCreation.Name = "btnLeadgerCreation";
            this.btnLeadgerCreation.Size = new System.Drawing.Size(320, 27);
            this.btnLeadgerCreation.StyleController = this.layoutControl1;
            this.btnLeadgerCreation.TabIndex = 0;
            this.btnLeadgerCreation.Text = "Ledger Creation";
            this.btnLeadgerCreation.Click += new System.EventHandler(this.btnLeadgerCreation_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(384, 395);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Arial", 14F);
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(364, 233);
            this.layoutControlGroup1.Text = "Accounts";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnLeadgerCreation;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(340, 47);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnvoucherEntry;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(340, 47);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnInventoryEntry;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(340, 47);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnMISForms;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 141);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(340, 47);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Arial", 14F);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 233);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(364, 142);
            this.layoutControlGroup2.Text = "Reports";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDayBook;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(340, 47);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnLedgerPrinting;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(340, 50);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // ucAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ucAccountInfo";
            this.Size = new System.Drawing.Size(1080, 726);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnMISForms;
        private DevExpress.XtraEditors.SimpleButton btnDayBook;
        private DevExpress.XtraEditors.SimpleButton btnInventoryEntry;
        private DevExpress.XtraEditors.SimpleButton btnvoucherEntry;
        private DevExpress.XtraEditors.SimpleButton btnLeadgerCreation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton btnLedgerPrinting;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
