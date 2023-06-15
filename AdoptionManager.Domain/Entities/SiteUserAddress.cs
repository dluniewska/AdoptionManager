namespace AdoptionManager.Domain.Entities
{
    public class SiteUserAddress
    {
        public int SiteUserAddressId { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public bool IsDefault { get; set; }
    }
}
