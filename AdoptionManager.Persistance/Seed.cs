using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Shipping;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            //Product (Adoption Offer)
            modelBuilder.Entity<Animal>(animal =>
            {
                animal.HasData(
                    new Animal()
                    {
                        Id = 1,
                        Name = "Szczur Wistar",
                        Age = 2,
                        AgeUnit = AgeUnit.YEAR,
                        Species = "Szczur"
                    },
                    new Animal()
                    {
                        Id= 2,
                        Name = "Ragdoll",
                        Age = 3,
                        AgeUnit = AgeUnit.YEAR,
                        Species = "Kot"
                    }
                );
            });

            modelBuilder.Entity<AdoptionOffer>(adoptionOffer =>
            {
                adoptionOffer.HasData(
                    new AdoptionOffer()
                    {
                        Id = 1,
                        AnimalId = 1,
                        ResidenceAddressId = 1,
                        QuatntityInStock = 30,
                        SurveyId = 1
                    },
                    new AdoptionOffer()
                    {
                        Id = 2,
                        AnimalId= 2,
                        ResidenceAddressId = 2,
                        QuatntityInStock = 2,
                        SurveyId = 2
                    }
                );
            });

            modelBuilder.Entity<AdoptionApplication>(adoptionApplication =>
            {
                adoptionApplication.HasData(
                    new AdoptionApplication() 
                    {
                        Id = 1,
                        SiteUserId = 1,
                        ShippingAddressId = 3,
                        ApplicationStatus = ApplicationStatus.PENDING,
                        OrganizationId = 1,
                        ShippingMethodId = 1,
                        OrderDate = DateTime.Now,
                    },
                    new AdoptionApplication()
                    {
                        Id = 2,
                        SiteUserId = 2,
                        ShippingAddressId = 4,
                        ApplicationStatus = ApplicationStatus.PROCESSED,
                        OrganizationId = 2,
                        ShippingMethodId = 2,
                        OrderDate = DateTime.Now,
                    }
                );
            });

            modelBuilder.Entity<AnimalCategory>(animalCategory =>
            {
                animalCategory.HasData(
                    new AnimalCategory()
                    {
                        Id = 1,
                        ParentCategoryId = null,
                        CategoryName = "Laboratoryjne"
                    },
                    new AnimalCategory()
                    {
                        Id= 2,
                        ParentCategoryId = null,
                        CategoryName = "Domowe"
                    },
                    new AnimalCategory()
                    {
                        Id = 3,
                        ParentCategoryId = 1,
                        CategoryName = "Szczury laboratoryjne"
                    },
                    new AnimalCategory()
                    {
                        Id = 4, 
                        ParentCategoryId = null,
                        CategoryName = "Gryzonie"
                    }
                );
            });

            modelBuilder.Entity<AdoptionOffer>()
                .HasMany(ao => ao.AnimalCategories)
                .WithMany(ac => ac.AdoptionOffers)
                .UsingEntity(e => e.HasData(
                    new
                    {
                        AdoptionOffers = 1,
                        AnimalCategories = 3
                    },
                    new
                    {
                        AdoptionOffers = 1,
                        AnimalCategories = 4
                    },
                    new
                    {
                        AdoptionOffers = 2,
                        AnimalCategories = 2
                    }
                ));


            //Users
            modelBuilder.Entity<Organization>(organization =>
            {
                organization.HasData(
                    new Organization()
                    {
                        Id = 1,
                        Name = "LabResque",
                        Description = "Jedyna w Polsce organizacja zajmująca się adopcją zwierząt laboratoryjnych",
                        Phone = null
                    },
                    new Organization()
                    {
                        Id= 2,
                        Name = "Kalipso",
                        Description = "Szczury szczurom szczurami"
                    }
                );
                organization.OwnsOne(o => o.Email).HasData(
                    new 
                    { 
                        OrganizationId = 1, 
                        UserName = "lab.rescue.adopcje",
                        Domain = "gmail.com"
                    },
                    new
                    {
                        OrganizationId = 2,
                        UserName = "kalipso",
                        Domain = "rat.com"
                    }
                );
            });

            modelBuilder.Entity<SiteUser>(siteUser =>
            {
                siteUser.
            });

            modelBuilder.Entity<Address>(address =>
            {
                address.HasData(
                    new Address() //Adoption Offer 1 Residency address
                    {
                        Id = 1,
                        IsDefault = false,
                    },
                    new Address() // Adoption Offer 2 Residency address
                    {
                        Id = 2,
                        IsDefault = false,
                    },
                    new Address() // Shipping 1 address
                    {
                        Id = 3,
                        IsDefault = false,
                    },
                    new Address() // Shipping 2 address
                    {
                        Id = 4,
                        IsDefault = false,
                    },
                    new Address() // Organization 1 address
                    {
                        Id = 4,
                        IsDefault = true,
                    },
                    new Address() // Organization 2 address
                    {
                        Id = 4,
                        IsDefault = true,
                    }
                );
            });


            //Shipping
            modelBuilder.Entity<Shipping>(shipping =>
            {
                shipping.
            });

            modelBuilder.Entity<ShippingMethod>(shippingMethod =>
            {
                shippingMethod.
            });


            //Survey
            modelBuilder.Entity<Survey>(survey =>
            {
                survey.
            });

            modelBuilder.Entity<Question>(question =>
            {
                question.
            });

            modelBuilder.Entity<Answer>(answer =>
            {
                answer.
            });
            modelBuilder.Entity<UserResponse>(userResponse =>
            {
                userResponse.
            });
        }
    }
}
