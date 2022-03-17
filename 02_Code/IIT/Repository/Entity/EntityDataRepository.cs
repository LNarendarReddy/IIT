
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
                    entityObj.PersonData.EntityID = entityID;
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
    }
}
