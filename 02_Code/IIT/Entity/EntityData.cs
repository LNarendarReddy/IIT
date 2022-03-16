namespace Entity
{
    public class EntityData
    {
        #region Properties

        public object EntityID { get; set; }

        public object EntityName { get; set; }

        public object EntityTypeID { get; set; }

        public object NoOfPartners { get; set; }

        public Person PersonData { get; set; }

        #endregion

        #region Constructor

        public EntityData()
        {
            PersonData = new Person();
        }

        #endregion
    }
}
