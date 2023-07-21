using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class SiteUser : AuditableEntity
    {
        public SiteUserName SiteUserName { get; set; }
        public Email Email { get; set; }
        public int Phone { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<AdoptionApplication> AdoptionApplications { get; set; } = new List<AdoptionApplication>();
        public List<UserResponse> UserResponses { get; set; } = new List<UserResponse>();
    }
}
