using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Animals
{
    public class Animal : AuditableEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
