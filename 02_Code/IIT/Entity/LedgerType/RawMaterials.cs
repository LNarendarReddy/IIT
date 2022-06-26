using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.LedgerType
{
    public class RawMaterials : LedgerTypeBase
    {
        public object UnitID { get; set; }
        public object HSNCode { get; set; }
        public object IsGSTApplicable { get; set; }
        public object CGST { get; set; }
        public object SGST { get; set; }
        public object IGST { get; set; }
    }
}
