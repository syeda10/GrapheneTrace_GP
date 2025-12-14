using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class FixClinicianNullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClinicianSpeciality",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ClinicianAge",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9059), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9080), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9089), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9096), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9102), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9108), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9114), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9120), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9126), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9131), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9137), new DateTime(2025, 12, 14, 3, 51, 10, 609, DateTimeKind.Utc).AddTicks(9138) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClinicianSpeciality",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClinicianAge",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(839), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(859), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(874), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(952), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(958), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(964), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(970), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(976), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(982), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(988), new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(988) });
        }
    }
}
