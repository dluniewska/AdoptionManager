namespace AdoptionManager.Domain.Entities
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Phone { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
