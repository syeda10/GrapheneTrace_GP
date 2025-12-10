using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientAge",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PatientAge", "PatientId", "Phone", "PostCode", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "10 Downing Street", "London", new DateTime(1984, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophie.night@gmail.com", "Sophie", "Female", "Night", "40", 2693, "07012345678", "SW1A 2AA", "Active", "Mrs." },
                    { 2, "20 Baker Street", "London", new DateTime(1992, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "janee.harrison@gmail.com", "Janee", "Female", "Harrison", "32", 5987, "07087654321", "NW1 6XE", "Not Active", "Ms." },
                    { 3, "30 Oxford Street", "London", new DateTime(1995, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.jackson@gmail.com", "Mike", "Male", "Jackson", "29", 8963, "07011223344", "W1D 1BS", "Alert", "Mr" },
                    { 4, "40 King Street", "London", new DateTime(1978, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.benjamin@gmail.com", "Peter", "Male", "Benjamin", "49", 1257, "07098765432", "W1F 0UT", "Not Active", "Mr." },
                    { 5, "50 Queen Street", "London", new DateTime(1988, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannah.green@gmail.com", "Hannah", "Female", "Green", "42", 9862, "07012345678", "W1A 1AA", "Alert", "Mrs." },
                    { 6, "60 King Street", "London", new DateTime(1986, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "andy.bryan@gmail.com", "Andy", "Male", "Bryan", "38", 3654, "07012345678", "W1F 0UT", "Not Active", "Mr" },
                    { 7, "70 King Street", "London", new DateTime(1986, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "alex.white@gmail.com", "Alex", "Male", "White", "38", 4527, "07012345678", "W1F 0UT", "Active", "Mr" },
                    { 8, "80 Queen Street", "London", new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "clara.ashley@gmail.com", "Clara", "Female", "Ashley", "30", 6723, "07012345678", "W1A 1AA", "Active", "Mrs." },
                    { 9, "90 Queen Street", "London", new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "diana.prince@gmail.com", "Diana", "Female", "Prince", "34", 7894, "07012345678", "W1A 1AA", "Not Active", "Ms." },
                    { 10, "100 Gotham Street", "Gotham", new DateTime(1978, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.watson@gmail.com", "Richard", "Male", "Watson", "45", 3456, "07012345678", "G1TH 0TH", "Active", "Mr" },
                    { 11, "110 Gotham Street", "Gotham", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.brown@gmail.com", "James", "Female", "Brown", "28", 9123, "07012345678", "G1TH 0TH", "Not Active", "Mr." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientAge",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Patients");
        }
    }
}
