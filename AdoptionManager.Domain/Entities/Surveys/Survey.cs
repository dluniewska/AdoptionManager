using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Users;

namespace AdoptionManager.Domain.Entities.Surveys
{
    public class Survey : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();
    }
}