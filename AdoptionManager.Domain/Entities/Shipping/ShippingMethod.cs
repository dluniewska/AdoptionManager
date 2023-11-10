using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Users;

namespace AdoptionManager.Domain.Entities.Shipping
{
    public enum ShippingType
    {
        CLIENT = 1,
        VOLUNTEER = 2,
        DELIVERY = 3,
        OTHER = 4
    }

    public class ShippingMethod : AuditableEntity
    {
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public ShippingType ShippingType { get; set; }
        public string? Description { get; set; }
    }
}
