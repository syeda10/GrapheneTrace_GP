using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class FixPatientTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
