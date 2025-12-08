using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianId = table.Column<int>(type: "int", nullable: false),
                    ClinicianFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianSpeciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinicians", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clinicians",
                columns: new[] { "Id", "Address", "City", "ClinicianAge", "ClinicianFirstName", "ClinicianId", "ClinicianLastName", "ClinicianSpeciality", "DateOfBirth", "Email", "Gender", "Phone", "PostCode", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "1 Main Street", "London", "40", "John", 852693, "Michael", "Cardiologist", new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.michael@example.com", "Male", "07111111111", "A1 1AA", "Active", "Dr." },
                    { 2, "2 Main Street", "London", "32", "Sarah", 698235, "Peterson", "Neurology", new DateTime(1992, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.peterson@hospital.com", "Female", "07222222222", "A2 2BB", "Active", "Dr." },
                    { 3, "3 Main Street", "London", "30", "Emily", 456973, "Johnson", "Pediatrics", new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.johnson@hospital.com", "Female", "07333333333", "A3 3CC", "Active", "Dr." },
                    { 4, "4 Main Street", "London", "29", "David", 325698, "Anderson", "Neurologist", new DateTime(1995, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.anderson@hospital.com", "Male", "07444444444", "A4 4DD", "Active", "Dr." },
                    { 5, "5 Main Street", "London", "49", "Emmanuel", 258963, "State", "Surgeon", new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmanuel.state@hospital.com", "Male", "07555555555", "A5 5EE", "Active", "Dr." },
                    { 6, "6 Main Street", "London", "42", "Mike", 258694, "Stephen", "Radiologist", new DateTime(1982, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.stephen@hospital.com", "Male", "07666666666", "A6 6FF", "Active", "Dr." },
                    { 7, "7 Main Street", "London", "38", "Noah", 784561, "Hyper", "Psychiatrist", new DateTime(1986, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.hyper@hospital.com", "Male", "07777777777", "A7 7GG", "Active", "Dr." },
                    { 8, "8 Main Street", "London", "38", "Helen", 125489, "Cooke", "Gynaecologist", new DateTime(1986, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "helen.cooke@hospital.com", "Female", "07888888888", "A8 8HH", "Active", "Dr." },
                    { 9, "9 Main Street", "London", "42", "Rose", 508342, "Night", "Surgeon", new DateTime(1982, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "rose.night@hospital.com", "Female", "07999999999", "A9 9JJ", "Active", "Dr." },
                    { 10, "10 Main Street", "London", "54", "Jake", 159753, "Watson", "Orthopaedic", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jake.watson@hospital.com", "Male", "07010101010", "B1 1AA", "Active", "Dr." },
                    { 11, "11 Main Street", "London", "34", "Emma", 753561, "Richard", "Dermatologist", new DateTime(1990, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.richard@hospital.com", "Female", "07020202020", "B2 2BB", "Active", "Dr." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clinicians");
        }
    }
}
