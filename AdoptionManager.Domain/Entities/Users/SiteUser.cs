using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users.Addresses;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public enum RoleType
    {
        ADMIN = 1,
        USER = 2
    }

    public class SiteUser : AuditableEntity
    {
        public SiteUserName SiteUserName { get; set; }
        public Email Email { get; set; }
        public string? Phone { get; set; }
        public RoleType Role { get; set; }
        public List<SiteUserAddress> SiteUserAddresses { get; set; } = new List<SiteUserAddress>();
        public List<AdoptionApplication> AdoptionApplications { get; set; } = new List<AdoptionApplication>();
        public List<UserResponse> UserResponses { get; set; } = new List<UserResponse>();
    }
}
