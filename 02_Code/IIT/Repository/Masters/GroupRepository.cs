using Entity;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class GroupRepository : RepositoryBase<Group>
    {
        public override Group Load(DataRow dtGroupRow)
        {
            return new Group()
            {
                ID = dtGroupRow["GROUPID"]
                , Name = dtGroupRow["GROUPNAME"]
                , Description = dtGroupRow["DESCRIPTION"]
                , ClassificationID = dtGroupRow["CLASSIFICATIONID"]
                , Classification = dtGroupRow["CLASSIFICATION"]
            };
        }

        public override Group Save(Group groupObj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_GROUP]";
                    cmd.Parameters.AddWithValue("@ENTITYID", groupObj.EntityID);
                    cmd.Parameters.AddWithValue("@GroupID", groupObj.ID);
                    cmd.Parameters.AddWithValue("@GroupName", groupObj.Name);
                    cmd.Parameters.AddWithValue("@Description", groupObj.Description);
                    cmd.Parameters.AddWithValue("@ClassificationID", groupObj.ClassificationID);
                    cmd.Parameters.AddWithValue("@UserName", groupObj.UserName);
                    object groupIDObj = cmd.ExecuteScalar();

                    if (!int.TryParse(groupIDObj.ToString(), out int groupID))
                    {
                        throw new Exception(groupIDObj.ToString());
                    }

                    groupObj.ID = groupID;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UC_TBLGROUP_GROUPNAME"))
                    throw new Exception("Group Name Alread Exists!");
                else
                    throw new Exception($"Error While saving group : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return groupObj;
        }

        public DataTable GetGroupList(object EntityID)
        {
            DataTable dtGroupList = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_GROUP]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtGroupList);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Group List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dtGroupList;
        }

        public Group GetGroupDetails(object GroupID,object EntityID)
        {
            DataTable dtGroup = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_GROUP]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    cmd.Parameters.AddWithValue("@GROUPID", GroupID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtGroup);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Group Details", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            if (dtGroup.Rows.Count > 0)
                return Load(dtGroup.Rows[0]);
            else
                return null;
        }

    }
}
