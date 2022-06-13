namespace Entity
{
    public class Person : EntityBase
    {
        public Person()
        {
            IsAuthorizedSignatory = false;
        }

        public object PersonName { get; set; }

        public object FatherName { get; set; }

        public object PANNumber { get; set; }
        
        public object AadharNumber { get; set; }

        public object EntityID { get; set; }

        public object DINNo { get; set; }

        public object IsAuthorizedSignatory { get; set; }

        public object PercentageShares { get; set; }

        public object NoOfShares { get; set; }

        public object Address { get; set; }

    }
}
