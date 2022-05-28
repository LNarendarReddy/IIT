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
        public void SaveConfig(object FromDate, object Todate, object PurposeVisible)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_CONFIGVALUES]";
                    cmd.Parameters.AddWithValue("@FROMDATE", FromDate);
                    cmd.Parameters.AddWithValue("@TODATE", Todate);
                    cmd.Parameters.AddWithValue("@NARRATIONVISIBLE", PurposeVisible);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while saving config values", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
        }
        public DataTable GetConfig()
        {
            DataTable dtLookUpData = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_CONFIGVALUES]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtLookUpData);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While getting config values", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dtLookUpData;
        }
        public DataTable GetSector()
        {
            DataTable dtSubSector = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_SUBSECTOR]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtSubSector);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While getting sector list", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dtSubSector;
        }
    }
}
