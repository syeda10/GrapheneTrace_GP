using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class AddAssignmentsFieldsToClinicians : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedWardUnit",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Supervisor",
                table: "Clinicians",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(839), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(859), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(867), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(874), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(952), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(958), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(964), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(970), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(976), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(982), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AssignedWardUnit", "CreatedAt", "Supervisor", "UpdatedAt" },
                values: new object[] { null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(988), null, new DateTime(2025, 12, 14, 3, 24, 43, 248, DateTimeKind.Utc).AddTicks(988) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedWardUnit",
                table: "Clinicians");

            migrationBuilder.DropColumn(
                name: "Supervisor",
                table: "Clinicians");

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3027), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3056), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3064), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3071), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3077), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3083), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3089), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3171), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3178), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3184), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3190), new DateTime(2025, 12, 14, 2, 53, 19, 764, DateTimeKind.Utc).AddTicks(3190) });
        }
    }
}
