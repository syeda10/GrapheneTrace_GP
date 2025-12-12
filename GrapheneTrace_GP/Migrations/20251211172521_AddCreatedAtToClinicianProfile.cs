using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedAtToClinicianProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClinicianProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianProfile", x => x.Id);
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
                    AssignedWard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastAssignmentUpdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicianAssignments_ClinicianProfile_ClinicianId",
                        column: x => x.ClinicianId,
                        principalTable: "ClinicianProfile",
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
                    ExperienceYears = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenceNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomAssigned = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianProfessionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicianProfessionalInfos_ClinicianProfile_ClinicianId",
                        column: x => x.ClinicianId,
                        principalTable: "ClinicianProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClinicianVerifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicianId = table.Column<int>(type: "int", nullable: false),
                    VerificationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReviewed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicianVerifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicianVerifications_ClinicianProfile_ClinicianId",
                        column: x => x.ClinicianId,
                        principalTable: "ClinicianProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_ClinicianVerifications_ClinicianId",
                table: "ClinicianVerifications",
                column: "ClinicianId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicianAssignments");

            migrationBuilder.DropTable(
                name: "ClinicianProfessionalInfos");

            migrationBuilder.DropTable(
                name: "ClinicianVerifications");

            migrationBuilder.DropTable(
                name: "ClinicianProfile");
        }
    }
}
