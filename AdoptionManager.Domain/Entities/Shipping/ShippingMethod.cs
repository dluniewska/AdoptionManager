using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Shipping
{
    public class ShippingMethod : AuditableEntity
    {
        public int Name { get; set; }
    }
}
