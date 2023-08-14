using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Animals
{
    public class Animal : AuditableEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Species { get; set; }
    }
}
