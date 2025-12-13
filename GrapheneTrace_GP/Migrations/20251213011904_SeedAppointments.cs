using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class SeedAppointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7985), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7989), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7993), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7996), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7999), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8002), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8005), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8013), new DateTime(2025, 12, 13, 1, 19, 3, 94, DateTimeKind.Utc).AddTicks(8013) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7277), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7292), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7296), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7304), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7307), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7313), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7317), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7323), new DateTime(2025, 12, 12, 10, 22, 20, 327, DateTimeKind.Utc).AddTicks(7323) });
        }
    }
}
