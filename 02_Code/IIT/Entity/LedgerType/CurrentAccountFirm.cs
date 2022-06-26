using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.LedgerType
{
    public class CurrentAccountFirm : LedgerTypeBase
    {
        public object NameofthePartner { get; set; }
        public object RecieptforAdditions { get; set; }
        public object Remuneration { get; set; }
        public object ShareofProfit { get; set; }
        public object Drawings { get; set; }
        public object InterestonCaptital { get; set; }
        public object OthersifAny { get; set; }
    }
}
