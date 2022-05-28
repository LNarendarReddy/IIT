using System.Collections.Generic;

namespace Entity
{
    public class EntityData : EntityBase
    {
        #region Properties

        public object EntityName { get; set; }

        public object EntityTypeID { get; set; }

        public object NoOfPartners { get; set; }

        public List<Person> PersonData { get; set; }

        public List<GSTRegistrationNumber> GSTRegNo { get; set; }

        public object PANNumber { get; set; }

        public object MobileNumber { get; set; }

        public object OfficeNumber { get; set; }

        public object CompanyNumber { get; set; }
        public object CASHINHANDID { get; set; }

        public object EntitylogoID { get; set; }

        public GSTRegistrationNumber PrimaryGST { get; set; }

        public object SubSectorID { get; set; }

        public Address PermanentAddress { get; set; }

        public Address BusinessAddress { get; set; }

        public object SameAddress { get; set; }

        public object EmailID { get; set; }

        public object FinancialYear { get; set; }

        public object MethodOfAccounting { get; set; }

        public object Currency { get; set; }

        public object ResidentStatus { get; set; }

        public byte[] LogoData { get; set; }

        #endregion

        #region Constructor

        public EntityData()
        {
            PersonData = new List<Person>();
            PermanentAddress = new Address();
            BusinessAddress = new Address();
            GSTRegNo = new List<GSTRegistrationNumber>();
        }

        #endregion
    }
}
