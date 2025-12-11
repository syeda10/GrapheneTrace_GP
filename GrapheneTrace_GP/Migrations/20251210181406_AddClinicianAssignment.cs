using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class AddClinicianAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClinicianId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 1257,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2345,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2693,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3456,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3457,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3654,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 4527,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 4569,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 5987,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 6723,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 6789,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 7891,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 7894,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8963,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 9123,
                column: "ClinicianId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 9862,
                column: "ClinicianId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ClinicianId",
                table: "Patients",
                column: "ClinicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Clinicians_ClinicianId",
                table: "Patients",
                column: "ClinicianId",
                principalTable: "Clinicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Clinicians_ClinicianId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ClinicianId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ClinicianId",
                table: "Patients");
        }
    }
}
