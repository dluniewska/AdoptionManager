using AdoptionManager.Domain.Common;

namespace AdoptionManager.Domain.Entities.ValueObjects
{
    public class SiteUserName : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
