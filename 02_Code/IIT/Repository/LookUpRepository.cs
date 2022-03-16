using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class LookUpRepository
    {
        public DataTable GetLookUpData(string category)
        {
            DataTable dtLookUpData = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_GETLOOKUP]";
                    cmd.Parameters.AddWithValue("@Category", category);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtLookUpData);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While getting look up data", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dtLookUpData;
        }
    }
}
