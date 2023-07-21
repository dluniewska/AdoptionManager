using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Animals
{
    public class AnimalCategory : AuditableEntity
    {
        public int? ParentCategoryId { get; set; }
        public AnimalCategory ParentCategory { get; set; }
        public string CategoryName { get; set; }
        public ICollection<AdoptionOffer> AdoptionOffers { get; set; } = new List<AdoptionOffer>();
    }
}
