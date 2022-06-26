using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.LedgerType
{
    public class EmployeePaySheet : LedgerTypeBase
    {
        public object JoiningDate { get; set; }
        public object EmployeeCode { get; set; }
        public object PanNo { get; set; }
        public object AadharNo { get; set; }
        public object provisionalEntryRequired { get; set; }
        public object PFNumber { get; set; }
        public object LocationofEmployee { get; set; }
        public object ContactNumber { get; set; }

    }
}
