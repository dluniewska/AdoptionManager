namespace AdoptionManager.Domain.Entities.Users.Addressess
{
    public class SiteUserAddress : Address
    {
        public int SiteUserId { get; set; }
        public SiteUser SiteUser { get; set; }
    }
}
