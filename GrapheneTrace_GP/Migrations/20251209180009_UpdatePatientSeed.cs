using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatientSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: "Not Active");

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PatientAge", "PatientId", "Phone", "PostCode", "Status", "Title" },
                values: new object[,]
                {
                    { 13, "30 River Side", "Manchester", new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "liam.smith@gmail.com", "Liam", "Male", "Smith", "35", 7891, "07345678912", "M1 2AB", "Active", "Mr." },
                    { 14, "40 River Side", "Manchester", new DateTime(1982, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.johnson@gmail.com", "Ava", "Female", "Johnson", "41", 2345, "07345678912", "M1 2AB", "Not Active", "Mrs." },
                    { 15, "50 River Side", "Manchester", new DateTime(1994, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabella.williams@gmail.com", "Isabella", "Female", "Williams", "29", 6789, "07412345678", "M1 2AB", "Active", "Ms." },
                    { 16, "60 River Side", "Manchester", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.brown@gmail.com", "Noah", "Male", "Brown", "33", 3457, "07512345678", "M1 2AB", "Active", "Mr." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Not Active");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: "Not Active");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: "Alert");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: "Active");
        }
    }
}
