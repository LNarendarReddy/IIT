using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class PersonRepository : RepositoryBase<Person>
    {
        public override List<Person> Load(DataTable dtPersonTable)
        {
            List<Person> people = new List<Person>();
            foreach (DataRow drPerson in dtPersonTable.Rows)
            {
                Person person = new Person
                {
                    ID = drPerson["PERSONID"],
                    PersonName = drPerson["PERSONNAME"],
                    FatherName = drPerson["FATHERNAME"],
                    PANNumber = drPerson["PANNUMBER"],
                    AadharNumber = drPerson["AADHARNUMBER"],
                    EntityID = drPerson["ENTITYID"],
                    DINNo = drPerson["DINNO"],
                    IsAuthorizedSignatory = drPerson["ISAUTHORIZEDSIGNATORY"],
                    PercentageShares = drPerson["PERCENTAGESHARES"],
                    NoOfShares = drPerson["NOOFSHARES"],
                    Address = drPerson["ADDRESSOFPERSON"],
                    UserName = drPerson["CREATEDBY"]
                };

                people.Add(person);
            }

            return people;
        }

        public override Person Save(Person personObj)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_PERSON]";
                    cmd.Parameters.AddWithValue("@PersonID", personObj.ID);
                    cmd.Parameters.AddWithValue("@PersonName", personObj.PersonName);
                    cmd.Parameters.AddWithValue("@FatherName", personObj.FatherName);
                    cmd.Parameters.AddWithValue("@PANNumber", personObj.PANNumber);
                    cmd.Parameters.AddWithValue("@AadharNumber", personObj.AadharNumber);
                    cmd.Parameters.AddWithValue("@EntityID", personObj.EntityID);
                    cmd.Parameters.AddWithValue("@DINNo", personObj.DINNo);
                    cmd.Parameters.AddWithValue("@IsAuthorizedSignatory", personObj.IsAuthorizedSignatory);
                    cmd.Parameters.AddWithValue("@PercentageShares", personObj.PercentageShares);
                    cmd.Parameters.AddWithValue("@NoOfShares", personObj.NoOfShares);
                    cmd.Parameters.AddWithValue("@UserName", personObj.UserName);
                    cmd.Parameters.AddWithValue("@Address", personObj.Address);
                    object personObjID = cmd.ExecuteScalar();

                    if (!int.TryParse(personObjID.ToString(), out int personID))
                    {
                        throw new Exception(personObjID.ToString());
                    }

                    personObj.ID = personID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While saving person : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return personObj;
        }
    }
}
