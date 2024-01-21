using AdoptionManager.Application.Common.Interfaces;
using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Shipping;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;
using AdoptionManager.Domain.Entities.Users.Addresses;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AdoptionManager.Persistance
{
    public class AdoptionDbContext : DbContext, IAdoptionDbContext
    {
        private readonly IDateTime _dateTime;

        public AdoptionDbContext(DbContextOptions<AdoptionDbContext> options) : base(options) { }

        public AdoptionDbContext(DbContextOptions<AdoptionDbContext> options, IDateTime dateTime) : base(options) 
        {
            _dateTime = dateTime;
        }

        //Product (Adoption Offer)
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AdoptionOffer> AdoptionOffers { get; set; }
        public DbSet<AdoptionApplication> AdoptionApplications { get; set; }
        public DbSet<AnimalCategory> AnimalCategories { get; set; }

        //Users
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<SiteUser> SiteUsers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<SiteUserAddress> SiteUserAddresses { get; set; }
        public DbSet<OrganizationAddress> OrganizationAddresses { get; set; }

        //Shipping
        public DbSet<ShippingData> Shippings { get; set; }
        public DbSet<ShippingMethod> ShippingMethods { get; set; }

        //Survey
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserResponse> UserResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = _dateTime.UtcNow;
                        entry.Entity.CreatedBy = entry.Entity.CreatedBy ?? string.Empty;
                        entry.Entity.StatusId = 0; //active
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = _dateTime.UtcNow;
                        entry.Entity.ModifiedBy = entry.Entity.ModifiedBy ?? string.Empty;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.Modified = _dateTime.UtcNow;
                        entry.Entity.ModifiedBy = entry.Entity.ModifiedBy ?? string.Empty;
                        entry.Entity.Inactivated = _dateTime.UtcNow;
                        entry.Entity.InactivatedBy = entry.Entity.InactivatedBy ?? string.Empty;
                        entry.Entity.StatusId = 1; //inactive
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
