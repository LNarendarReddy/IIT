using Entity;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class VoucherRepository : RepositoryBase<Voucher>
    {
        public override Voucher Load(DataRow dtVoucherRow)
        {
            return new Voucher()
            {
                ID = dtVoucherRow["VOUCHERID"],
                VoucherDate = dtVoucherRow["VOUCHERDATE"],
                VoucherNumber = dtVoucherRow["VOUCHERNUMBER"],
                Amount = dtVoucherRow["AMOUNT"],
                PaymentTo = dtVoucherRow["PAYMENTTO"],
                BankName = dtVoucherRow["BANKNAME"],
                Purpose = dtVoucherRow["PURPOSE"],
                VoucherTypeID = dtVoucherRow["VOUCHERTYPEID"]
            };
        }

        public override Voucher Save(Voucher voucherObj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_VOUCHER]";
                    cmd.Parameters.AddWithValue("@VoucherID", voucherObj.ID);
                    cmd.Parameters.AddWithValue("@VoucherDate", voucherObj.VoucherDate);
                    cmd.Parameters.AddWithValue("@VoucherNumber", voucherObj.VoucherNumber);
                    cmd.Parameters.AddWithValue("@Amount", voucherObj.Amount);
                    cmd.Parameters.AddWithValue("@PaymentTo", voucherObj.PaymentTo);
                    cmd.Parameters.AddWithValue("@BankName", voucherObj.BankName);
                    cmd.Parameters.AddWithValue("@Purpose", voucherObj.Purpose);
                    cmd.Parameters.AddWithValue("@VoucherTypeID", voucherObj.VoucherTypeID);
                    cmd.Parameters.AddWithValue("@UserName", voucherObj.UserName);
                    cmd.Parameters.AddWithValue("@ENTITYID", voucherObj.EntityID);
                    object voucherIDObj = cmd.ExecuteScalar();

                    if (!int.TryParse(voucherIDObj.ToString(), out int voucherID))
                    {
                        throw new Exception(voucherIDObj.ToString());
                    }

                    voucherObj.ID = voucherID;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_VOUCHER_VOUCHERNUMBER"))
                    throw new Exception("Voucher Number Already Exists!");
                else
                    throw new Exception($"Error While saving voucher : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return voucherObj;
        }

        public DataTable GetVoucherList(object EntityID)
        {
            DataTable dtVoucherList = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_VOUCHERLIST]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtVoucherList);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Voucher List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dtVoucherList;
        }

        public DataTable GetLedgerPrinting(object EntityID)
        {
            DataTable dtVoucherList = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_VOUCHERLIST]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtVoucherList);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Voucher List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dtVoucherList;
        }
    }
}
