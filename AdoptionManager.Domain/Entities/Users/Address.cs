using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class Address : AuditableEntity
    {
        public AddressObj AddressName { get; set; }
        public bool IsDefault { get; set; }

    }
}
