using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClinicianModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Clinicians",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Clinicians",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Clinicians");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Clinicians");
        }
    }
}
