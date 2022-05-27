﻿using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BankingRepository : RepositoryBase<Banking>
    {
        public DataTable GetChequeRegister(object LedgerID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_CHEQUEREGISTER]";
                    cmd.Parameters.AddWithValue("@LEDGERID", LedgerID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving cheque list", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dt;
        }
        public override Banking Save(Banking banking) => throw new NotImplementedException();
        public object Save(DataRow dataRow,string UserName)
        {
            object ChequeRegisterID = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_CHEQUEREGISTER]";
                    cmd.Parameters.AddWithValue("@CHEQUEREGISTERID", dataRow["CHEQUEREGISTERID"]);
                    cmd.Parameters.AddWithValue("@LEDGERID", dataRow["LEDGERID"]);
                    cmd.Parameters.AddWithValue("@CHEQUEBOOKCODE", dataRow["CHEQUEBOOKCODE"]);
                    cmd.Parameters.AddWithValue("@OPENINGCHEQUENO", dataRow["OPENINGCHEQUENO"]);
                    cmd.Parameters.AddWithValue("@CLOSINGCHEQUENO", dataRow["CLOSINGCHEQUENO"]);
                    cmd.Parameters.AddWithValue("@NOOFLEAFS", dataRow["NOOFLEAFS"]);
                    cmd.Parameters.AddWithValue("@USERNAME", UserName);
                    ChequeRegisterID = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While saving group : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return ChequeRegisterID;
        }
        public DataTable GetChequeNumber(object LedgerID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_CHEQUENUMBER]";
                    cmd.Parameters.AddWithValue("@LedgerID", LedgerID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving cheque number", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dt;
        }
        public DataTable GetChequeLog(object LedgerID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_CHEQUELOG]";
                    cmd.Parameters.AddWithValue("@LEDGERID", LedgerID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving cheque log", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dt;
        }
    }
}
