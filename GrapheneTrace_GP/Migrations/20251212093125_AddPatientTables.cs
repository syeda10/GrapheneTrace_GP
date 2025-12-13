using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class AddPatientTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NHSNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    AssignedDoctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccinationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClinicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientAssignments_PatientProfile_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smoking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PastSurgeries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientMedicalInfos_PatientProfile_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientVerifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    VerificationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateReviewed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientVerifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientVerifications_PatientProfile_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7801), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7813), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7820), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7829), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7831), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7837), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7839), new DateTime(2025, 12, 12, 9, 31, 24, 401, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.CreateIndex(
                name: "IX_PatientAssignments_PatientId",
                table: "PatientAssignments",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicalInfos_PatientId",
                table: "PatientMedicalInfos",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientVerifications_PatientId",
                table: "PatientVerifications",
                column: "PatientId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientAssignments");

            migrationBuilder.DropTable(
                name: "PatientMedicalInfos");

            migrationBuilder.DropTable(
                name: "PatientVerifications");

            migrationBuilder.DropTable(
                name: "PatientProfile");

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(787), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(821), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(829), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(836), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(857), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(864), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(871), new DateTime(2025, 12, 12, 1, 3, 57, 791, DateTimeKind.Utc).AddTicks(871) });
        }
    }
}
