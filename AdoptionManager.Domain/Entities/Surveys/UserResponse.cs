using AdoptionManager.Domain.Entities.Users;

namespace AdoptionManager.Domain.Entities.Surveys
{
    public class UserResponse
    {
        public int UserResponseId { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
        public int SiteUserId { get; set; }
        public SiteUser SiteUser { get; set; }
        public bool Accepted { get; set; }
    }
}
