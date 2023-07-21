using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Animals
{
    public enum AgeUnit
    {
        MONTH = 1,
        YEAR = 2
    }

    public class Animal : AuditableEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public AgeUnit AgeUnit { get; set; }
        public string Species { get; set; }
    }
}
