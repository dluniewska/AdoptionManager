using AdoptionManager.Domain.Entities.Users;

namespace AdoptionManager.Domain.Entities.Surveys
{
    public class Survey
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
