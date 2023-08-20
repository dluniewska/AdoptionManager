using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoptionManager.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Surveys",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Surveys",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "SiteUsers",
                type: "integer",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentStatus",
                table: "Shippings",
                type: "integer",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ShippingType",
                table: "ShippingMethods",
                type: "integer",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ShippingMethods",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organizations",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Organizations",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Answers",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Animals",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "AnimalCategories",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AdoptionOffers",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 601, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 601, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 603, DateTimeKind.Utc).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 603, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 601, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 601, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "AdoptionOffers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "AdoptionOffers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Created" },
                values: new object[] { new DateOnly(2022, 10, 20), new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Created" },
                values: new object[] { new DateOnly(2020, 8, 20), new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "ApplicationApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "OrderDate" },
                values: new object[] { new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3459), new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "ApplicationApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "OrderDate" },
                values: new object[] { new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3461), new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ShipmentDate" },
                values: new object[] { new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7401), new DateTime(2023, 8, 30, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ShipmentDate" },
                values: new object[] { new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7402), new DateTime(2023, 9, 4, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 600, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "UserResponses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "UserResponses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 20, 20, 59, 9, 607, DateTimeKind.Utc).AddTicks(7515));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Surveys",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Surveys",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "SiteUsers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentStatus",
                table: "Shippings",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "ShippingType",
                table: "ShippingMethods",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ShippingMethods",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Organizations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Organizations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Answers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Animals",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "AnimalCategories",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AdoptionOffers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 782, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 782, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 784, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 784, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 782, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 782, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "AdoptionOffers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "AdoptionOffers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "AnimalCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "Created" },
                values: new object[] { new DateOnly(2022, 10, 18), new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Created" },
                values: new object[] { new DateOnly(2020, 8, 18), new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "ApplicationApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "OrderDate" },
                values: new object[] { new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5297), new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "ApplicationApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "OrderDate" },
                values: new object[] { new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5299), new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "ShippingMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ShipmentDate" },
                values: new object[] { new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8794), new DateTime(2023, 8, 28, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ShipmentDate" },
                values: new object[] { new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8798), new DateTime(2023, 9, 2, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "SiteUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 780, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "UserResponses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "UserResponses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 8, 18, 18, 44, 46, 792, DateTimeKind.Utc).AddTicks(9003));
        }
    }
}
