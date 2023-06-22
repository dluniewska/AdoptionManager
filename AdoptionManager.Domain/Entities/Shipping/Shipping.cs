using AdoptionManager.Domain.Entities.Users;

namespace AdoptionManager.Domain.Entities.Shipping
{
    public enum ShipmentStatus
    {
        ACCEPTED = 1,
        PENDING = 2,
        PROCESSED = 3,
        COMPLETED = 4,
        CANCELLED = 5
    }

    public class Shipping
    {
        public int ShipmentId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }
        public SiteUserAddress ShipmentAddress { get; set; }
    }
}
