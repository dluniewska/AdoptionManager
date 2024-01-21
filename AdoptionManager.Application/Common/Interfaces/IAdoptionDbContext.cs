using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Shipping;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;
using AdoptionManager.Domain.Entities.Users.Addresses;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Application.Common.Interfaces
{
    public interface IAdoptionDbContext
    {
        //Product (Adoption Offer)
        DbSet<Animal> Animals { get; set; }
        DbSet<AdoptionOffer> AdoptionOffers { get; set; }
        DbSet<AdoptionApplication> AdoptionApplications { get; set; }
        DbSet<AnimalCategory> AnimalCategories { get; set; }

        //Users
        DbSet<Organization> Organizations { get; set; }
        DbSet<SiteUser> SiteUsers { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<SiteUserAddress> SiteUserAddresses { get; set; }
        DbSet<OrganizationAddress> OrganizationAddresses { get; set; }

        //Shipping
        DbSet<ShippingData> Shippings { get; set; }
        DbSet<ShippingMethod> ShippingMethods { get; set; }

        //Survey
        DbSet<Survey> Surveys { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Answer> Answers { get; set; }
        DbSet<UserResponse> UserResponses { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

