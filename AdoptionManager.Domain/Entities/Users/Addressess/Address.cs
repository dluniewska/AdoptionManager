using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users.Addressess
{
    /// <summary>
    /// Base class to inherit by the Address classes for creating table 
    /// using the TPH inheritance mapping model
    /// </summary>
    public class Address : AuditableEntity
    {
        public AddressObj AddressObj { get; set; }
        public bool IsDefault { get; set; }
    }
}
