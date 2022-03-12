using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIT
{
    public static class Utility
    {
        public static void showDialog(XtraForm frm)
        {
            frm.ShowInTaskbar  = false;
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;    
            frm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            frm.IconOptions.ShowIcon = false;
            frm.ShowDialog();
        }
    }
}
