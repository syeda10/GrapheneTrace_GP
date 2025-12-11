using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextAppointment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Address", "City", "DateOfBirth", "Email", "FirstName", "Gender", "Id", "LastName", "PatientAge", "Phone", "PostCode", "Status", "Title" },
                values: new object[,]
                {
                    { 1257, "40 King Street", "London", new DateTime(1978, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.benjamin@gmail.com", "Peter", "Male", 0, "Benjamin", "49", "07098765432", "W1F 0UT", "Active", "Mr." },
                    { 2345, "40 River Side", "Manchester", new DateTime(1982, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.johnson@gmail.com", "Ava", "Female", 0, "Johnson", "41", "07345678912", "M1 2AB", "Not Active", "Mrs." },
                    { 2693, "10 Downing Street", "London", new DateTime(1984, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophie.night@gmail.com", "Sophie", "Female", 0, "Night", "40", "07012345678", "SW1A 2AA", "Active", "Mrs." },
                    { 3456, "100 Gotham Street", "Gotham", new DateTime(1978, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.watson@gmail.com", "Richard", "Male", 0, "Watson", "45", "07012345678", "G1TH 0TH", "Active", "Mr" },
                    { 3457, "60 River Side", "Manchester", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.brown@gmail.com", "Noah", "Male", 0, "Brown", "33", "07512345678", "M1 2AB", "Active", "Mr." },
                    { 3654, "60 King Street", "London", new DateTime(1986, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "andy.bryan@gmail.com", "Andy", "Male", 0, "Bryan", "38", "07012345678", "W1F 0UT", "Not Active", "Mr" },
                    { 4527, "70 King Street", "London", new DateTime(1986, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "alex.white@gmail.com", "Alex", "Male", 0, "White", "38", "07012345678", "W1F 0UT", "Active", "Mr" },
                    { 4569, "20 Avenue Glass Rd", "Bristol", new DateTime(1986, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia12.Patrick@gmail.com", "Olivia", "Female", 0, "Patrick", "39", "07452136925", "B17G BYR", "Active", "Ms" },
                    { 5987, "20 Baker Street", "London", new DateTime(1992, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "janee.harrison@gmail.com", "Janee", "Female", 0, "Harrison", "32", "07087654321", "NW1 6XE", "Active", "Ms." },
                    { 6723, "80 Queen Street", "London", new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "clara.ashley@gmail.com", "Clara", "Female", 0, "Ashley", "30", "07012345678", "W1A 1AA", "Not Active", "Mrs." },
                    { 6789, "50 River Side", "Manchester", new DateTime(1994, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabella.williams@gmail.com", "Isabella", "Female", 0, "Williams", "29", "07412345678", "M1 2AB", "Active", "Ms." },
                    { 7891, "30 River Side", "Manchester", new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "liam.smith@gmail.com", "Liam", "Male", 0, "Smith", "35", "07345678912", "M1 2AB", "Active", "Mr." },
                    { 7894, "90 Queen Street", "London", new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "diana.prince@gmail.com", "Diana", "Female", 0, "Prince", "34", "07012345678", "W1A 1AA", "Not Active", "Ms." },
                    { 8963, "30 Oxford Street", "London", new DateTime(1995, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.jackson@gmail.com", "Mike", "Male", 0, "Jackson", "29", "07011223344", "W1D 1BS", "Alert", "Mr" },
                    { 9123, "110 Gotham Street", "Gotham", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.brown@gmail.com", "James", "Female", 0, "Brown", "28", "07012345678", "G1TH 0TH", "Not Active", "Mr." },
                    { 9862, "50 Queen Street", "London", new DateTime(1988, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannah.green@gmail.com", "Hannah", "Female", 0, "Green", "42", "07012345678", "W1A 1AA", "Active", "Mrs." }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "Comments", "IsCompleted", "NextAppointment", "PatientId", "TreatmentType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Routine visit", false, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2693, "General Checkup" },
                    { 2, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal results", true, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2693, "Blood Test" },
                    { 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Progressing well", false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2693, "Physical Therapy" },
                    { 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stable condition", true, null, 2693, "Follow-up" },
                    { 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good oral hygiene", true, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5987, "Dental Cleaning" },
                    { 6, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "No issues detected", true, null, 5987, "X-Ray" },
                    { 7, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", false, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5987, "General Checkup" },
                    { 8, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prescribed glasses", true, null, 5987, "Eye Examination" },
                    { 9, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minor spinal issue", false, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8963, "MRI Scan" },
                    { 10, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Back pain improving", true, null, 8963, "Physiotherapy" },
                    { 11, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Condition stable", true, null, 8963, "Follow-up" },
                    { 12, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "No serious issues", true, null, 8963, "Neurology Review" },
                    { 13, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", true, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1257, "General Checkup" },
                    { 14, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low iron", false, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1257, "Blood Work" },
                    { 15, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diet plan issued", true, null, 1257, "Nutrition Consultation" },
                    { 16, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Updated records", true, null, 1257, "Vaccination" },
                    { 17, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", true, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9862, "General Checkup" },
                    { 18, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "No issues", true, null, 9862, "Skin Screening" },
                    { 19, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vision normal", true, null, 9862, "Eye Test" },
                    { 20, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "All good", true, null, 9862, "Follow-up" },
                    { 21, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive lifestyle noted", false, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3654, "General Checkup" },
                    { 22, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borderline results", true, null, 3654, "Cardio Stress Test" },
                    { 23, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plan provided", true, null, 3654, "Diet Consultation" },
                    { 24, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improving", true, null, 3654, "Follow-up" },
                    { 25, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mild allergies found", true, null, 4527, "Allergy Test" },
                    { 26, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good health", true, null, 4527, "General Checkup" },
                    { 27, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Results normal", true, null, 4527, "Blood Test" },
                    { 28, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "No issues", true, null, 4527, "X-Ray" },
                    { 29, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive status noted", true, null, 6723, "General Checkup" },
                    { 30, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good teeth", true, null, 6723, "Dental Cleaning" },
                    { 31, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reading glasses advised", true, null, 6723, "Eye Examination" },
                    { 32, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clear", true, null, 6723, "Skin Screening" },
                    { 33, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very healthy", true, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7894, "General Checkup" },
                    { 34, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleared for activity", true, null, 7894, "Sports Physical" },
                    { 35, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improved posture", true, null, 7894, "Chiropractic Adjustment" },
                    { 36, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excellent condition", true, null, 7894, "Follow-up" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Clinicians");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
