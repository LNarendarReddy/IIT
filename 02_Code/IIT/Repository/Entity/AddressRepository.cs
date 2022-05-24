using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class AddressRepository : RepositoryBase<Address>
    {
        public override List<Address> Load(DataTable dtAddress)
        {
            List<Address> addresses = new List<Address>();
            foreach(DataRow drAddress in dtAddress.Rows)
            {
                Address address = new Address
                {
                    ID = drAddress["ADDRESSID"],
                    HNo = drAddress["HNO"],
                    Area = drAddress["AREA"],
                    City = drAddress["CITY"],
                    District = drAddress["DISTRICT"],
                    PinCode = drAddress["PINCODE"],
                    StateID = drAddress["STATEID"],
                    UserName = drAddress["CREATEDBY"]
                };

                addresses.Add(address);
            }

            return addresses;
        }

        public override Address Save(Address address)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = SQLCon.Sqlconn();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[USP_CU_ADDRESS]";
                    cmd.Parameters.AddWithValue("@AddressID", address.ID);
                    cmd.Parameters.AddWithValue("@HNo", address.HNo);
                    cmd.Parameters.AddWithValue("@Area", address.Area);
                    cmd.Parameters.AddWithValue("@City", address.City);
                    cmd.Parameters.AddWithValue("@District", address.District);
                    cmd.Parameters.AddWithValue("@StateID", address.StateID);
                    cmd.Parameters.AddWithValue("@PinCode", address.PinCode);
                    cmd.Parameters.AddWithValue("@UserName", address.UserName);
                    object addressIDObj = cmd.ExecuteScalar();

                    if(!int.TryParse(addressIDObj.ToString(), out int addressID))
                    {
                        throw new Exception(addressIDObj.ToString());
                    }

                    address.ID = addressID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error While saving address : {ex.Message} ", ex);
            }
            finally
            {
                SQLCon.Sqlconn().Close();
            }

            return address;
        }
    }
}
