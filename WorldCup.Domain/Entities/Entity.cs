namespace WorldCup.Domain.Entities
{
    public abstract class Entity
    {
        public int? Id { get; protected set; }

        public DateTime DateCreated { get; protected set; }

        public DateTime? DateUpdated { get; protected set;}

        public bool isDeleted { get; protected set; }

    }
}
