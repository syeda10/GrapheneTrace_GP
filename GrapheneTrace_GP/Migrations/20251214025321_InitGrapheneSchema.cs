using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class InitGrapheneSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlertCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelatedId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clinicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianId = table.Column<int>(type: "int", nullable: false),
                    ClinicianSpeciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CliniciansProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CliniciansProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClinicianAlerts",
                columns: table => new
                {
                    AlertId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicianId = table.Column<int>(type: "int", nullable: false),
                    AlertType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianAlerts", x => x.AlertId);
                    table.ForeignKey(
                        name: "FK_ClinicianAlerts_Clinicians_ClinicianId",
                        column: x => x.ClinicianId,
                        principalTable: "Clinicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Clinicians_ClinicianId",
                        column: x => x.ClinicianId,
                        principalTable: "Clinicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ClinicianAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicianId = table.Column<int>(type: "int", nullable: false),
                    AssignedPatients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentAppointments = table.Column<int>(type: "int", nullable: false),
                    AssignedWardUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastAssignmentUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicianAssignments_CliniciansProfiles_ClinicianId",
                        column: x => x.ClinicianId,
                        principalTable: "CliniciansProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClinicianProfessionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicianId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomAssigned = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianProfessionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicianProfessionalInfos_CliniciansProfiles_ClinicianId",
                        column: x => x.ClinicianId,
                        principalTable: "CliniciansProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    NextAppointment = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                table: "Alerts",
                columns: new[] { "Id", "AlertCode", "CreatedAt", "Message", "Priority", "RelatedId", "Status", "Type" },
                values: new object[,]
                {
                    { 1, "ALT-01", new DateTime(2025, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "System software update available - pending installation approval", "Medium", null, "Read", "System" },
                    { 2, "ALT-02", new DateTime(2025, 2, 1, 11, 20, 0, 0, DateTimeKind.Unspecified), "Profile verification pending for Dr Anderson", "High", "325698", "Unread", "System" },
                    { 3, "ALT-03", new DateTime(2025, 2, 2, 8, 10, 0, 0, DateTimeKind.Unspecified), "Data backup completed successfully", "Low", null, "Read", "System" },
                    { 4, "ALT-10", new DateTime(2025, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), "New patient assigned to Dr John Michael: Olivia Patrick", "Low", "4569", "Read", "Clinician" },
                    { 5, "ALT-11", new DateTime(2025, 2, 10, 12, 30, 0, 0, DateTimeKind.Unspecified), "Workload limit reached for Dr Sarah Peterson", "High", "698235", "Unread", "Clinician" },
                    { 6, "ALT-12", new DateTime(2025, 2, 11, 13, 15, 0, 0, DateTimeKind.Unspecified), "Certification updated for Dr Emily Johnson", "Medium", "456973", "Read", "Clinician" },
                    { 7, "ALT-13", new DateTime(2025, 2, 11, 10, 12, 0, 0, DateTimeKind.Unspecified), "Shift change request approved for Dr David Anderson", "Low", "325698", "Read", "Clinician" },
                    { 8, "ALT-14", new DateTime(2025, 2, 11, 16, 45, 0, 0, DateTimeKind.Unspecified), "Dr Emmanuel State reached maximum patient load", "High", "258963", "Unread", "Clinician" },
                    { 9, "ALT-20", new DateTime(2025, 2, 12, 2, 35, 0, 0, DateTimeKind.Unspecified), "ECG anomaly detected for patient Jacob Flynn – immediate review recommended", "Critical", "9862", "Unread", "Patient" },
                    { 10, "ALT-21", new DateTime(2025, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "Medication conflict detected for patient Alex White (penicillin allergy)", "High", "4527", "Unread", "Patient" },
                    { 11, "ALT-22", new DateTime(2025, 2, 13, 11, 45, 0, 0, DateTimeKind.Unspecified), "Follow-up required for patient Hannah Green – symptoms recorded", "Medium", "9862", "Unread", "Patient" },
                    { 12, "ALT-23", new DateTime(2025, 2, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Routine blood pressure check due for patient Clara Ashley", "Low", "6723", "Read", "Patient" },
                    { 13, "ALT-24", new DateTime(2025, 2, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), "Patient Liam Smith reported recurrent chest discomfort", "High", "7891", "Unread", "Patient" },
                    { 14, "ALT-30", new DateTime(2025, 2, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), "11:00 PM Dashboard will be temporarily unavailable due to maintenance", "Low", null, "Read", "System" },
                    { 15, "ALT-31", new DateTime(2025, 2, 15, 18, 15, 0, 0, DateTimeKind.Unspecified), "Security scan completed — No threats detected", "Low", null, "Read", "System" },
                    { 16, "ALT-32", new DateTime(2025, 2, 16, 9, 30, 0, 0, DateTimeKind.Unspecified), "New feature rollout: Enhanced reporting tools now available", "Medium", null, "Read", "System" },
                    { 17, "ALT-33", new DateTime(2025, 2, 16, 14, 45, 0, 0, DateTimeKind.Unspecified), "User activity logs archived successfully", "Low", null, "Read", "System" },
                    { 18, "ALT-34", new DateTime(2025, 2, 17, 3, 20, 0, 0, DateTimeKind.Unspecified), "Critical vulnerability patch applied to server infrastructure", "Critical", null, "Unread", "System" },
                    { 19, "ALT-35", new DateTime(2025, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Monthly system performance report is now available", "Medium", null, "Read", "System" }
                });

            migrationBuilder.InsertData(
                table: "Clinicians",
                columns: new[] { "Id", "Address", "City", "ClinicianAge", "ClinicianFirstName", "ClinicianId", "ClinicianLastName", "ClinicianSpeciality", "CreatedAt", "DateOfBirth", "Email", "Gender", "Phone", "PostCode", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "1 Main Street", "London", "40", "John", 852693, "Michael", "Cardiologist", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3027), new DateTime(1984, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.michael@example.com", "Male", "07111111111", "A1 1AA", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3030) },
                    { 2, "2 Main Street", "London", "32", "Sarah", 698235, "Peterson", "Neurology", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3056), new DateTime(1992, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.peterson@hospital.com", "Female", "07222222222", "A2 2BB", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3057) },
                    { 3, "3 Main Street", "London", "30", "Emily", 456973, "Johnson", "Pediatrics", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3064), new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.johnson@hospital.com", "Female", "07333333333", "A3 3CC", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3065) },
                    { 4, "4 Main Street", "London", "29", "David", 325698, "Anderson", "Neurologist", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3071), new DateTime(1995, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.anderson@hospital.com", "Male", "07444444444", "A4 4DD", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3072) },
                    { 5, "5 Main Street", "London", "49", "Emmanuel", 258963, "State", "Surgeon", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3077), new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmanuel.state@hospital.com", "Male", "07555555555", "A5 5EE", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3078) },
                    { 6, "6 Main Street", "London", "42", "Mike", 258694, "Stephen", "Radiologist", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3083), new DateTime(1982, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.stephen@hospital.com", "Male", "07666666666", "A6 6FF", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3084) },
                    { 7, "7 Main Street", "London", "38", "Noah", 784561, "Hyper", "Psychiatrist", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3089), new DateTime(1986, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.hyper@hospital.com", "Male", "07777777777", "A7 7GG", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3090) },
                    { 8, "8 Main Street", "London", "38", "Helen", 125489, "Cooke", "Gynaecologist", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3171), new DateTime(1986, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "helen.cooke@hospital.com", "Female", "07888888888", "A8 8HH", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3172) },
                    { 9, "9 Main Street", "London", "42", "Rose", 508342, "Night", "Surgeon", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3178), new DateTime(1982, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "rose.night@hospital.com", "Female", "07999999999", "A9 9JJ", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3179) },
                    { 10, "10 Main Street", "London", "54", "Jake", 159753, "Watson", "Orthopaedic", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3184), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jake.watson@hospital.com", "Male", "07010101010", "B1 1AA", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3185) },
                    { 11, "11 Main Street", "London", "34", "Emma", 753561, "Richard", "Dermatologist", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3190), new DateTime(1990, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.richard@hospital.com", "Female", "07020202020", "B2 2BB", "Active", "Dr.", new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3190) }
                });

            migrationBuilder.InsertData(
                table: "ClinicianAlerts",
                columns: new[] { "AlertId", "AlertDateTime", "AlertType", "ClinicianId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 11, 13, 15, 0, 0, DateTimeKind.Unspecified), "Certification updated", 1 },
                    { 2, new DateTime(2025, 2, 11, 10, 12, 0, 0, DateTimeKind.Unspecified), "Profile updated", 1 },
                    { 3, new DateTime(2025, 2, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), "New patient assigned", 1 },
                    { 4, new DateTime(2025, 2, 11, 8, 0, 0, 0, DateTimeKind.Unspecified), "Status active", 2 },
                    { 5, new DateTime(2025, 2, 11, 18, 30, 0, 0, DateTimeKind.Unspecified), "Status inactive", 2 },
                    { 6, new DateTime(2025, 2, 10, 13, 30, 0, 0, DateTimeKind.Unspecified), "High workload", 2 },
                    { 7, new DateTime(2025, 2, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), "Certification expired", 2 },
                    { 8, new DateTime(2025, 2, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), "Shift change request", 3 },
                    { 9, new DateTime(2025, 2, 9, 9, 30, 0, 0, DateTimeKind.Unspecified), "Status active", 3 },
                    { 10, new DateTime(2025, 2, 8, 17, 40, 0, 0, DateTimeKind.Unspecified), "Documents uploaded", 4 },
                    { 11, new DateTime(2025, 2, 8, 13, 30, 0, 0, DateTimeKind.Unspecified), "Verification pending", 4 },
                    { 12, new DateTime(2025, 2, 7, 14, 25, 0, 0, DateTimeKind.Unspecified), "New patient assigned", 5 },
                    { 13, new DateTime(2025, 2, 7, 9, 50, 0, 0, DateTimeKind.Unspecified), "Status inactive", 5 },
                    { 14, new DateTime(2025, 2, 6, 11, 10, 0, 0, DateTimeKind.Unspecified), "Shift schedule updated", 6 },
                    { 15, new DateTime(2025, 2, 5, 16, 45, 0, 0, DateTimeKind.Unspecified), "High workload", 7 },
                    { 16, new DateTime(2025, 2, 4, 10, 20, 0, 0, DateTimeKind.Unspecified), "Profile updated", 7 },
                    { 17, new DateTime(2025, 2, 3, 14, 20, 0, 0, DateTimeKind.Unspecified), "New patient assigned", 8 },
                    { 18, new DateTime(2025, 2, 3, 8, 40, 0, 0, DateTimeKind.Unspecified), "Certification updated", 8 },
                    { 19, new DateTime(2025, 2, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), "Emergency override assigned", 9 },
                    { 20, new DateTime(2025, 2, 1, 9, 10, 0, 0, DateTimeKind.Unspecified), "New patient assigned", 10 },
                    { 21, new DateTime(2025, 1, 29, 15, 35, 0, 0, DateTimeKind.Unspecified), "Certification expired", 11 },
                    { 22, new DateTime(2025, 1, 29, 10, 0, 0, 0, DateTimeKind.Unspecified), "Shift change request", 11 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Address", "City", "ClinicianId", "DateOfBirth", "Email", "FirstName", "Gender", "Id", "LastName", "PatientAge", "Phone", "PostCode", "Status", "Title" },
                values: new object[,]
                {
                    { 1257, "40 King Street", "London", 5, new DateTime(1978, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.benjamin@gmail.com", "Peter", "Male", 0, "Benjamin", "49", "07098765432", "W1F 0UT", "Active", "Mr." },
                    { 2345, "40 River Side", "Manchester", 6, new DateTime(1982, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.johnson@gmail.com", "Ava", "Female", 0, "Johnson", "41", "07345678912", "M1 2AB", "Not Active", "Mrs." },
                    { 2693, "10 Downing Street", "London", 2, new DateTime(1984, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophie.night@gmail.com", "Sophie", "Female", 0, "Night", "40", "07012345678", "SW1A 2AA", "Active", "Mrs." },
                    { 3456, "100 Gotham Street", "Gotham", 8, new DateTime(1978, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.watson@gmail.com", "Richard", "Male", 0, "Watson", "45", "07012345678", "G1TH 0TH", "Active", "Mr" },
                    { 3457, "60 River Side", "Manchester", 6, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.brown@gmail.com", "Noah", "Male", 0, "Brown", "33", "07512345678", "M1 2AB", "Active", "Mr." },
                    { 3654, "60 King Street", "London", 5, new DateTime(1986, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "andy.bryan@gmail.com", "Andy", "Male", 0, "Bryan", "38", "07012345678", "W1F 0UT", "Not Active", "Mr" },
                    { 4527, "70 King Street", "London", 4, new DateTime(1986, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "alex.white@gmail.com", "Alex", "Male", 0, "White", "38", "07012345678", "W1F 0UT", "Active", "Mr" },
                    { 4569, "20 Avenue Glass Rd", "Bristol", 1, new DateTime(1986, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olivia12.Patrick@gmail.com", "Olivia", "Female", 0, "Patrick", "39", "07452136925", "B17G BYR", "Active", "Ms" },
                    { 5987, "20 Baker Street", "London", 4, new DateTime(1992, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "janee.harrison@gmail.com", "Janee", "Female", 0, "Harrison", "32", "07087654321", "NW1 6XE", "Active", "Ms." },
                    { 6723, "80 Queen Street", "London", 2, new DateTime(1994, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "clara.ashley@gmail.com", "Clara", "Female", 0, "Ashley", "30", "07012345678", "W1A 1AA", "Not Active", "Mrs." },
                    { 6789, "50 River Side", "Manchester", 7, new DateTime(1994, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabella.williams@gmail.com", "Isabella", "Female", 0, "Williams", "29", "07412345678", "M1 2AB", "Active", "Ms." },
                    { 7891, "30 River Side", "Manchester", 3, new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "liam.smith@gmail.com", "Liam", "Male", 0, "Smith", "35", "07345678912", "M1 2AB", "Active", "Mr." },
                    { 7894, "90 Queen Street", "London", 7, new DateTime(1990, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "diana.prince@gmail.com", "Diana", "Female", 0, "Prince", "34", "07012345678", "W1A 1AA", "Not Active", "Ms." },
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
                    { 8141, "39 Slope View", "Manchester", 3, new DateTime(1977, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "aaron.foster@gmail.com", "Aaron", "Male", 0, "Foster", "47", "07489012345", "M4 9QA", "Active", "Mr." },
                    { 8963, "30 Oxford Street", "London", 1, new DateTime(1995, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.jackson@gmail.com", "Mike", "Male", 0, "Jackson", "29", "07011223344", "W1D 1BS", "Alert", "Mr" },
                    { 9123, "110 Gotham Street", "Gotham", 8, new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.brown@gmail.com", "James", "Female", 0, "Brown", "28", "07012345678", "G1TH 0TH", "Not Active", "Mr." },
                    { 9862, "50 Queen Street", "London", 1, new DateTime(1988, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hannah.green@gmail.com", "Hannah", "Female", 0, "Green", "42", "07012345678", "W1A 1AA", "Active", "Mrs." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicianAlerts_ClinicianId",
                table: "ClinicianAlerts",
                column: "ClinicianId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicianAssignments_ClinicianId",
                table: "ClinicianAssignments",
                column: "ClinicianId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClinicianProfessionalInfos_ClinicianId",
                table: "ClinicianProfessionalInfos",
                column: "ClinicianId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ClinicianId",
                table: "Patients",
                column: "ClinicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerts");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "ClinicianAlerts");

            migrationBuilder.DropTable(
                name: "ClinicianAssignments");

            migrationBuilder.DropTable(
                name: "ClinicianProfessionalInfos");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "CliniciansProfiles");

            migrationBuilder.DropTable(
                name: "Clinicians");
        }
    }
}
