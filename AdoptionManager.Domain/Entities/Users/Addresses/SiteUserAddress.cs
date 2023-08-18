namespace AdoptionManager.Domain.Entities.Users.Addresses
{
    public class SiteUserAddress : Address
    {
        public int SiteUserId { get; set; }
        public SiteUser SiteUser { get; set; }
    }
}
