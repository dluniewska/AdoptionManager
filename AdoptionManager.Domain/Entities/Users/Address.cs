using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class Address : AuditableEntity
    {
        public AddressName AddressName { get; set; }
    }
}
