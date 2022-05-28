using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Repository
{
    public class EntityDataRepository : RepositoryBase<EntityData>
    {
        AddressRepository addressRepository = new AddressRepository();
        PersonRepository personRepository = new PersonRepository();
        GSTRepository gstRepository = new GSTRepository();
        public override List<EntityData> Load(DataTable dtEntityTable)
        {
            List<EntityData> entities = new List<EntityData>();
            foreach (DataRow drEntity in dtEntityTable.Rows)
            {
                EntityData entityData = new EntityData
                {
                    ID = drEntity["ENTITYID"],
                    EntityName = drEntity["ENTITYNAME"],
                    EntityTypeID = drEntity["ENTITYTYPEID"],
                    PANNumber = drEntity["PANNUMBER"],
                    NoOfPartners = drEntity["NOOFPARTNERS"],
                    EmailID = drEntity["EMAILID"],
                    MobileNumber = drEntity["MOBILENUMBER"],
                    OfficeNumber = drEntity["OFFICENUMBER"],
                    MethodOfAccounting = drEntity["METHODACCID"],
                    Currency = drEntity["CURRENCYID"],
                    ResidentStatus = drEntity["RESIDENTSTATUSID"],
                    //GSTREGNOID = drEntity["GSTREGNOID"],
                    SameAddress = drEntity["SameAddress"],
                     SubSectorID = drEntity["SUBSECTORID"],
                    CompanyNumber = drEntity["CompanyNumber"],
                    CASHINHANDID = drEntity["CASHINHANDID"],
                    EntitylogoID = drEntity["ENTITYLOGOID"],
                    LogoData = drEntity["LOGODATA"] != DBNull.Value ? (byte[])drEntity["LOGODATA"] : new byte[0]
                };

                entities.Add(entityData);
            }

            return entities;
        }

        public override EntityData Save(EntityData entityObj)
        {
            try
            {
                addressRepository.Save(new List<Address> { entityObj.PermanentAddress, entityObj.BusinessAddress });

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_ENTITY]";
                    cmd.Parameters.AddWithValue("@EntityID", entityObj.ID);
                    cmd.Parameters.AddWithValue("@EntityName", entityObj.EntityName);
                    cmd.Parameters.AddWithValue("@EntityTypeID", entityObj.EntityTypeID);
                    cmd.Parameters.AddWithValue("@NoOfPartners", entityObj.NoOfPartners);
                    cmd.Parameters.AddWithValue("@PANNumber", entityObj.PANNumber);
                    cmd.Parameters.AddWithValue("@PermanentAddressID", entityObj.PermanentAddress.ID);
                    cmd.Parameters.AddWithValue("@BusinessAddressID", entityObj.BusinessAddress.ID);
                    cmd.Parameters.AddWithValue("@EmailID", entityObj.EmailID);
                    cmd.Parameters.AddWithValue("@MobileNumber", entityObj.MobileNumber);
                    cmd.Parameters.AddWithValue("@OfficeNumber", entityObj.OfficeNumber);
                    cmd.Parameters.AddWithValue("@MethodOfAccountingID", entityObj.MethodOfAccounting);
                    cmd.Parameters.AddWithValue("@CurrencyID", entityObj.Currency);
                    cmd.Parameters.AddWithValue("@ResidentStatusID", entityObj.ResidentStatus);
                    cmd.Parameters.AddWithValue("@SameAddress", entityObj.SameAddress);
                    cmd.Parameters.AddWithValue("@SubSectorID", entityObj.SubSectorID);
                    cmd.Parameters.AddWithValue("@CompanyNumber", entityObj.CompanyNumber);
                    cmd.Parameters.AddWithValue("@UserName", entityObj.UserName);
                    cmd.Parameters.AddWithValue("@LogoData", entityObj.LogoData);
                    object entityIDObj = cmd.ExecuteScalar();

                    if (!int.TryParse(entityIDObj.ToString(), out int entityID))
                    {
                        throw new Exception(entityIDObj.ToString());
                    }

                    entityObj.ID = entityID;
                    entityObj.PersonData.ForEach(x => x.EntityID = entityID);
                    entityObj.GSTRegNo.ForEach(x => x.EntityID = entityID);
                }
                personRepository.Save(entityObj.PersonData);
                gstRepository.Save(entityObj.GSTRegNo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While saving Entity : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return entityObj;
        }

        public DataTable GetEntityList()
        {
            DataTable dtEntityList = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_ENTITYLIST]";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtEntityList);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Enity List", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return dtEntityList;
        }

        public EntityData GetEntityData(object entityID)
        {
            EntityData entityData;
            DataSet dsEntityData = new DataSet();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_ENTITY]";
                    cmd.Parameters.AddWithValue("@EntityID", entityID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsEntityData);
                    }
                }

                dsEntityData.Tables[0].TableName = "ENTITY";
                dsEntityData.Tables[1].TableName = "PERSON";
                dsEntityData.Tables[2].TableName = "ADDRESS";
                dsEntityData.Tables[3].TableName = "GST";

                entityData = LoadFirstRecordOnly(dsEntityData.Tables["ENTITY"]);
                
                entityData.PersonData = personRepository.Load(dsEntityData.Tables["PERSON"]);

                List<Address> addresses = addressRepository.Load(dsEntityData.Tables["ADDRESS"]);
                
                entityData.PermanentAddress = 
                    addresses.FirstOrDefault(x => x.ID.Equals(dsEntityData.Tables["ENTITY"].Rows[0]["PERMANENTADDRESSID"]));
                entityData.BusinessAddress =
                    addresses.FirstOrDefault(x => x.ID.Equals(dsEntityData.Tables["ENTITY"].Rows[0]["BUSINESSADDRESSID"]));

                entityData.GSTRegNo = gstRepository.Load(dsEntityData.Tables["GST"]);

                entityData.PrimaryGST = entityData.GSTRegNo.FirstOrDefault(x=> x.ID.Equals(dsEntityData.Tables["ENTITY"].Rows[0]["GSTREGNOID"]));
               
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving entity details", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return entityData;
        }

        public DataSet GetEntityExportData(object entitydID)
        {
            DataSet dsEntityData = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_R_EXPORTENTITYDATA]";
                    cmd.Parameters.AddWithValue("@EntityID", entitydID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dsEntityData);
                    }

                    dsEntityData.Tables[0].TableName = "ENTITY";
                    dsEntityData.Tables[1].TableName = "PERSON";
                    dsEntityData.Tables[2].TableName = "ADDRESS";
                    dsEntityData.Tables[3].TableName = "GSTIN";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Retrieving Enity Data", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return dsEntityData;
        }

        public string ImportEntityData(DataSet dsEntityData)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_IMP_ENTITYDATA]";
                    cmd.Parameters.AddWithValue("@Entity", dsEntityData.Tables[0]);
                    cmd.Parameters.AddWithValue("@Persons", dsEntityData.Tables[1]);
                    cmd.Parameters.AddWithValue("@Address", dsEntityData.Tables[2]);
                    cmd.Parameters.AddWithValue("@GSTIN", dsEntityData.Tables[3]);
                    object output = cmd.ExecuteScalar();
                    return output?.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error While Importing Enity Data", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
        }

        public byte[] GetEntityLogo(object EntityID)
        {
            byte[] imagedata = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[AMS_R_ENTITYLOGO]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    object obj = cmd.ExecuteScalar();
                    imagedata = (byte[])obj;
                }
            }
            catch (Exception ex) { }
            finally
            {
                SQLCon.Sqlconn().Close();
            }
            return imagedata;
        }

        public void SaveEntityLogo(object EntityID, byte[] LogoData)
        {
            DataSet dsPayment = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_ENTITYLOGO]";
                    cmd.Parameters.AddWithValue("@ENTITYID", EntityID);
                    cmd.Parameters.AddWithValue("@LOGODATA", LogoData);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 0)
                        throw new Exception("Error while saving entity logo");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
