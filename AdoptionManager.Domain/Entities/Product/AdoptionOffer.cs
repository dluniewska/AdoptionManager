using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Surveys;

namespace AdoptionManager.Domain.Entities.Animals
{
    public class AdoptionOffer : AuditableEntity
    {
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int SKU { get; set; }
        public int QuatntityInStock { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}
