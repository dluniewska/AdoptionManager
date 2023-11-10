using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Exceptions;

namespace AdoptionManager.Domain.ValueObjects
{
    public class SiteUserName : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static SiteUserName For(string firstname, string lastname)
        {
            var username = new SiteUserName();

            username.FirstName = firstname;
            username.LastName = lastname;

            return username;
        }

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
