using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IIT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEntity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEntityList obj = new frmEntityList();
            Utility.showDialog(obj);
        }
    }
}
