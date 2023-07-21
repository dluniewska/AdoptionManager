using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;

namespace AdoptionManager.Domain.Entities.Animals
{
    public class AdoptionOffer : AuditableEntity
    {
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int ResidenceAddressId { get; set; }
        public Address ResidenceAddress { get; set; }

        public int QuatntityInStock { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public ICollection<AnimalCategory> AnimalCategories { get; set; } = new List<AnimalCategory>();
    }
}
