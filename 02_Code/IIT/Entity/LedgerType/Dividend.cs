using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.LedgerType
{
    public class Dividend : LedgerTypeBase
    {
        public object NameofCompany { get; set; }
        public object isDividendRecievedFromIndia { get; set; }
    }
}
