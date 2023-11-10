using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Shipping;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;
using AdoptionManager.Domain.Entities.Users.Addresses;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Persistance
{
    public static class Seed
    {
        public static async Task<WebApplication> SeedDatabaseWithTestData(this WebApplication webApp)
        {
            using (var scope = webApp.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<AdoptionDbContext>();
                try
                {
                    var siteUserCharlie = GetSiteUser("Charlie", "Bradbury", null, RoleType.ADMIN, "charlie.b@test.com");
                    var siteUserMilva = GetSiteUser("Milva", "Barring", "000000000", RoleType.ADMIN, "milva.b@test.com");
                    var siteUserSam = GetSiteUser("Sam", "Winchester", "111111111", RoleType.USER, "sam.w@test.com");
                    var siteUserDean = GetSiteUser("Dean", "Winchester", "222222222", RoleType.USER, "dean.w@test.com");
                    var siteUserJack = GetSiteUser("Jack", "Kline", "333333333", RoleType.USER, "jack.k@test.com");

                    var organizationLabResq = GetOrganization("LabResq", "Jedyna w Polsce organizacja zajmująca się adopcją zwierząt laboratoryjnych", null, "labresq.adopcje@gmail.com");
                    var organizationKalipso = GetOrganization("Kalipso", "Organizacja zajmująca się adopcją zwierząt domowych", "777777777", "kalipso@seed.com");

                    var animalRat = GetAnimal("Szczur Wistar", "Szczur", DateOnly.FromDateTime(DateTime.UtcNow.AddMonths(-10)), organizationLabResq);
                    var animalCat = GetAnimal("Ragdoll", "Kot", DateOnly.FromDateTime(DateTime.UtcNow.AddYears(-3)), organizationKalipso);

                    var surveyRats = GetSurvey("Ankieta adopcji szczurów laboratoryjnych", "Szczury laboratoryjne", organizationLabResq);
                    var surveyCats = GetSurvey("Ankieta adopcji kotów", "Koty", organizationKalipso);

                    var organizationLabResqAddress1 = GetOrganizationAddress("Ulica1", "1", "1", "11-111", "Gdańsk", "Polska", false, organizationLabResq);
                    var organizationKalipsoAddress1 = GetOrganizationAddress("Ulica2", "2", "2", "22-222", "Gdynia", "Polska", false, organizationKalipso);

                    var siteUserAddressSam = GetSiteUserAddress("Ulica3", "3", "3", "33-333", "Ciechanowiec", "Polska", false, siteUserSam);
                    var siteUserAddressDean = GetSiteUserAddress("Ulica4", "4", "4", "44-444", "Warszawa", "Polska", false, siteUserDean);

                    var adoptionOfferRat = GetAdoptionOffer(animalRat, organizationLabResqAddress1, 30, surveyRats, organizationLabResq, "Zwierzęta z nadwyżki hodowlanej, lub po nieinwazyjnych testach");
                    var adoptionOfferCat = GetAdoptionOffer(animalCat, organizationKalipsoAddress1, 3, surveyCats, organizationKalipso, "Kocięta");

                    var animalCategoryLab = GetAnimalCategory(null, "Laboratoryjne", siteUserCharlie);
                    var animalCategoryDom= GetAnimalCategory(null, "Domowe", siteUserCharlie);
                    var animalCategoryLabRat = GetAnimalCategory(animalCategoryLab, "Szczury laboratoryjne", siteUserMilva);
                    var animalCategoryRod = GetAnimalCategory(null, "Gryzonie", siteUserMilva);

                    var question1 = GetQuestion("Czy posiadasz już jakies zwierzęta?", surveyRats, organizationLabResq);
                    var question2 = GetQuestion("Gdzie zwierzę będzie przebywało w czasie urlopu/wakacji?", surveyCats, organizationKalipso);
                    var question3 = GetQuestion("Jakie wymiary będzie miała klatka?", surveyRats, organizationLabResq);

                    var userResponseRats = GetUserResponse(surveyRats, siteUserSam);
                    var userResponseCats = GetUserResponse(surveyCats, siteUserDean);

                    var answer1 = GetAnswer(question1, userResponseRats, "Tak, kota", siteUserSam);
                    var answer2 = GetAnswer(question2, userResponseCats, "U rodziców", siteUserDean);
                    var answer3 = GetAnswer(question3, userResponseRats, "Klatka Frodo: długość: 78cm, szerokość: 48cm, wysokość: 80cm. odległość między prętami: 1,3cm", siteUserSam);

                    var shippingMethodClientLabResqRats = GetShippingMethod("Klient odbiera zwierzęta samodzielnie z domu tymczasowego", ShippingType.CLIENT, organizationLabResq);
                    var shippingMethodVolKalipsoCats = GetShippingMethod("Wolontariusz przekazuje zwierzaka klientowi", ShippingType.VOLUNTEER, organizationKalipso);

                    var shippingRats = GetShippingData(siteUserAddressSam, DateTime.UtcNow.AddDays(10), shippingMethodClientLabResqRats, ShipmentStatus.PENDING, organizationLabResq);
                    var shippingCats = GetShippingData(siteUserAddressDean, null, shippingMethodVolKalipsoCats, ShipmentStatus.PROCESSED, organizationKalipso);

                    adoptionOfferRat.AnimalCategories.AddRange(new List<AnimalCategory> { animalCategoryLabRat, animalCategoryRod });
                    adoptionOfferCat.AnimalCategories.Add(animalCategoryDom);

                    if (!context.Animals.Any())
                    {
                        await context.Animals.AddRangeAsync(new List<Animal>() { animalRat, animalCat });
                    }
                    if (!context.Addresses.Any())
                    {
                        await context.OrganizationAddresses.AddRangeAsync(new List<OrganizationAddress> { organizationLabResqAddress1, organizationKalipsoAddress1 });
                        await context.SiteUserAddresses.AddRangeAsync(new List<SiteUserAddress> { });
                    }
                    if (!context.AdoptionOffers.Any())
                    {
                        await context.AdoptionOffers.AddRangeAsync(new List<AdoptionOffer> { adoptionOfferRat, adoptionOfferCat});
                    }
                    if (!context.AdoptionApplications.Any())
                    {
                        await context.AdoptionApplications.AddRangeAsync(new List<AdoptionApplication> { });
                    }
                    if (!context.Organizations.Any())
                    {
                        await context.Organizations.AddRangeAsync(new List<Organization> { organizationLabResq, organizationKalipso });
                    }
                    if (!context.SiteUsers.Any())
                    {
                        await context.SiteUsers.AddRangeAsync(new List<SiteUser>() { siteUserCharlie, siteUserMilva, siteUserJack, siteUserSam, siteUserDean });
                    }
                    if (!context.AnimalCategories.Any())
                    {
                        await context.AnimalCategories.AddRangeAsync(new List<AnimalCategory> { animalCategoryLab, animalCategoryDom, animalCategoryLabRat, animalCategoryRod });
                    }
                    if (!context.UserResponses.Any())
                    {
                        await context.UserResponses.AddRangeAsync(new List<UserResponse> { userResponseRats, userResponseCats });
                    }
                    if (!context.Surveys.Any())
                    {
                        await context.Surveys.AddRangeAsync(new List<Survey> { surveyRats, surveyCats });
                    }
                    if (!context.Questions.Any())
                    {
                        await context.Questions.AddRangeAsync(new List<Question> { question1, question2, question3});
                    }
                    if (!context.Answers.Any())
                    {
                        await context.Answers.AddRangeAsync(new List<Answer> { answer1, answer2, answer3 });
                    }
                    if (!context.ShippingMethods.Any())
                    {
                        await context.ShippingMethods.AddRangeAsync(new List<ShippingMethod> { shippingMethodClientLabResqRats, shippingMethodVolKalipsoCats });
                    }
                    if (!context.Shippings.Any())
                    {
                        await context.Shippings.AddRangeAsync(new List<ShippingData> { shippingRats, shippingCats });
                    }

                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return webApp;
        }


        private static Animal GetAnimal(string name, string species, DateOnly birthDate, Organization organization)
        {
            return new Animal()
            {
                Name = name,
                Species = species,
                BirthDate = birthDate,
                CreatedBy = organization.Email.ToString()
            };
        }

        private static AdoptionOffer GetAdoptionOffer(
            Animal animal,
            OrganizationAddress organizationAddress,
            int quantity,
            Survey survey, 
            Organization organization,
            string description)
        {
            return new AdoptionOffer()
            {
                Animal = animal,
                ResidenceAddress = organizationAddress,
                QuatntityInStock = quantity,
                Survey = survey,
                Organization = organization,
                Description = description,
                CreatedBy = organization.Email.ToString(),
            };
        }

        private static AdoptionApplication GetAdoptionApplication(SiteUser siteUser, ApplicationStatus status, Organization organization, ShippingData shipping, DateTime orderDate)
        {
            return new AdoptionApplication()
            {
                SiteUser = siteUser,
                ApplicationStatus = status,
                Organization = organization,
                Shipping = shipping,
                OrderDate = orderDate,
                CreatedBy = siteUser.Email.ToString()
            };
        }

        private static AnimalCategory GetAnimalCategory(AnimalCategory? animalCategory, string name, SiteUser siteUser)
        {
            return new AnimalCategory()
            {
                ParentCategory = animalCategory,
                CategoryName = name,
                CreatedBy = siteUser.Email.ToString()
            };
        }

        private static Organization GetOrganization(string name, string description, string phone, string email)
        {
            return new Organization()
            {
                Name = name,
                Description = description,
                Phone = phone,
                Email = Email.For(email),
                CreatedBy = "seeder",
                Created = DateTime.UtcNow
            };
        }

        private static SiteUser GetSiteUser(string firstname, string lastname, string? phone, RoleType role, string email)
        {
            return new SiteUser()
            {
                SiteUserName = SiteUserName.For(firstname, lastname),
                Phone = phone,
                Role = role,
                Email = Email.For(email),
                CreatedBy = "seeder",
            };
        }

        private static OrganizationAddress GetOrganizationAddress(string streetName, string buildingNumber, string apartmentNumber, string zipCode, string city, string country, bool isDefault, Organization organization)
        {
            return new OrganizationAddress() 
            {
                IsDefault = isDefault,
                Organization = organization,
                AddressObj = new AddressObj(streetName, buildingNumber, apartmentNumber, zipCode, city, country),
                CreatedBy = organization.Email.ToString()
            };
        }

        private static SiteUserAddress GetSiteUserAddress(string streetName, string buildingNumber, string apartmentNumber, string zipCode, string city, string country, bool isDefault, SiteUser siteUser)
        {
            return new SiteUserAddress()
            {
                IsDefault = isDefault,
                SiteUser = siteUser,
                AddressObj = new AddressObj(streetName, buildingNumber, apartmentNumber, zipCode, city, country),
                CreatedBy = siteUser.Email.ToString()
            };
        }

        private static ShippingData GetShippingData(SiteUserAddress siteUserAddress, DateTime? shipmentDate, ShippingMethod shippingMethod, ShipmentStatus status, Organization organization) 
        {
            return new ShippingData()
            {
                ShipmentAddress = siteUserAddress, //Shipping 1 Address
                ShipmentDate = shipmentDate,
                ShipmentMethod = shippingMethod,
                ShipmentStatus = status,
                CreatedBy = organization.Email.ToString(),
            };
        }

        private static ShippingMethod GetShippingMethod(string description, ShippingType shippingType, Organization organization)
        {
            return new ShippingMethod()
            {
                Description = description,
                ShippingType = shippingType,
                Organization = organization,
                CreatedBy = organization.Email.ToString()
            };
        }

        private static Survey GetSurvey(string description, string title, Organization organization)
        {
            return new Survey()
            {
                Description = description,
                Title = title,
                CreatedBy = organization.Email.ToString()
            };
        }

        private static Question GetQuestion(string text, Survey survey, Organization organization)
        {
            return new Question()
            {
                Text = text,
                Survey = survey,
                CreatedBy = organization.Email.ToString()
            };
        }

        private static Answer GetAnswer(Question question, UserResponse userResponse, string text, SiteUser siteUser)
        {
            return new Answer()
            {
                Question = question,
                UserResponse = userResponse,
                Text = text,
                CreatedBy = siteUser.Email.ToString()
            };
        }

        private static UserResponse GetUserResponse(Survey survey, SiteUser siteUser)
        {
            return new UserResponse()
            {
                Survey = survey,
                SiteUser = siteUser,
                CreatedBy = siteUser.Email.ToString()
            };
        }        
    }
}
