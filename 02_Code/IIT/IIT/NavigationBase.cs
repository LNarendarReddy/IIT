using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace IIT
{
    public class NavigationBase : XtraUserControl
    {
        public virtual NavigationBase PreviousControl { get; set; }

        public virtual List<string> HelpText => new List<string>();
    }
}
