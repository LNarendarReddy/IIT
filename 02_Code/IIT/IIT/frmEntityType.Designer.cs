namespace IIT
{
    partial class frmEntityType
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAOP = new DevExpress.XtraEditors.SimpleButton();
            this.btnCompany = new DevExpress.XtraEditors.SimpleButton();
            this.btnPertnershipFirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnIndividualFirm = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAOP);
            this.layoutControl1.Controls.Add(this.btnCompany);
            this.layoutControl1.Controls.Add(this.btnPertnershipFirm);
            this.layoutControl1.Controls.Add(this.btnIndividualFirm);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(763, 117, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(460, 378);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAOP
            // 
            this.btnAOP.Location = new System.Drawing.Point(110, 205);
            this.btnAOP.Name = "btnAOP";
            this.btnAOP.Size = new System.Drawing.Size(240, 22);
            this.btnAOP.StyleController = this.layoutControl1;
            this.btnAOP.TabIndex = 7;
            this.btnAOP.Text = "AOP / BOI";
            this.btnAOP.Click += new System.EventHandler(this.btnAOP_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(110, 173);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(240, 22);
            this.btnCompany.StyleController = this.layoutControl1;
            this.btnCompany.TabIndex = 6;
            this.btnCompany.Text = "Company";
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnPertnershipFirm
            // 
            this.btnPertnershipFirm.Location = new System.Drawing.Point(110, 141);
            this.btnPertnershipFirm.Name = "btnPertnershipFirm";
            this.btnPertnershipFirm.Size = new System.Drawing.Size(240, 22);
            this.btnPertnershipFirm.StyleController = this.layoutControl1;
            this.btnPertnershipFirm.TabIndex = 5;
            this.btnPertnershipFirm.Text = "Partnership Firm";
            this.btnPertnershipFirm.Click += new System.EventHandler(this.btnPertnershipFirm_Click);
            // 
            // btnIndividualFirm
            // 
            this.btnIndividualFirm.Location = new System.Drawing.Point(110, 109);
            this.btnIndividualFirm.Name = "btnIndividualFirm";
            this.btnIndividualFirm.Size = new System.Drawing.Size(240, 22);
            this.btnIndividualFirm.StyleController = this.layoutControl1;
            this.btnIndividualFirm.TabIndex = 4;
            this.btnIndividualFirm.Text = "Individual / Proprietor Firm";
            this.btnIndividualFirm.Click += new System.EventHandler(this.btnIndividualFirm_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(460, 378);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnIndividualFirm;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(440, 32);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 222);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(440, 136);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPertnershipFirm;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(440, 32);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCompany;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 158);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(440, 32);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAOP;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 190);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(440, 32);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(440, 94);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmEntityType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 378);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "frmEntityType";
            this.Text = "Entity Type";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntityType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAOP;
        private DevExpress.XtraEditors.SimpleButton btnCompany;
        private DevExpress.XtraEditors.SimpleButton btnPertnershipFirm;
        private DevExpress.XtraEditors.SimpleButton btnIndividualFirm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}