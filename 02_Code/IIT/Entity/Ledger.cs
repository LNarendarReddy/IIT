using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ledger : MasterBase
    {
        public object SubGroupID { get; set; }
        public object SubGroupName { get; set; }
        public object GroupID { get; set; }
        public object GroupName { get; set; }
        public object ClassificationID { get; set; }
        public object Classification { get; set; }
    }
}
