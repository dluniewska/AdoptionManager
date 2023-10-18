using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.ValueObjects
{
    public class AddressObj : ValueObject
    {
        public string StreetName { get; private set; }
        public string BuildingNumber { get; private set; }
        public string ApartmentNumber { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }

        public AddressObj (string streetName, string buildingNumber, string apartmentNumber, string zipCode, string city, string country)
        {
            StreetName = streetName;
            BuildingNumber = buildingNumber;
            ApartmentNumber = apartmentNumber;
            ZipCode = zipCode;
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
