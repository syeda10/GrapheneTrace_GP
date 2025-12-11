using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class SeedAlerts : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerts");
        }
    }
}
