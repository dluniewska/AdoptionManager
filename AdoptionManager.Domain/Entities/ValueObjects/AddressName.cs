using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.ValueObjects
{
    public class AddressName : ValueObject
    {
        public string StreetName { get; private set; }
        public string BuildingNumber { get; private set; }
        public string ApartmentNumber { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }

        public override string ToString()
        {
            return $"{StreetName} {BuildingNumber}/{ApartmentNumber}, {ZipCode} {City}, {Country}";
        }

        public AddressName(string street, string buildingnumber, string apartmentnumber, string zipcode, string city, string country)
        {
            StreetName = street;
            BuildingNumber = buildingnumber; 
            ApartmentNumber = apartmentnumber;
            ZipCode = zipcode;
            City = city;
            Country = country;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return StreetName;
            yield return BuildingNumber;
            yield return ApartmentNumber;
            yield return ZipCode;
            yield return City;
            yield return Country;
        }
    }
}
