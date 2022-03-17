namespace Entity
{
    public class EntityData : EntityBase
    {
        #region Properties

        public object EntityName { get; set; }

        public object EntityTypeID { get; set; }

        public object NoOfPartners { get; set; }

        public Person PersonData { get; set; }

        public object AadharNumber { get; set; }

        public object PANNumber { get; set; }

        public object MobileNumber { get; set; }

        public object OfficeNumber { get; set; }

        public Address PermanentAddress { get; set; }

        public Address BusinessAddress { get; set; }

        public object EmailID { get; set; }

        public object FinancialYear { get; set; }

        public object MethodOfAccounting { get; set; }

        public object Currency { get; set; }

        public object ResidentStatus { get; set; }

        #endregion

        #region Constructor

        public EntityData()
        {
            PersonData = new Person();
            PermanentAddress = new Address();
            BusinessAddress = new Address();
        }

        #endregion
    }
}
