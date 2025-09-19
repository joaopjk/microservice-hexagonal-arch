using Domain.Enums;

namespace Domain.Entities
{
    internal class Booking : BaseEntity
    {
        public DateTime PlacedAt { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        private Status Status { get; set; }
        public Status CurrentStatus => Status;
    }
}
