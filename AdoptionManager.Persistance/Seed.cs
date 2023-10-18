//using AdoptionManager.Domain.Entities.Animals;
//using AdoptionManager.Domain.Entities.Product;
//using AdoptionManager.Domain.Entities.Shipping;
//using AdoptionManager.Domain.Entities.Surveys;
//using AdoptionManager.Domain.Entities.Users;
//using AdoptionManager.Domain.Entities.Users.Addresses;
//using Microsoft.EntityFrameworkCore;


//misunderstood idea of seed, and actually created seed specific for tests
//leaving to rebuild later for that purpose


//namespace AdoptionManager.Persistance
//{
//    public static class Seed
//    {
//        public static void SeedData(this ModelBuilder modelBuilder)
//        {
//            //Product (Adoption Offer)
//            modelBuilder.Entity<Animal>(animal =>
//            {
//                animal.HasData(
//                    new Animal()
//                    {
//                        Id = 1,
//                        Name = "Szczur Wistar",
//                        Species = "Szczur",
//                        BirthDate = DateOnly.FromDateTime(DateTime.UtcNow.AddMonths(-10)),
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new Animal()
//                    {
//                        Id= 2,
//                        Name = "Ragdoll",
//                        Species = "Kot",
//                        BirthDate = DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-3)),
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });

//            modelBuilder.Entity<AdoptionOffer>(adoptionOffer =>
//            {
//                adoptionOffer.HasData(
//                    new AdoptionOffer()
//                    {
//                        Id = 1,
//                        AnimalId = 1,
//                        ResidenceAddressId = 1,
//                        QuatntityInStock = 30,
//                        SurveyId = 1, 
//                        OrganizationId = 1,
//                        Description = "Zwierzęta z nadwyżki hodowlanej, lub po nieinwazyjnych testach",
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new AdoptionOffer()
//                    {
//                        Id = 2,
//                        AnimalId= 2,
//                        ResidenceAddressId = 2,
//                        QuatntityInStock = 2,
//                        SurveyId = 2,
//                        OrganizationId = 2,
//                        Description = "Koty znalezione na ulicy",
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });

//            modelBuilder.Entity<AdoptionApplication>(adoptionApplication =>
//            {
//                adoptionApplication.HasData(
//                    new AdoptionApplication() 
//                    {   
//                        Id = 1,
//                        SiteUserId = 3,
//                        ApplicationStatus = ApplicationStatus.PENDING,
//                        OrganizationId = 1,
//                        ShippingId = 1,
//                        OrderDate = DateTime.UtcNow,
//                        CreatedBy = "sam.w@test.com",
//                        Created = DateTime.UtcNow,
//                    },
//                    new AdoptionApplication()
//                    {
//                        Id = 2,
//                        SiteUserId = 4,
//                        ApplicationStatus = ApplicationStatus.PROCESSED,
//                        OrganizationId = 2,
//                        ShippingId = 2,
//                        OrderDate = DateTime.UtcNow,
//                        CreatedBy = "dean.w@test.com",
//                        Created = DateTime.UtcNow,
//                    }
//                );
//            });

//            modelBuilder.Entity<AnimalCategory>(animalCategory =>
//            {
//                animalCategory.HasData(
//                    new AnimalCategory()
//                    {
//                        Id = 1,
//                        ParentCategoryId = null,
//                        CategoryName = "Laboratoryjne",
//                        CreatedBy = "charlie.b@test.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new AnimalCategory()
//                    {
//                        Id= 2,
//                        ParentCategoryId = null,
//                        CategoryName = "Domowe",
//                        CreatedBy = "charlie.b@test.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new AnimalCategory()
//                    {
//                        Id = 3,
//                        ParentCategoryId = 1,
//                        CategoryName = "Szczury laboratoryjne",
//                        CreatedBy = "milva.b@test.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new AnimalCategory()
//                    {
//                        Id = 4, 
//                        ParentCategoryId = null,
//                        CategoryName = "Gryzonie",
//                        CreatedBy = "milva.b@test.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });

//            modelBuilder.Entity<AdoptionOffer>()
//                .HasMany(ao => ao.AnimalCategories)
//                .WithMany(ac => ac.AdoptionOffers)
//                .UsingEntity(e => e.HasData(
//                    new
//                    {
//                        AdoptionOffersId = 1,
//                        AnimalCategoriesId = 3
//                    },
//                    new
//                    {
//                        AdoptionOffersId = 1,
//                        AnimalCategoriesId = 4
//                    },
//                    new
//                    {
//                        AdoptionOffersId = 2,
//                        AnimalCategoriesId = 2
//                    }
//                ));


//            //Users
//            modelBuilder.Entity<Organization>(organization =>
//            {
//                organization.HasData(
//                    new Organization()
//                    {
//                        Id = 1,
//                        Name = "LabResque",
//                        Description = "Jedyna w Polsce organizacja zajmująca się adopcją zwierząt laboratoryjnych",
//                        Phone = null,
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow,
//                    },
//                    new Organization()
//                    {
//                        Id= 2,
//                        Name = "Kalipso",
//                        Description = "Organizacja zajmująca się adopcją zwierząt domowych",
//                        Phone = 777777777, 
//                        CreatedBy = "kalipso@seed.com",
//                        Created= DateTime.UtcNow
//                    }
//                );
//                organization.OwnsOne(o => o.Email).HasData(
//                    new 
//                    { 
//                        OrganizationId = 1, 
//                        UserName = "lab.rescue.adopcje",
//                        DomainName = "gmail.com"
//                    },
//                    new
//                    {
//                        OrganizationId = 2,
//                        UserName = "kalipso",
//                        DomainName = "seed.com"
//                    }
//                );
//            });

//            modelBuilder.Entity<SiteUser>(siteUser =>
//            {
//                siteUser.HasData(
//                    new SiteUser()
//                    {
//                        Id = 1,
//                        Phone = null,
//                        Role = RoleType.ADMIN,
//                        CreatedBy = "seeder",
//                        Created = DateTime.UtcNow
//                    },
//                    new SiteUser()
//                    {
//                        Id = 2,
//                        Phone = "000000000",
//                        Role = RoleType.ADMIN,
//                        CreatedBy = "seeder",
//                        Created = DateTime.UtcNow
//                    },
//                    new SiteUser()
//                    {
//                        Id = 3,
//                        Phone = "111111111",
//                        Role = RoleType.USER,
//                        CreatedBy = "sam.w@test.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new SiteUser()
//                    {
//                        Id = 4,
//                        Phone = "222222222",
//                        Role = RoleType.USER,
//                        CreatedBy = "dean.w@test.com",
//                        Created= DateTime.UtcNow
//                    },
//                    new SiteUser()
//                    {
//                        Id = 5,
//                        Phone = "333333333",
//                        Role = RoleType.USER,
//                        CreatedBy = "jack.k@test.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//                siteUser.OwnsOne(o => o.Email).HasData(
//                    new
//                    {
//                        SiteUserId = 1,
//                        UserName = "charlie.b",
//                        DomainName = "test.com"
//                    },
//                    new
//                    {
//                        SiteUserId = 2,
//                        UserName = "milva.b",
//                        DomainName = "test.com"
//                    },
//                    new
//                    {
//                        SiteUserId = 3,
//                        UserName = "sam.w",
//                        DomainName = "test.com"
//                    },
//                    new
//                    {
//                        SiteUserId = 4,
//                        UserName = "dean.w",
//                        DomainName = "test.com"
//                    },
//                    new
//                    {
//                        SiteUserId = 5,
//                        UserName = "jack.k",
//                        DomainName = "test.com"
//                    }
//                );
//                siteUser.OwnsOne(o => o.SiteUserName).HasData(
//                    new
//                    {
//                        SiteUserId = 1,
//                        FirstName = "Charlie",
//                        LastName = "Bradbury"
//                    },
//                    new
//                    {
//                        SiteUserId = 2,
//                        FirstName = "Milva",
//                        LastName = "Barring"
//                    },
//                    new
//                    {
//                        SiteUserId = 3,
//                        FirstName = "Sam",
//                        LastName = "Winchester"
//                    },
//                    new
//                    {
//                        SiteUserId = 4,
//                        FirstName = "Dean",
//                        LastName = "Winchester"
//                    },
//                    new
//                    {
//                        SiteUserId = 5,
//                        FirstName = "Jack",
//                        LastName = "Kline"
//                    }
//                );
//            });

//            modelBuilder.Entity<OrganizationAddress>(address =>
//            {
//                address.HasData(
//                    new OrganizationAddress() //Adoption Offer 1 Residency address
//                    {
//                        Id = 1,
//                        IsDefault = false,
//                        OrganizationId = 1,
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow,
//                    },
//                    new OrganizationAddress() // Adoption Offer 2 Residency address
//                    {
//                        Id = 2,
//                        IsDefault = false,
//                        OrganizationId = 2,
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow,
//                    },
//                    new OrganizationAddress() // Organization 1 address
//                    {
//                        Id = 5,
//                        IsDefault = true,
//                        OrganizationId = 1,
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow,
//                    },
//                    new OrganizationAddress() // Organization 2 address
//                    {
//                        Id = 6,
//                        IsDefault = true,
//                        OrganizationId = 2,
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow,
//                    }
//                );
//                address.OwnsOne(a => a.AddressObj).HasData(
//                    new
//                    {
//                        OrganizationAddressId = 1,
//                        StreetName = "Ulica1",
//                        BuildingNumber = "1",
//                        ApartmentNumber = "1",
//                        ZipCode = "11-111",
//                        City = "Gdańsk",
//                        Country = "Polska",

//                    },
//                    new
//                    {
//                        OrganizationAddressId = 2,
//                        StreetName = "Ulica2",
//                        BuildingNumber = "2",
//                        ApartmentNumber = "2",
//                        ZipCode = "22-222",
//                        City = "Gdynia",
//                        Country = "Polska",

//                    },
//                    new
//                    {
//                        OrganizationAddressId = 5,
//                        StreetName = "Ulica5",
//                        BuildingNumber = "5",
//                        ApartmentNumber = "5",
//                        ZipCode = "55-555",
//                        City = "Sopot",
//                        Country = "Polska",

//                    },
//                    new
//                    {
//                        OrganizationAddressId = 6,
//                        StreetName = "Ulica6",
//                        BuildingNumber = "6",
//                        ApartmentNumber = "6",
//                        ZipCode = "66-666",
//                        City = "Malbork",
//                        Country = "Polska",

//                    }
//                );
//            });

//            modelBuilder.Entity<SiteUserAddress>(address =>
//            {
//                address.HasData(
//                    new SiteUserAddress() // Shipping 1 address
//                    {
//                        Id = 3,
//                        IsDefault = false,
//                        SiteUserId = 3,
//                        CreatedBy = "sam.w@test.com",
//                        Created = DateTime.UtcNow,
//                    },
//                    new SiteUserAddress() // Shipping 2 address
//                    {
//                        Id = 4,
//                        IsDefault = false,
//                        SiteUserId = 4,
//                        CreatedBy = "dean.w@test.com",
//                        Created = DateTime.UtcNow,
//                    }
//                );
//                address.OwnsOne(a => a.AddressObj).HasData(
//                    new
//                    {
//                        SiteUserAddressId = 3,
//                        StreetName = "Ulica3",
//                        BuildingNumber = "3",
//                        ApartmentNumber = "3",
//                        ZipCode = "33-333",
//                        City = "Ciechanowiec",
//                        Country = "Polska",

//                    },
//                    new
//                    {
//                        SiteUserAddressId = 4,
//                        StreetName = "Ulica4",
//                        BuildingNumber = "4",
//                        ApartmentNumber = "4",
//                        ZipCode = "44-444",
//                        City = "Warszawa",
//                        Country = "Polska",

//                    }
//                );
//            });


//            //Shipping
//            modelBuilder.Entity<ShippingData>(shipping =>
//            {
//                shipping.HasData(
//                    new ShippingData()
//                    {
//                        Id = 1,
//                        ShipmentAddressId = 3, //Shipping 1 Address
//                        ShipmentDate = DateTime.UtcNow.AddDays(10),
//                        ShipmentMethodId = 1,
//                        ShipmentStatus = ShipmentStatus.PENDING,
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new ShippingData()
//                    {
//                        Id = 2, 
//                        ShipmentAddressId = 4, //Shipping 2 Address
//                        ShipmentDate = DateTime.UtcNow.AddDays(15),
//                        ShipmentMethodId = 2,
//                        ShipmentStatus = ShipmentStatus.PROCESSED,
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });

//            modelBuilder.Entity<ShippingMethod>(shippingMethod =>
//            {
//                shippingMethod.HasData(
//                    new ShippingMethod()
//                    {
//                        Id= 1,
//                        Description = "Klient odbiera zwierzęta samodzielnie z domu tymczasowego",
//                        ShippingType = ShippingType.CLIENT,
//                        OrganizationId = 1,
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new ShippingMethod()
//                    {
//                        Id = 2,
//                        Description = "Wolontariusz przekazuje zwierzaka klientowi",
//                        ShippingType = ShippingType.VOLUNTEER,
//                        OrganizationId = 2,
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });


//            //Survey
//            modelBuilder.Entity<Survey>(survey =>
//            {
//                survey.HasData(
//                    new Survey()
//                    {
//                        Id = 1,
//                        Description = "Ankieta adopcji szczurów laboratoryjnych",
//                        Title = "Szczury laboratoryjne",
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new Survey()
//                    {
//                        Id = 2,
//                        Description = "Ankieta adopcji kotów",
//                        Title = "Koty",
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });

//            modelBuilder.Entity<Question>(question =>
//            {
//                question.HasData(
//                    new Question()
//                    {
//                        Id = 1,
//                        Text = "Czy posiadasz już jakies zwierzęta?",
//                        SurveyId = 1,
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new Question()
//                    {
//                        Id = 2,
//                        Text = "Gdzie zwierzę będzie przebywało w czasie urlopu/wakacji?",
//                        SurveyId = 2,
//                        CreatedBy = "kalipso@seed.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new Question()
//                    {
//                        Id = 3,
//                        Text = "Jakie wymiary będzie miała klatka?",
//                        SurveyId = 1,
//                        CreatedBy = "lab.rescue.adopcje@gmail.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });

//            modelBuilder.Entity<Answer>(answer =>
//            {
//                answer.HasData(
//                    new Answer() 
//                    {
//                        Id = 1,
//                        QuestionId = 1,
//                        UserResponseId = 1,
//                        Text = "Tak, kota",
//                        CreatedBy = "sam.w@test.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new Answer()
//                    {
//                        Id = 2,
//                        QuestionId = 2,
//                        UserResponseId = 2,
//                        Text = "U rodziców",
//                        CreatedBy = "dean.w@test.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new Answer()
//                    {
//                        Id = 3,
//                        QuestionId = 3,
//                        UserResponseId = 1,
//                        Text = "Klatka Frodo: długość: 78cm, szerokość: 48cm, wysokość: 80cm. odległość między prętami: 1,3cm",
//                        CreatedBy = "sam.w@test.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });
//            modelBuilder.Entity<UserResponse>(userResponse =>
//            {
//                userResponse.HasData(
//                    new UserResponse() 
//                    {
//                        Id = 1,
//                        SurveyId = 1,
//                        SiteUserId = 3,
//                        CreatedBy = "sam.w@test.com",
//                        Created = DateTime.UtcNow
//                    },
//                    new UserResponse()
//                    {
//                        Id = 2,
//                        SurveyId = 2,
//                        SiteUserId = 4,
//                        CreatedBy = "dean.w@test.com",
//                        Created = DateTime.UtcNow
//                    }
//                );
//            });
//        }
//    }
//}
