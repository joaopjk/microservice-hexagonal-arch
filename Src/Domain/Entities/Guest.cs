using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Guest : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public PersonId DocumentId { get; set; }
    }
}
