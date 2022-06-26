using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.LedgerType
{
    public class Regular : LedgerTypeBase
    {
        public object GSTRegistrationStatus { get; set; }
        public object GSTNumber { get; set; }
        public object PANNumber { get; set; }
        public object ProvisionalEntryRequired { get; set; }
    }
}
