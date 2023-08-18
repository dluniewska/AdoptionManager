using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Animals
{
    public class Animal : AuditableEntity
    {
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Species { get; set; }
    }
}
