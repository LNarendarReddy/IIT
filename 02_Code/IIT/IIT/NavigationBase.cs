using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace IIT
{
    public class NavigationBase : XtraUserControl
    {
        IEnumerable<ActionText> helpText;
        string caption = string.Empty;
        public virtual NavigationBase PreviousControl { get; set; }

        public virtual IEnumerable<ActionText> HelpText => helpText;

        public virtual string Caption => string.IsNullOrEmpty(caption) ? Name : caption;

        public string Header => PreviousControl != null ? PreviousControl.Header + " > " + Caption : Caption;

        public virtual bool HandlesESC => false;

        public virtual bool ShowQuickOptions => true;

        public NavigationBase(string _caption = "")
        { 
            helpText = new List<ActionText>();
            caption = _caption;

        }
    }
}
