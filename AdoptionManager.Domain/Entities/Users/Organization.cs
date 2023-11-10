using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Users.Addresses;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class Organization : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Phone { get; set; }
        public int? NIP { get; set; }
        public int? REGON { get; set; }
        public int? KRS { get; set; }
        public Email Email { get; set; }
        public List<OrganizationAddress> OrganizationAddresses { get; set; } = new List<OrganizationAddress>();
        public List<AdoptionOffer> AdoptionOffers { get; set; } = new List<AdoptionOffer>();
    }
}
