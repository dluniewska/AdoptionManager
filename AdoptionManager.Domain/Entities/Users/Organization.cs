using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Users
{
    public class Organization : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
