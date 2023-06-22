using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class SiteUser : AuditableEntity
    {
        public SiteUserName SiteUserName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
