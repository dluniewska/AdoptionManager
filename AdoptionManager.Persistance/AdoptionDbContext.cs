using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Animals;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Shipping;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users;
using AdoptionManager.Domain.Entities.Users.Addresses;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Persistance
{
    public class AdoptionDbContext : DbContext
    {
        public AdoptionDbContext(DbContextOptions<AdoptionDbContext> options) : base(options) { }

        //Product (Adoption Offer)
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AdoptionOffer> AdoptionOffers { get; set; }
        public DbSet<AdoptionApplication> ApplicationApplications { get; set; }
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
            modelBuilder.Entity<Animal>(animal =>
            {
                animal.Property(a => a.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<AdoptionOffer>(adoptionOffer =>
            {
                adoptionOffer.Property(ao => ao.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<AdoptionApplication>(adoptionApplication =>
            {
                adoptionApplication.Property(ac => ac.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<AnimalCategory>(animalCategory =>
            {
                animalCategory.Property(ac => ac.Id).UseIdentityColumn();
            });



            modelBuilder.Entity<Organization>(organization =>
            {
                organization.Property(o => o.Id).UseIdentityColumn();
                organization.OwnsOne(o => o.Email).HasIndex(e => new { e.UserName, e.DomainName }).IsUnique();
            });

            modelBuilder.Entity<SiteUser>(siteUser =>
            {
                siteUser.Property(su => su.Id).UseIdentityColumn();
                siteUser.OwnsOne(su => su.Email).HasIndex(e => new { e.UserName, e.DomainName }).IsUnique();
            });



            modelBuilder.Entity<ShippingData>(shipping =>
            {
                shipping.Property(s => s.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<ShippingMethod>(shippingMethod =>
            {
                shippingMethod.Property(sm => sm.Id).UseIdentityColumn();
            });



            modelBuilder.Entity<Survey>(survey =>
            {
                survey.Property(s => s.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<Question>(question =>
            {
                question.Property(q => q.Id).UseIdentityColumn();
            });

            modelBuilder.Entity<Answer>(answer =>
            {
                answer.Property(a => a.Id).UseIdentityColumn();
            });
            modelBuilder.Entity<UserResponse>(userResponse =>
            {
                userResponse.Property(us => us.Id).UseIdentityColumn();
            });


            modelBuilder.SeedData();
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.UtcNow;
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.StatusId = 0; //active
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Inactivated = DateTime.UtcNow;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 1; //inactive
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.UtcNow;
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.StatusId = 0; //active
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Inactivated = DateTime.UtcNow;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 1; //inactive
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.UtcNow;
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.StatusId = 0; //active
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Inactivated = DateTime.UtcNow;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 1; //inactive
                        entry.State = EntityState.Modified;
                        break;
                }
            }

            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.UtcNow;
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.StatusId = 0; //active
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.Modified = DateTime.UtcNow;
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Inactivated = DateTime.UtcNow;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 1; //inactive
                        entry.State = EntityState.Modified;
                        break;
                }
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
