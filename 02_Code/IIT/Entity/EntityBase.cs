namespace Entity
{
    public abstract class EntityBase
    {
        public object ID { get; set; }

        public bool IsSave { get; set; }

        public object UserName { get; set; }

        public bool IsEdit => ID != null && int.TryParse(ID.ToString(), out int id) && id > 0;
    }
}
