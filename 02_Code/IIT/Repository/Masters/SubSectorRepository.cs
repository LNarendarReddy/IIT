using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class SubSectorRepository : RepositoryBase<SubSector>
    {
        public override SubSector Save(SubSector entityObj)
        {
            throw new NotImplementedException();
        }

        public DataTable GetSubSectorList()
        {
            DataTable dtSectorList = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_SUBSECTORLIST]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtSectorList);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Sub Sector List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dtSectorList;
        }
    }
}
