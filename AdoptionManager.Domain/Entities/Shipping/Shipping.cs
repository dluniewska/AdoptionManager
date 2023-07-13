using AdoptionManager.Domain.Common;
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

    public class Shipping : AuditableEntity
    {
        public DateTime ShipmentDate { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }
        public int ShipmentAddressId { get; set; }
        public Address ShipmentAddress { get; set; }
        public int ShipmentMethodId { get; set; }
        public ShippingMethod ShipmentMethod { get; set; }
    }
}
