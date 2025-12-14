using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePatientSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3261), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3279), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3287), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3295), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3301), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3307), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3313), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3319), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3324), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3330), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3335), new DateTime(2025, 12, 14, 12, 12, 0, 692, DateTimeKind.Utc).AddTicks(3336) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1139), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1297), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1306), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1314), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1320), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1326), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1332), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1338), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1343), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1349), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1356), new DateTime(2025, 12, 14, 12, 1, 30, 421, DateTimeKind.Utc).AddTicks(1356) });
        }
    }
}
