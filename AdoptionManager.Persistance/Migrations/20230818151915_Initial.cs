using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdoptionManager.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: true),
                    CategoryName = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalCategories_AnimalCategories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "AnimalCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Species = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<int>(type: "integer", nullable: true),
                    NIP = table.Column<int>(type: "integer", nullable: true),
                    REGON = table.Column<int>(type: "integer", nullable: true),
                    KRS = table.Column<int>(type: "integer", nullable: true),
                    Email_UserName = table.Column<string>(type: "text", nullable: false),
                    Email_DomainName = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SiteUserName_FirstName = table.Column<string>(type: "text", nullable: false),
                    SiteUserName_LastName = table.Column<string>(type: "text", nullable: false),
                    Email_UserName = table.Column<string>(type: "text", nullable: false),
                    Email_DomainName = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<int>(type: "integer", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    ShippingType = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingMethods_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: true),
                    AddressObj_StreetName = table.Column<string>(type: "text", nullable: true),
                    AddressObj_BuildingNumber = table.Column<string>(type: "text", nullable: true),
                    AddressObj_ApartmentNumber = table.Column<string>(type: "text", nullable: true),
                    AddressObj_ZipCode = table.Column<string>(type: "text", nullable: true),
                    AddressObj_City = table.Column<string>(type: "text", nullable: true),
                    AddressObj_Country = table.Column<string>(type: "text", nullable: true),
                    SiteUserId = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_SiteUsers_SiteUserId",
                        column: x => x.SiteUserId,
                        principalTable: "SiteUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SurveyId = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SurveyId = table.Column<int>(type: "integer", nullable: false),
                    SiteUserId = table.Column<int>(type: "integer", nullable: false),
                    Accepted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserResponses_SiteUsers_SiteUserId",
                        column: x => x.SiteUserId,
                        principalTable: "SiteUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserResponses_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnimalId = table.Column<int>(type: "integer", nullable: false),
                    ResidenceAddressId = table.Column<int>(type: "integer", nullable: false),
                    QuatntityInStock = table.Column<int>(type: "integer", nullable: false),
                    SurveyId = table.Column<int>(type: "integer", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdoptionOffers_Addresses_ResidenceAddressId",
                        column: x => x.ResidenceAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdoptionOffers_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdoptionOffers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdoptionOffers_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shippings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShipmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ShipmentStatus = table.Column<int>(type: "integer", nullable: false),
                    ShipmentAddressId = table.Column<int>(type: "integer", nullable: false),
                    ShipmentMethodId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shippings_Addresses_ShipmentAddressId",
                        column: x => x.ShipmentAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shippings_ShippingMethods_ShipmentMethodId",
                        column: x => x.ShipmentMethodId,
                        principalTable: "ShippingMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserResponseId = table.Column<int>(type: "integer", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answers_UserResponses_UserResponseId",
                        column: x => x.UserResponseId,
                        principalTable: "UserResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdoptionOfferAnimalCategory",
                columns: table => new
                {
                    AdoptionOffersId = table.Column<int>(type: "integer", nullable: false),
                    AnimalCategoriesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdoptionOfferAnimalCategory", x => new { x.AdoptionOffersId, x.AnimalCategoriesId });
                    table.ForeignKey(
                        name: "FK_AdoptionOfferAnimalCategory_AdoptionOffers_AdoptionOffersId",
                        column: x => x.AdoptionOffersId,
                        principalTable: "AdoptionOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdoptionOfferAnimalCategory_AnimalCategories_AnimalCategori~",
                        column: x => x.AnimalCategoriesId,
                        principalTable: "AnimalCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SiteUserId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationStatus = table.Column<int>(type: "integer", nullable: false),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    ShippingId = table.Column<int>(type: "integer", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    InactivatedBy = table.Column<string>(type: "text", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationApplications_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationApplications_Shippings_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "Shippings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationApplications_SiteUsers_SiteUserId",
                        column: x => x.SiteUserId,
                        principalTable: "SiteUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnimalCategories",
                columns: new[] { "Id", "CategoryName", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "ParentCategoryId", "StatusId" },
                values: new object[,]
                {
                    { 1, "Laboratoryjne", new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9476), "charlie.b@test.com", null, null, null, null, null, 0 },
                    { 2, "Domowe", new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9477), "charlie.b@test.com", null, null, null, null, null, 0 },
                    { 4, "Gryzonie", new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9479), "milva.b@test.com", null, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "Species", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2022, 10, 18), new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9316), "lab.rescue.adopcje@gmail.com", null, null, null, null, "Szczur Wistar", "Szczur", 0 },
                    { 2, new DateOnly(2020, 8, 18), new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9322), "kalipso@seed.com", null, null, null, null, "Ragdoll", "Kot", 0 }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "KRS", "Modified", "ModifiedBy", "NIP", "Name", "Phone", "REGON", "StatusId", "Email_DomainName", "Email_UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 7, DateTimeKind.Utc).AddTicks(395), "lab.rescue.adopcje@gmail.com", "Jedyna w Polsce organizacja zajmująca się adopcją zwierząt laboratoryjnych", null, null, null, null, null, null, "LabResque", null, null, 0, "gmail.com", "lab.rescue.adopcje" },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 7, DateTimeKind.Utc).AddTicks(397), "kalipso@seed.com", "Organizacja zajmująca się adopcją zwierząt domowych", null, null, null, null, null, null, "Kalipso", 777777777, null, 0, "seed.com", "kalipso" }
                });

            migrationBuilder.InsertData(
                table: "SiteUsers",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Phone", "Role", "StatusId", "Email_DomainName", "Email_UserName", "SiteUserName_FirstName", "SiteUserName_LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 7, DateTimeKind.Utc).AddTicks(603), "seeder", null, null, null, null, null, 1, 0, "test.com", "charlie.b", "Charlie", "Bradbury" },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 7, DateTimeKind.Utc).AddTicks(604), "seeder", null, null, null, null, 0, 1, 0, "test.com", "milva.b", "Milva", "Barring" },
                    { 3, new DateTime(2023, 8, 18, 15, 19, 15, 7, DateTimeKind.Utc).AddTicks(606), "sam.w@test.com", null, null, null, null, 111111111, 2, 0, "test.com", "sam.w", "Sam", "Winchester" },
                    { 4, new DateTime(2023, 8, 18, 15, 19, 15, 7, DateTimeKind.Utc).AddTicks(607), "dean.w@test.com", null, null, null, null, 222222222, 2, 0, "test.com", "dean.w", "Dean", "Winchester" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.k@test.com", null, null, null, null, 333333333, 2, 0, "test.com", "jack.k", "Jack", "Kline" }
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4209), "lab.rescue.adopcje@gmail.com", "Ankieta adopcji szczurów laboratoryjnych", null, null, null, null, 0, "Szczury laboratoryjne" },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4211), "kalipso@seed.com", "Ankieta adopcji kotów", null, null, null, null, 0, "Koty" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Created", "CreatedBy", "Discriminator", "Inactivated", "InactivatedBy", "IsDefault", "Modified", "ModifiedBy", "OrganizationId", "StatusId", "AddressObj_ApartmentNumber", "AddressObj_BuildingNumber", "AddressObj_City", "AddressObj_Country", "AddressObj_StreetName", "AddressObj_ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 8, DateTimeKind.Utc).AddTicks(531), "lab.rescue.adopcje@gmail.com", "OrganizationAddress", null, null, false, null, null, 1, 0, "1", "1", "Gdańsk", "Polska", "Ulica1", "11-111" },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 8, DateTimeKind.Utc).AddTicks(532), "kalipso@seed.com", "OrganizationAddress", null, null, false, null, null, 2, 0, "2", "2", "Gdynia", "Polska", "Ulica2", "22-222" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Created", "CreatedBy", "Discriminator", "Inactivated", "InactivatedBy", "IsDefault", "Modified", "ModifiedBy", "SiteUserId", "StatusId", "AddressObj_ApartmentNumber", "AddressObj_BuildingNumber", "AddressObj_City", "AddressObj_Country", "AddressObj_StreetName", "AddressObj_ZipCode" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 8, 18, 15, 19, 15, 16, DateTimeKind.Utc).AddTicks(8337), "sam.w@test.com", "SiteUserAddress", null, null, false, null, null, 3, 0, "3", "3", "Ciechanowiec", "Polska", "Ulica3", "33-333" },
                    { 4, new DateTime(2023, 8, 18, 15, 19, 15, 16, DateTimeKind.Utc).AddTicks(8340), "dean.w@test.com", "SiteUserAddress", null, null, false, null, null, 4, 0, "4", "4", "Warszawa", "Polska", "Ulica4", "44-444" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Created", "CreatedBy", "Discriminator", "Inactivated", "InactivatedBy", "IsDefault", "Modified", "ModifiedBy", "OrganizationId", "StatusId", "AddressObj_ApartmentNumber", "AddressObj_BuildingNumber", "AddressObj_City", "AddressObj_Country", "AddressObj_StreetName", "AddressObj_ZipCode" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 8, 18, 15, 19, 15, 8, DateTimeKind.Utc).AddTicks(533), "lab.rescue.adopcje@gmail.com", "OrganizationAddress", null, null, true, null, null, 1, 0, "5", "5", "Sopot", "Polska", "Ulica5", "55-555" },
                    { 6, new DateTime(2023, 8, 18, 15, 19, 15, 8, DateTimeKind.Utc).AddTicks(534), "kalipso@seed.com", "OrganizationAddress", null, null, true, null, null, 2, 0, "6", "6", "Malbork", "Polska", "Ulica6", "66-666" }
                });

            migrationBuilder.InsertData(
                table: "AnimalCategories",
                columns: new[] { "Id", "CategoryName", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "ParentCategoryId", "StatusId" },
                values: new object[] { 3, "Szczury laboratoryjne", new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9478), "milva.b@test.com", null, null, null, null, 1, 0 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "SurveyId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4235), "lab.rescue.adopcje@gmail.com", null, null, null, null, 0, 1, "Czy posiadasz już jakies zwierzęta?" },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4236), "kalipso@seed.com", null, null, null, null, 0, 2, "Gdzie zwierzę będzie przebywało w czasie urlopu/wakacji?" },
                    { 3, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4237), "lab.rescue.adopcje@gmail.com", null, null, null, null, 0, 1, "Jakie wymiary będzie miała klatka?" }
                });

            migrationBuilder.InsertData(
                table: "ShippingMethods",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "OrganizationId", "ShippingType", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4179), "lab.rescue.adopcje@gmail.com", "Klient odbiera zwierzęta samodzielnie z domu tymczasowego", null, null, null, null, 1, 1, 0 },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4181), "kalipso@seed.com", "Wolontariusz przekazuje zwierzaka klientowi", null, null, null, null, 2, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "UserResponses",
                columns: new[] { "Id", "Accepted", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "SiteUserId", "StatusId", "SurveyId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4280), "sam.w@test.com", null, null, null, null, 3, 0, 1 },
                    { 2, null, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4282), "dean.w@test.com", null, null, null, null, 4, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "AdoptionOffers",
                columns: new[] { "Id", "AnimalId", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "OrganizationId", "QuatntityInStock", "ResidenceAddressId", "StatusId", "SurveyId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9439), "lab.rescue.adopcje@gmail.com", "Zwierzęta z nadwyżki hodowlanej, lub po nieinwazyjnych testach", null, null, null, null, 1, 30, 1, 0, 1 },
                    { 2, 2, new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9441), "kalipso@seed.com", "Koty znalezione na ulicy", null, null, null, null, 2, 2, 2, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "QuestionId", "StatusId", "Text", "UserResponseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4258), "sam.w@test.com", null, null, null, null, 1, 0, "Tak, kota", 1 },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4259), "dean.w@test.com", null, null, null, null, 2, 0, "U rodziców", 2 },
                    { 3, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4260), "sam.w@test.com", null, null, null, null, 3, 0, "Tak, kota", 1 }
                });

            migrationBuilder.InsertData(
                table: "Shippings",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "ShipmentAddressId", "ShipmentDate", "ShipmentMethodId", "ShipmentStatus", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4146), "lab.rescue.adopcje@gmail.com", null, null, null, null, 3, new DateTime(2023, 8, 28, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4138), 1, 2, 0 },
                    { 2, new DateTime(2023, 8, 18, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4148), "kalipso@seed.com", null, null, null, null, 4, new DateTime(2023, 9, 2, 15, 19, 15, 23, DateTimeKind.Utc).AddTicks(4147), 2, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "AdoptionOfferAnimalCategory",
                columns: new[] { "AdoptionOffersId", "AnimalCategoriesId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ApplicationApplications",
                columns: new[] { "Id", "ApplicationStatus", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "OrderDate", "OrganizationId", "ShippingId", "SiteUserId", "StatusId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9459), "sam.w@test.com", null, null, null, null, new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9459), 1, 1, 3, 0 },
                    { 2, 3, new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9461), "dean.w@test.com", null, null, null, null, new DateTime(2023, 8, 18, 15, 19, 15, 6, DateTimeKind.Utc).AddTicks(9461), 2, 2, 4, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_OrganizationId",
                table: "Addresses",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_SiteUserId",
                table: "Addresses",
                column: "SiteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionOfferAnimalCategory_AnimalCategoriesId",
                table: "AdoptionOfferAnimalCategory",
                column: "AnimalCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionOffers_AnimalId",
                table: "AdoptionOffers",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionOffers_OrganizationId",
                table: "AdoptionOffers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionOffers_ResidenceAddressId",
                table: "AdoptionOffers",
                column: "ResidenceAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionOffers_SurveyId",
                table: "AdoptionOffers",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalCategories_ParentCategoryId",
                table: "AnimalCategories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserResponseId",
                table: "Answers",
                column: "UserResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationApplications_OrganizationId",
                table: "ApplicationApplications",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationApplications_ShippingId",
                table: "ApplicationApplications",
                column: "ShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationApplications_SiteUserId",
                table: "ApplicationApplications",
                column: "SiteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_Email_UserName_Email_DomainName",
                table: "Organizations",
                columns: new[] { "Email_UserName", "Email_DomainName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyId",
                table: "Questions",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingMethods_OrganizationId",
                table: "ShippingMethods",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Shippings_ShipmentAddressId",
                table: "Shippings",
                column: "ShipmentAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Shippings_ShipmentMethodId",
                table: "Shippings",
                column: "ShipmentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUsers_Email_UserName_Email_DomainName",
                table: "SiteUsers",
                columns: new[] { "Email_UserName", "Email_DomainName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserResponses_SiteUserId",
                table: "UserResponses",
                column: "SiteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponses_SurveyId",
                table: "UserResponses",
                column: "SurveyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdoptionOfferAnimalCategory");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "ApplicationApplications");

            migrationBuilder.DropTable(
                name: "AdoptionOffers");

            migrationBuilder.DropTable(
                name: "AnimalCategories");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "UserResponses");

            migrationBuilder.DropTable(
                name: "Shippings");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ShippingMethods");

            migrationBuilder.DropTable(
                name: "SiteUsers");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
