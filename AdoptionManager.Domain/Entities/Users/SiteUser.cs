using AdoptionManager.Domain.Entities.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class SiteUser
    {
        public int SiteUserId { get; set; }
        public SiteUserName SiteUserName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
    }
}
