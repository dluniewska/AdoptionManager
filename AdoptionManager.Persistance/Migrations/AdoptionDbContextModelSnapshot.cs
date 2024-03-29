﻿// <auto-generated />
using System;
using AdoptionManager.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AdoptionManager.Persistance.Migrations
{
    [DbContext(typeof(AdoptionDbContext))]
    partial class AdoptionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Animals.AdoptionOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("QuatntityInStock")
                        .HasColumnType("integer");

                    b.Property<int>("ResidenceAddressId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<int>("SurveyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("ResidenceAddressId");

                    b.HasIndex("SurveyId");

                    b.ToTable("AdoptionOffers");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Animals.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Animals.AnimalCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("AnimalCategories");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Product.AdoptionApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("ShippingId")
                        .HasColumnType("integer");

                    b.Property<int>("SiteUserId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("ShippingId");

                    b.HasIndex("SiteUserId");

                    b.ToTable("AdoptionApplications");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Shipping.ShippingData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("ShipmentAddressId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ShipmentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ShipmentMethodId")
                        .HasColumnType("integer");

                    b.Property<int>("ShipmentStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(2);

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ShipmentAddressId");

                    b.HasIndex("ShipmentMethodId");

                    b.ToTable("Shippings");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Shipping.ShippingMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("ShippingType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(2);

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ShippingMethods");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<int>("UserResponseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserResponseId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<int>("SurveyId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.UserResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Accepted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("SiteUserId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<int>("SurveyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SiteUserId");

                    b.HasIndex("SurveyId");

                    b.ToTable("UserResponses");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Addresses.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Address");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<int?>("KRS")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<int?>("NIP")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int?>("REGON")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.SiteUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(2);

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SiteUsers");
                });

            modelBuilder.Entity("AdoptionOfferAnimalCategory", b =>
                {
                    b.Property<int>("AdoptionOffersId")
                        .HasColumnType("integer");

                    b.Property<int>("AnimalCategoriesId")
                        .HasColumnType("integer");

                    b.HasKey("AdoptionOffersId", "AnimalCategoriesId");

                    b.HasIndex("AnimalCategoriesId");

                    b.ToTable("AdoptionOfferAnimalCategory");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Addresses.OrganizationAddress", b =>
                {
                    b.HasBaseType("AdoptionManager.Domain.Entities.Users.Addresses.Address");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("integer");

                    b.HasIndex("OrganizationId");

                    b.HasDiscriminator().HasValue("OrganizationAddress");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Addresses.SiteUserAddress", b =>
                {
                    b.HasBaseType("AdoptionManager.Domain.Entities.Users.Addresses.Address");

                    b.Property<int>("SiteUserId")
                        .HasColumnType("integer");

                    b.HasIndex("SiteUserId");

                    b.HasDiscriminator().HasValue("SiteUserAddress");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Animals.AdoptionOffer", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Animals.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Users.Organization", "Organization")
                        .WithMany("AdoptionOffers")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Users.Addresses.OrganizationAddress", "ResidenceAddress")
                        .WithMany()
                        .HasForeignKey("ResidenceAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Surveys.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Organization");

                    b.Navigation("ResidenceAddress");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Animals.AnimalCategory", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Animals.AnimalCategory", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Product.AdoptionApplication", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Users.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Shipping.ShippingData", "Shipping")
                        .WithMany()
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Users.SiteUser", "SiteUser")
                        .WithMany("AdoptionApplications")
                        .HasForeignKey("SiteUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("Shipping");

                    b.Navigation("SiteUser");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Shipping.ShippingData", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Users.Addresses.SiteUserAddress", "ShipmentAddress")
                        .WithMany()
                        .HasForeignKey("ShipmentAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Shipping.ShippingMethod", "ShipmentMethod")
                        .WithMany()
                        .HasForeignKey("ShipmentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShipmentAddress");

                    b.Navigation("ShipmentMethod");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Shipping.ShippingMethod", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Users.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.Answer", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Surveys.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Surveys.UserResponse", "UserResponse")
                        .WithMany("UserAnswers")
                        .HasForeignKey("UserResponseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("UserResponse");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.Question", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Surveys.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.UserResponse", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Users.SiteUser", "SiteUser")
                        .WithMany("UserResponses")
                        .HasForeignKey("SiteUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Surveys.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiteUser");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Addresses.Address", b =>
                {
                    b.OwnsOne("AdoptionManager.Domain.ValueObjects.AddressObj", "AddressObj", b1 =>
                        {
                            b1.Property<int>("AddressId")
                                .HasColumnType("integer");

                            b1.Property<string>("ApartmentNumber")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("BuildingNumber")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("StreetName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("AddressId");

                            b1.ToTable("Addresses");

                            b1.WithOwner()
                                .HasForeignKey("AddressId");
                        });

                    b.Navigation("AddressObj")
                        .IsRequired();
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Organization", b =>
                {
                    b.OwnsOne("AdoptionManager.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("OrganizationId")
                                .HasColumnType("integer");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("OrganizationId");

                            b1.HasIndex("UserName", "DomainName")
                                .IsUnique();

                            b1.ToTable("Organizations");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationId");
                        });

                    b.Navigation("Email")
                        .IsRequired();
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.SiteUser", b =>
                {
                    b.OwnsOne("AdoptionManager.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("SiteUserId")
                                .HasColumnType("integer");

                            b1.Property<string>("DomainName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("UserName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("SiteUserId");

                            b1.HasIndex("UserName", "DomainName")
                                .IsUnique();

                            b1.ToTable("SiteUsers");

                            b1.WithOwner()
                                .HasForeignKey("SiteUserId");
                        });

                    b.OwnsOne("AdoptionManager.Domain.ValueObjects.SiteUserName", "SiteUserName", b1 =>
                        {
                            b1.Property<int>("SiteUserId")
                                .HasColumnType("integer");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("SiteUserId");

                            b1.ToTable("SiteUsers");

                            b1.WithOwner()
                                .HasForeignKey("SiteUserId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("SiteUserName")
                        .IsRequired();
                });

            modelBuilder.Entity("AdoptionOfferAnimalCategory", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Animals.AdoptionOffer", null)
                        .WithMany()
                        .HasForeignKey("AdoptionOffersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdoptionManager.Domain.Entities.Animals.AnimalCategory", null)
                        .WithMany()
                        .HasForeignKey("AnimalCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Addresses.OrganizationAddress", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Users.Organization", "Organization")
                        .WithMany("OrganizationAddresses")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Addresses.SiteUserAddress", b =>
                {
                    b.HasOne("AdoptionManager.Domain.Entities.Users.SiteUser", "SiteUser")
                        .WithMany("SiteUserAddresses")
                        .HasForeignKey("SiteUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiteUser");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.Survey", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Surveys.UserResponse", b =>
                {
                    b.Navigation("UserAnswers");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.Organization", b =>
                {
                    b.Navigation("AdoptionOffers");

                    b.Navigation("OrganizationAddresses");
                });

            modelBuilder.Entity("AdoptionManager.Domain.Entities.Users.SiteUser", b =>
                {
                    b.Navigation("AdoptionApplications");

                    b.Navigation("SiteUserAddresses");

                    b.Navigation("UserResponses");
                });
#pragma warning restore 612, 618
        }
    }
}
