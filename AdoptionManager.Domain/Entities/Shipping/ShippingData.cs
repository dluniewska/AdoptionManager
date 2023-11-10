using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Users.Addresses;

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

    public class ShippingData : AuditableEntity
    {
        public DateTime? ShipmentDate { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }

        public int ShipmentAddressId { get; set; }
        public SiteUserAddress ShipmentAddress { get; set; }

        public int ShipmentMethodId { get; set; }
        public ShippingMethod ShipmentMethod { get; set; }
    }
}
