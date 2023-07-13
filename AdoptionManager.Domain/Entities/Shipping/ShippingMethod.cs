using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Shipping
{
    public enum ShippingType
    {
        CLIENT = 1,
        VOLUNTEER = 2,
        DELIVERY = 3
    }

    public class ShippingMethod : AuditableEntity
    {
        public int Name { get; set; }
        public ShippingType ShippingType { get; set; }
        public string Description { get; set; }
    }
}
