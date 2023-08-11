using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Shipping;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;
using AdoptionManager.Domain.Entities.Users.Addressess;
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
                        Age = 10,
                        AgeUnit = AgeUnit.MONTH,
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
                        SurveyId = 1, 
                        Description = "Zwierzęta z nadwyżki hodowlanej, lub po nieinwazyjnych testach"
                    },
                    new AdoptionOffer()
                    {
                        Id = 2,
                        AnimalId= 2,
                        ResidenceAddressId = 2,
                        QuatntityInStock = 2,
                        SurveyId = 2,
                        Description = "Kociaki znalezione na ulicy"
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
                        ApplicationStatus = ApplicationStatus.PENDING,
                        OrganizationId = 1,
                        ShippingMethodId = 1,
                        OrderDate = DateTime.Now,
                    },
                    new AdoptionApplication()
                    {
                        Id = 2,
                        SiteUserId = 2,
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
                siteUser.HasData(
                    new SiteUser()
                    {
                        Id = 1,
                        Phone = 111111111,
                    },
                    new SiteUser()
                    {
                        Id = 2,
                        Phone = 222222222
                    },
                    new SiteUser()
                    {
                        Id = 3,
                        Phone = 333333333
                    }
                );
                siteUser.OwnsOne(o => o.Email).HasData(
                    new
                    {
                        SiteUserId = 1,
                        UserName = "sam.w",
                        Domain = "test"
                    },
                    new
                    {
                        SiteUserId = 2,
                        UserName = "dean.w",
                        Domain = "test"
                    },
                    new
                    {
                        SiteUserId = 3,
                        UserName = "jack.k",
                        Domain = "test"
                    }
                );
                siteUser.OwnsOne(o => o.SiteUserName).HasData(
                    new
                    {
                        SiteUserId = 1,
                        FirstName = "Sam",
                        LastName = "Winchester"
                    },
                    new
                    {
                        SiteUserId = 2,
                        FirstName = "Dean",
                        LastName = "Winchester"
                    },
                    new
                    {
                        SiteUserId = 3,
                        FirstName = "Jack",
                        LastName = "Kline"
                    }
                );
            });

            modelBuilder.Entity<Address>(address =>
            {
                address.HasData(
                    new OrganizationAddress() //Adoption Offer 1 Residency address
                    {
                        Id = 1,
                        IsDefault = false,
                    },
                    new OrganizationAddress() // Adoption Offer 2 Residency address
                    {
                        Id = 2,
                        IsDefault = false,
                    },
                    new SiteUserAddress() // Shipping 1 address
                    {
                        Id = 3,
                        IsDefault = false,
                    },
                    new SiteUserAddress() // Shipping 2 address
                    {
                        Id = 4,
                        IsDefault = false,
                    },
                    new OrganizationAddress() // Organization 1 address
                    {
                        Id = 5,
                        IsDefault = true,
                    },
                    new OrganizationAddress() // Organization 2 address
                    {
                        Id = 6,
                        IsDefault = true,
                    }
                );
            });


            //Shipping
            modelBuilder.Entity<Shipping>(shipping =>
            {
                shipping.HasData(
                    new Shipping()
                    {
                        Id = 1,
                        ShipmentAddressId = 3, //Shipping 1 Address
                        ShipmentDate = DateTime.UtcNow.AddDays(10),
                        ShipmentMethodId = 1,
                        ShipmentStatus = ShipmentStatus.PENDING,
                    },
                    new Shipping()
                    {
                        Id = 2, 
                        ShipmentAddressId = 4, //Shipping 2 Address
                        ShipmentDate = DateTime.UtcNow.AddDays(15),
                        ShipmentMethodId = 2,
                        ShipmentStatus = ShipmentStatus.PROCESSED
                    }
                );
            });

            modelBuilder.Entity<ShippingMethod>(shippingMethod =>
            {
                shippingMethod.HasData(
                    new ShippingMethod()
                    {
                        Id= 1,
                        Description = "",
                        ShippingType = ShippingType.CLIENT
                    },
                    new ShippingMethod()
                    {
                        Id = 2,
                        Description = "",
                        ShippingType = ShippingType.VOLUNTEER
                    }
                );
            });


            //Survey
            modelBuilder.Entity<Survey>(survey =>
            {
                survey.HasData(
                    new Survey()
                    {
                        Id = 1,
                        Description = "Ankieta adopcji szczurów laboratoryjnych",
                        Title = "Szczury laboratoryjne",
                    },
                    new Survey()
                    {
                        Id = 2,
                        Description = "Ankieta adopcji kotów",
                        Title = "Koty",
                    }
                );
            });

            modelBuilder.Entity<Question>(question =>
            {
                question.HasData(
                    new Question()
                    {
                        Id = 1,
                        Text = "Czy posiadasz już jakies zwierzęta?"
                    },
                    new Question()
                    {
                        Id = 2,
                        Text = "Gdzie zwierzę będzie przebywało w czasie urlopu/wakacji?"
                    },
                    new Question()
                    {
                        Id = 3,
                        Text = "Jakie wymiary będzie miała klatka?"
                    }
                );
            });

            modelBuilder.Entity<Answer>(answer =>
            {
                answer.HasData(
                    new Answer() 
                    {
                        Id = 1,
                        QuestionId = 1,
                        Text = "Tak, kota"
                    },
                    new Answer()
                    {
                        Id = 2,
                        QuestionId = 2,
                        Text = "U rodziców"
                    },
                    new Answer()
                    {
                        Id = 3,
                        QuestionId = 3,
                        Text = "Tak, kota"
                    }
                );
            });
            modelBuilder.Entity<UserResponse>(userResponse =>
            {
                userResponse.HasData(
                    new UserResponse() 
                    {
                        Id = 1,
                        SurveyId = 1,
                        SiteUserId = 1,
                    },
                    new UserResponse()
                    {
                        Id = 2,
                        SurveyId = 2,
                        SiteUserId = 2,
                    }
                );
            });
        }
    }
}
