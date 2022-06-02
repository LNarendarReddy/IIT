using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace IIT
{
    public class NavigationBase : XtraUserControl
    {
        IEnumerable<ActionText> helpText;
        public virtual NavigationBase PreviousControl { get; set; }

        public virtual IEnumerable<ActionText> HelpText => helpText;

        public virtual string Caption => Name;

        public string Header => PreviousControl != null ? PreviousControl.Header + " > " + Caption : Caption;

        public virtual bool HandlesESC => false;

        public NavigationBase()
        { 
            helpText = new List<ActionText>(); 
        }
    }
}
