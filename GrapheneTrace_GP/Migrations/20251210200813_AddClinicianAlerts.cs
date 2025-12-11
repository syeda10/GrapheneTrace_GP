using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class AddClinicianAlerts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ClinicianAlerts_ClinicianId",
                table: "ClinicianAlerts",
                column: "ClinicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicianAlerts");
        }
    }
}
