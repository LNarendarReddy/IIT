using Entity;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;

namespace Repository
{
    public class SubGroupRepository : RepositoryBase<SubGroup>
    {
        public override SubGroup Load(DataRow dtSubGroupRow)
        {
            return new SubGroup()
            {
                ID = dtSubGroupRow["SUBGROUPID"]
                , Name = dtSubGroupRow["SUBGROUPNAME"]
                , Description = dtSubGroupRow["DESCRIPTION"]
                , GroupID = dtSubGroupRow["GROUPID"]
                , ClassificationID = dtSubGroupRow["CLASSIFICATIONID"]
            };
        }

        public override SubGroup Save(SubGroup subGroupObj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_SUBGROUP]";
                    cmd.Parameters.AddWithValue("@SubGroupID", subGroupObj.ID);
                    cmd.Parameters.AddWithValue("@SubGroupName", subGroupObj.Name);
                    cmd.Parameters.AddWithValue("@Description", subGroupObj.Description);
                    cmd.Parameters.AddWithValue("@GroupID", subGroupObj.GroupID);
                    cmd.Parameters.AddWithValue("@UserName", subGroupObj.UserName);
                    object subGroupIDObj = cmd.ExecuteScalar();

                    if (!int.TryParse(subGroupIDObj.ToString(), out int subGroupID))
                    {
                        throw new Exception(subGroupIDObj.ToString());
                    }

                    subGroupObj.ID = subGroupID;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_SUBGROUP_SUBGROUPNAME"))
                    throw new Exception("Sub group already exists!");
                else
                    throw new Exception($"Error While saving sub group : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return subGroupObj;
        }

        public DataTable GetSubGroupList(object EntityID)
        {
            DataTable dtGroupList = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_SUBGROUP]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtGroupList);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Sub Group List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dtGroupList;
        }

        public SubGroup GetSubGroupDetails(object SubGroupID,object EntityID)
        {
            DataTable dtSubGroup = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_SUBGROUP]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    cmd.Parameters.AddWithValue("@SUBGROUPID", SubGroupID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtSubGroup);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Sub Group Details", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            if (dtSubGroup.Rows.Count > 0)
                return Load(dtSubGroup.Rows[0]);
            else
                return null;
        }
    }
}
