using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class AddMorePatientSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PatientAge", "PatientId", "Phone", "PostCode", "Status", "Title" },
                values: new object[] { 12, "20 Avenue Glass Rd", "Bristol", new DateTime(1986, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia12.Patrick@gmail.com", "Olivia", "Female", "Patrick", "39", 4569, "07452136925", "B17G BYR", "Active", "Ms" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
