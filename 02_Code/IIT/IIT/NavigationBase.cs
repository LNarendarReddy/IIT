using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace IIT
{
    public class NavigationBase : XtraUserControl
    {

        public virtual NavigationBase PreviousControl { get; set; }

        public virtual List<string> HelpText => new List<string>();

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NavigationBase
            // 
            this.Name = "NavigationBase";
            this.Size = new System.Drawing.Size(953, 670);
            this.ResumeLayout(false);

        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
