using Entity;
using Repository.Utility;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class LedgerRepository : RepositoryBase<Ledger>
    {
        public override Ledger Load(DataRow drLedgerRow, object EntityTypeID)
        {
            return new Ledger()
            {
                ID = drLedgerRow["LEDGERID"],
                Name = drLedgerRow["LEDGERNAME"],
                Description = drLedgerRow["LEDGERDESCRIPTION"],
                SubGroupID = drLedgerRow["SUBGROUPID"],
                SubGroupName = drLedgerRow["SUBGROUPNAME"],
                GroupID = drLedgerRow["GROUPID"],
                GroupName = drLedgerRow["GROUPNAME"],
                ClassificationID = drLedgerRow["CLASSIFICATIONID"],
                Classification = drLedgerRow["CLASSIFICATION"],
                LedgerTypeID = drLedgerRow["LEDGERTYPEID"],
                LedgerTypeInfo = ObjectFactory.GetLedgerType(drLedgerRow["LEDGERTYPEID"],
                drLedgerRow["LEDGERTYPEINFO"], EntityTypeID)
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
                    cmd.Parameters.AddWithValue("@LedgerTypeID", ledgerObj.LedgerTypeID);
                    cmd.Parameters.AddWithValue("@LedgerTypeInfo", ledgerObj.LedgerTypeInfo.SerializeXml());
                    cmd.Parameters.AddWithValue("@OpeningBalance", ledgerObj.LedgerTypeInfo?.OpeningBalance);
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
                if (ex.Message.Contains("UC_TBLLEDGER_LEDGERNAME"))
                    throw new Exception("Ledger Already Exists!");
                else
                    throw new Exception($"Error While saving Ledger : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return ledgerObj;
        }
        public DataTable GetLedgerData(object HeadID,object EntityID)
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
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
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
        public Ledger GetLedger(object LedgerID,object EntityID,object EntityTypeID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_LEDGER]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
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
                return Load(dt.Rows[0], EntityTypeID);
            else
                return null;
        }
        public DataTable GetLedgerList(object EntityID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_LEDGER]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Ledger List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dt;
        }
        public string GetAvailableBalance(object LedgerID)
        {
            string obj = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_AVAILABLEBALANCE]";
                    cmd.Parameters.AddWithValue("@LEDGERID", LedgerID);
                    obj = Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving available balance", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return obj;
        }
    }
}
