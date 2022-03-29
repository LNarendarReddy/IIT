namespace Entity
{
    public abstract class EntityBase
    {
        public object ID { get; set; }

        public bool IsSave { get; set; }

        public object UserName { get; set; }
    }
}
