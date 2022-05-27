namespace IIT
{
    partial class ucLedgerReport
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
            this.gcVouchers = new DevExpress.XtraGrid.GridControl();
            this.gvVouchers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblClosingBalance = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblOpeningBalance = new DevExpress.XtraEditors.LabelControl();
            this.lblLedgerName = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 651F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F)});
            this.tablePanel1.Controls.Add(this.gcVouchers);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.lblClosingBalance);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.lblOpeningBalance);
            this.tablePanel1.Controls.Add(this.lblLedgerName);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F)});
            this.tablePanel1.Size = new System.Drawing.Size(861, 464);
            this.tablePanel1.TabIndex = 0;
            // 
            // gcVouchers
            // 
            this.tablePanel1.SetColumn(this.gcVouchers, 1);
            this.tablePanel1.SetColumnSpan(this.gcVouchers, 5);
            this.gcVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVouchers.Location = new System.Drawing.Point(13, 62);
            this.gcVouchers.MainView = this.gvVouchers;
            this.gcVouchers.Name = "gcVouchers";
            this.tablePanel1.SetRow(this.gcVouchers, 3);
            this.gcVouchers.Size = new System.Drawing.Size(835, 368);
            this.gcVouchers.TabIndex = 5;
            this.gcVouchers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVouchers});
            // 
            // gvVouchers
            // 
            this.gvVouchers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gvVouchers.GridControl = this.gcVouchers;
            this.gvVouchers.Name = "gvVouchers";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 3);
            this.labelControl5.Location = new System.Drawing.Point(544, 436);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 4);
            this.labelControl5.Size = new System.Drawing.Size(91, 15);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Closing Balance";
            // 
            // lblClosingBalance
            // 
            this.tablePanel1.SetColumn(this.lblClosingBalance, 4);
            this.lblClosingBalance.Location = new System.Drawing.Point(654, 436);
            this.lblClosingBalance.Name = "lblClosingBalance";
            this.tablePanel1.SetRow(this.lblClosingBalance, 4);
            this.lblClosingBalance.Size = new System.Drawing.Size(24, 15);
            this.lblClosingBalance.TabIndex = 3;
            this.lblClosingBalance.Text = "0.00";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 3);
            this.labelControl3.Location = new System.Drawing.Point(544, 41);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(104, 15);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Opening Balance : ";
            // 
            // lblOpeningBalance
            // 
            this.tablePanel1.SetColumn(this.lblOpeningBalance, 4);
            this.lblOpeningBalance.Location = new System.Drawing.Point(654, 41);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.tablePanel1.SetRow(this.lblOpeningBalance, 2);
            this.lblOpeningBalance.Size = new System.Drawing.Size(24, 15);
            this.lblOpeningBalance.TabIndex = 1;
            this.lblOpeningBalance.Text = "0.00";
            // 
            // lblLedgerName
            // 
            this.lblLedgerName.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblLedgerName.Appearance.Options.UseFont = true;
            this.lblLedgerName.Appearance.Options.UseTextOptions = true;
            this.lblLedgerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablePanel1.SetColumn(this.lblLedgerName, 1);
            this.tablePanel1.SetColumnSpan(this.lblLedgerName, 5);
            this.lblLedgerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLedgerName.Location = new System.Drawing.Point(13, 13);
            this.lblLedgerName.Name = "lblLedgerName";
            this.tablePanel1.SetRow(this.lblLedgerName, 1);
            this.lblLedgerName.Size = new System.Drawing.Size(835, 22);
            this.lblLedgerName.TabIndex = 0;
            this.lblLedgerName.Text = "labelControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(885, 488);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(885, 488);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(865, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "VOUCHERID";
            this.gridColumn1.FieldName = "VOUCHERID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Voucher Number";
            this.gridColumn2.FieldName = "VOUCHERNUMBER";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Voucher Date";
            this.gridColumn3.FieldName = "VOUCHERDATE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "VOUCHERTYPEID";
            this.gridColumn4.FieldName = "VOUCHERTYPEID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "LEDGERID";
            this.gridColumn5.FieldName = "LEDGERID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ledger name";
            this.gridColumn6.FieldName = "LEDGERNAME";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Voucher Type";
            this.gridColumn7.FieldName = "VOUCHERTYPE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Purpose";
            this.gridColumn8.FieldName = "PURPOSE";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Credit Amount";
            this.gridColumn9.FieldName = "CREDITAMOUNT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Debit Amount";
            this.gridColumn10.FieldName = "DEBITAMOUNT";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Balance";
            this.gridColumn11.FieldName = "RUNNNINGBAL";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            // 
            // ucLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucLedgerReport";
            this.Size = new System.Drawing.Size(885, 488);
            this.Load += new System.EventHandler(this.ucLedgerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblClosingBalance;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblOpeningBalance;
        private DevExpress.XtraEditors.LabelControl lblLedgerName;
        private DevExpress.XtraGrid.GridControl gcVouchers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVouchers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}
