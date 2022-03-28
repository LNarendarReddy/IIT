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
                    AadharNumber = drEntity["AADHARNUMBER"],
                    NoOfPartners = drEntity["NOOFPARTNERS"],
                    EmailID = drEntity["EMAILID"],
                    MobileNumber = drEntity["MOBILENUMBER"],
                    OfficeNumber = drEntity["OFFICENUMBER"],
                    MethodOfAccounting = drEntity["METHODACCID"],
                    Currency = drEntity["CURRENCY"],
                    ResidentStatus = drEntity["RESIDENTSTATUS"],
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
                    object entityIDObj = cmd.ExecuteScalar();

                    if (!int.TryParse(entityIDObj.ToString(), out int entityID))
                    {
                        throw new Exception(entityIDObj.ToString());
                    }

                    entityObj.ID = entityID;
                    entityObj.PersonData.ForEach(x => x.EntityID = entityID);
                }

                personRepository.Save(entityObj.PersonData);
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

                entityData = LoadFirstRecordOnly(dsEntityData.Tables["ENTITY"]);
                
                entityData.PersonData = personRepository.Load(dsEntityData.Tables["PERSON"]);

                List<Address> addresses = addressRepository.Load(dsEntityData.Tables["ADDRESS"]);
                
                entityData.PermanentAddress = 
                    addresses.FirstOrDefault(x => x.ID ==
                        dsEntityData.Tables["ENTITY"].Rows[0]["PERMANENTADDRESSID"]);
                entityData.BusinessAddress =
                    addresses.FirstOrDefault(x => x.ID ==
                        dsEntityData.Tables["ENTITY"].Rows[0]["BUSINESSADDRESSID"]);
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
    }
}
