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
    public class GSTRepository : RepositoryBase<GSTRegistrationNumber>
    {
        public override List<GSTRegistrationNumber> Load(DataTable dtGST)
        {
            List<GSTRegistrationNumber> GSTs = new List<GSTRegistrationNumber>();
            foreach (DataRow drGST in dtGST.Rows)
            {
                GSTRegistrationNumber gst = new GSTRegistrationNumber
                {
                    ID = drGST["GSTREGNOID"],
                    StateID = drGST["STATEID"],
                    GSTNo = drGST["GSTNO"],
                    EntityID = drGST["ENTITYID"],
                    StateName = drGST["STATENAME"],
                    UserName = drGST["CREATEDBY"]
                };

                GSTs.Add(gst);
            }

            return GSTs;
        }

        public override GSTRegistrationNumber Save(GSTRegistrationNumber gst)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_GST]";
                    cmd.Parameters.AddWithValue("@GSTREGNOID", gst.ID);
                    cmd.Parameters.AddWithValue("@ENTITYID", gst.EntityID);
                    cmd.Parameters.AddWithValue("@STATEID", gst.StateID);
                    cmd.Parameters.AddWithValue("@GSTNO", gst.GSTNo);
                    cmd.Parameters.AddWithValue("@UserName", gst.UserName);
                    object gstIDObj = cmd.ExecuteScalar();

                    if (!int.TryParse(gstIDObj.ToString(), out int gstID))
                    {
                        throw new Exception(gstIDObj.ToString());
                    }

                    gst.ID = gstID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While saving gst : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return gst;
        }

        public void UpdateGSTNumber(object EntityID,  object GSTRegNoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_U_GSTREGNO]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    cmd.Parameters.AddWithValue("@GSTREGNOID", GSTRegNoID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Updating GST Number", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
        }
    }
}
