namespace AdoptionManager.Domain.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
