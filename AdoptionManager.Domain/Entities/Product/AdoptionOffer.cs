using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;
using AdoptionManager.Domain.Entities.Users.Addresses;

namespace AdoptionManager.Domain.Entities.Animals
{
    public class AdoptionOffer : AuditableEntity
    {
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int ResidenceAddressId { get; set; }
        public OrganizationAddress ResidenceAddress { get; set; }

        public int QuatntityInStock { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public string Description { get; set; }

        public List<AnimalCategory> AnimalCategories { get; set; } = new List<AnimalCategory>();
    }
}
