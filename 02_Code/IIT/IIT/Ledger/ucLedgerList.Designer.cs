namespace IIT
{
    partial class ucLedgerList
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
            this.gcLedgerList = new DevExpress.XtraGrid.GridControl();
            this.gvLedgerList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLedgerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLedgerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcLedgerList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(829, 790);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcLedgerList
            // 
            this.gcLedgerList.Location = new System.Drawing.Point(12, 12);
            this.gcLedgerList.MainView = this.gvLedgerList;
            this.gcLedgerList.Name = "gcLedgerList";
            this.gcLedgerList.Size = new System.Drawing.Size(805, 766);
            this.gcLedgerList.TabIndex = 0;
            this.gcLedgerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLedgerList});
            // 
            // gvLedgerList
            // 
            this.gvLedgerList.GridControl = this.gcLedgerList;
            this.gvLedgerList.Name = "gvLedgerList";
            this.gvLedgerList.OptionsFind.AlwaysVisible = true;
            this.gvLedgerList.OptionsFind.ShowFindButton = false;
            this.gvLedgerList.OptionsView.ShowGroupPanel = false;
            this.gvLedgerList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvLedgerList_KeyPress);
            this.gvLedgerList.DoubleClick += new System.EventHandler(this.gvLedgerList_DoubleClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(829, 790);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcLedgerList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(809, 770);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucLedgerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucLedgerList";
            this.Size = new System.Drawing.Size(829, 790);
            this.Load += new System.EventHandler(this.ucLedgerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLedgerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLedgerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcLedgerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLedgerList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
