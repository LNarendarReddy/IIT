using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LedgerRepository : RepositoryBase<Ledger>
    {
        public override Ledger Load(DataRow drLedgerRow)
        {
            return new Ledger()
            {
                ID = drLedgerRow["GROUPID"],
                Name = drLedgerRow["GROUPNAME"],
                Description = drLedgerRow["DESCRIPTION"],
                ClassificationID = drLedgerRow["CLASSIFICATIONID"],
                Classification = drLedgerRow["CLASSIFICATION"]
            };
        }
        public override Ledger Save(Ledger ledgerObj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_LEDGER]";
                    cmd.Parameters.AddWithValue("@LEDGERID", ledgerObj.ID);
                    cmd.Parameters.AddWithValue("@SUBGROUPID", ledgerObj.SubGroupID);
                    cmd.Parameters.AddWithValue("@LEDGERNAME", ledgerObj.Name);
                    cmd.Parameters.AddWithValue("@LEDGERDESCRIPTION", ledgerObj.Description);
                    cmd.Parameters.AddWithValue("@UserName", ledgerObj.UserName);
                    object objReturn = cmd.ExecuteScalar();

                    if (!int.TryParse(objReturn.ToString(), out int LedgerID))
                    {
                        throw new Exception(objReturn.ToString());
                    }

                    ledgerObj.ID = LedgerID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While saving Ledger : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return ledgerObj;
        }
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
        public Ledger GetLedgerDetails(object LedgerID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_LEDGER]";
                    cmd.Parameters.AddWithValue("@LedgerID", LedgerID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Ledger Details", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            if (dt.Rows.Count > 0)
                return Load(dt.Rows[0]);
            else
                return null;
        }
    }
}
