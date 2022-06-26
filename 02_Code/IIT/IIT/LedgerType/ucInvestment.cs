using DevExpress.XtraEditors;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucInvestment : ucLedgerTypeBase
    {
        public ucInvestment(Ledger ledger,bool callfromEvent,string caption):base(ledger, callfromEvent, caption)
        {
            InitializeComponent();
        }
    }
}
