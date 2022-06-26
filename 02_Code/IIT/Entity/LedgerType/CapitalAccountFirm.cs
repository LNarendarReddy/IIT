using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.LedgerType
{
    public class CapitalAccountFirm : LedgerTypeBase
    {
        public object CapitalShare { get; set; }
        public object CurrentAccountInBooks { get; set; }
        public object RecieptForAdditions { get; set; }
        public object Remuneration { get; set; }
        public object ShareofProfit { get; set; }
        public object Drawings { get; set; }
        public object InterestonCapital { get; set; }
        public object Othersifany { get; set; }
    }
}
