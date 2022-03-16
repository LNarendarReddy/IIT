namespace Entity
{
    public class Person
    {
        public object PersonID { get; set; }

        public object PersonName { get; set; }

        public object FatherName { get; set; }

        public object PANNumber { get; set; }

        public object AadharNumber { get; set; }

        public object MobileNumber { get; set; }

        public object OfficeNumber { get; set; }

        public Address PermanentAddress { get; set; }

        public Address BusinessAddress { get; set; }

        public object EmailID { get; set; }

        public object FinancialYear { get; set; }

        public object MethodOfAccounting { get; set; }

        public object Currency { get; set; }

        public object ResidentState { get; set; }

        public object EntityID { get; set; }

        public object DINNo { get; set; }

        public object IsAuthorizedSignatory { get; set; }

        public object PercentageShares { get; set; }

        public object NoOfShares { get; set; }

        public GSTRegistrationNumber PrimaryGST { get; set; }

        public Person()
        {
            PermanentAddress = new Address();
            BusinessAddress = new Address();
            PrimaryGST = new GSTRegistrationNumber();
        }
    }
}
