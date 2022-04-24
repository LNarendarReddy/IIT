using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class SectorRepository : RepositoryBase<Sector>
    {
        public override Sector Load(DataRow dtSectorRow)
        {
            return new Sector()
            {
                ID = dtSectorRow["SECTORID"],
                Name = dtSectorRow["SECTORNAME"],
                Description = dtSectorRow["DESCRIPTION"]
            };
        }

        public override Sector Save(Sector sectorObj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_SECTOR]";
                    cmd.Parameters.AddWithValue("@SectorID", sectorObj.ID);
                    cmd.Parameters.AddWithValue("@SectorName", sectorObj.Name);
                    cmd.Parameters.AddWithValue("@Description", sectorObj.Description);
                    cmd.Parameters.AddWithValue("@UserName", sectorObj.UserName);
                    object sectorIDObj = cmd.ExecuteScalar();

                    if (!int.TryParse(sectorIDObj.ToString(), out int sectorID))
                    {
                        throw new Exception(sectorIDObj.ToString());
                    }

                    sectorObj.ID = sectorID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While saving sector : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return sectorObj;
        }

        public DataTable GetSectorList()
        {
            DataTable dtSectorList = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_SECTORLIST]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtSectorList);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving sector List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dtSectorList;
        }
    }
}
