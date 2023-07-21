using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Surveys
{
    public class Question : AuditableEntity
    {
        public string Text { get; set; }
    }
}
