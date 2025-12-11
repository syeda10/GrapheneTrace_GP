using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class AddMorePatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Address", "City", "ClinicianId", "DateOfBirth", "Email", "FirstName", "Gender", "Id", "LastName", "PatientAge", "Phone", "PostCode", "Status", "Title" },
                values: new object[,]
                {
                    { 8123, "12 Wood Street", "London", 2, new DateTime(1987, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "harvey.cole@gmail.com", "Harvey", "Male", 0, "Cole", "37", "07581234567", "E2 4AA", "Active", "Mr." },
                    { 8125, "28 Crescent Lane", "Manchester", 3, new DateTime(1980, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "layla.stevens@gmail.com", "Layla", "Female", 0, "Stevens", "44", "07411122233", "M3 4GH", "Active", "Ms." },
                    { 8126, "4 Mill View", "Manchester", 3, new DateTime(1972, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "brandon.lee@gmail.com", "Brandon", "Male", 0, "Lee", "52", "07422233344", "M4 1AB", "Not Active", "Mr." },
                    { 8127, "7 Elm Park", "London", 4, new DateTime(1998, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tom.barker@gmail.com", "Tom", "Male", 0, "Barker", "26", "07399988877", "SW1 7DF", "Active", "Mr." },
                    { 8128, "22 Green Lane", "London", 4, new DateTime(1976, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nora.hughes@gmail.com", "Nora", "Female", 0, "Hughes", "48", "07311155522", "SW1 9GH", "Active", "Mrs." },
                    { 8129, "18 Maple Street", "Bristol", 1, new DateTime(1993, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ethan.morris@gmail.com", "Ethan", "Male", 0, "Morris", "31", "07812345670", "BS1 3DA", "Active", "Mr." },
                    { 8130, "45 River Way", "Bristol", 1, new DateTime(1988, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "chloe.adams@gmail.com", "Chloe", "Female", 0, "Adams", "36", "07898732100", "BS2 5HB", "Not Active", "Ms." },
                    { 8131, "33 Oak Road", "London", 5, new DateTime(1984, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kyle.garcia@gmail.com", "Kyle", "Male", 0, "Garcia", "40", "07788822211", "NW1 5RT", "Active", "Mr." },
                    { 8132, "91 Hill Street", "London", 5, new DateTime(2000, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "amelia.scott@gmail.com", "Amelia", "Female", 0, "Scott", "24", "07722288899", "NW3 8YZ", "Active", "Ms." },
                    { 8133, "4 Silver Street", "Manchester", 6, new DateTime(1991, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "jacob.shaw@gmail.com", "Jacob", "Male", 0, "Shaw", "33", "07655533322", "M2 7EG", "Active", "Mr." },
                    { 8134, "20 Brook Lane", "Manchester", 6, new DateTime(1978, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.miller@gmail.com", "Grace", "Female", 0, "Miller", "46", "07611122244", "M2 9GT", "Active", "Mrs." },
                    { 8135, "14 Sunset Drive", "Liverpool", 7, new DateTime(1985, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ryan.evans@gmail.com", "Ryan", "Male", 0, "Evans", "39", "07544455566", "L1 2AA", "Not Active", "Mr." },
                    { 8136, "22 Hilltop Road", "Liverpool", 7, new DateTime(1997, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia.clarke@gmail.com", "Sophia", "Female", 0, "Clarke", "27", "07555566677", "L2 1BB", "Active", "Ms." },
                    { 8137, "10 Riverbank", "Gotham", 8, new DateTime(1974, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ella.turner@gmail.com", "Ella", "Female", 0, "Turner", "50", "07477788822", "G1TH 2TT", "Active", "Mrs." },
                    { 8138, "18 Lantern Lane", "Gotham", 8, new DateTime(1983, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "nathan.brooks@gmail.com", "Nathan", "Male", 0, "Brooks", "41", "07422244455", "G1TH 3PP", "Active", "Mr." },
                    { 8139, "6 Forest Road", "London", 2, new DateTime(1990, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "leo.robinson@gmail.com", "Leo", "Male", 0, "Robinson", "34", "07522113344", "E1 7HH", "Active", "Mr." },
                    { 8140, "8 Oakwood", "London", 5, new DateTime(1993, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "holly.grant@gmail.com", "Holly", "Female", 0, "Grant", "31", "07512398765", "NW8 1GG", "Not Active", "Ms." },
                    { 8141, "39 Slope View", "Manchester", 3, new DateTime(1977, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "aaron.foster@gmail.com", "Aaron", "Male", 0, "Foster", "47", "07489012345", "M4 9QA", "Active", "Mr." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8123);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8125);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8126);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8127);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8128);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8129);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8130);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8131);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8132);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8133);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8134);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8135);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8136);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8137);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8138);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8139);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8140);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8141);
        }
    }
}
