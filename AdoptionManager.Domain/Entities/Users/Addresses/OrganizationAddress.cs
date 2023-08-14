namespace AdoptionManager.Domain.Entities.Users.Addresses
{
    public class OrganizationAddress : Address
    {
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
