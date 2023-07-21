using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class Organization : AuditableEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int? Phone { get; set; }
        public Email Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<AdoptionOffer> AdoptionOffers { get; set; } = new List<AdoptionOffer>();
    }
}
