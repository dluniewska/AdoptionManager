using AdoptionManager.Domain.Entities.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class Address
    {
        public int AddressId { get; set; }
        public AddressName AddressName { get; set; }
    }
}
