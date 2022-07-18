using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.LedgerType
{
    public class Commission : LedgerTypeBase
    {
        public object GSTNumber { get; set; }
        public object PanNumber { get; set; }
        public object NatureOfConsideration { get; set; }

    }
}
