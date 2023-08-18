using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.Surveys
{
    public class Question : AuditableEntity
    {
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public string Text { get; set; }
    }
}
