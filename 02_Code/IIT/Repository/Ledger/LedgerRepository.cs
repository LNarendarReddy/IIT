using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Ledger
{
    public class LedgerRepository
    {
        public DataTable GetLedgerData(object HeadID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_LEDGERDATA]";
                    cmd.Parameters.AddWithValue("@HEADID", HeadID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Ledger Data", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dt;
        }
    }
}
