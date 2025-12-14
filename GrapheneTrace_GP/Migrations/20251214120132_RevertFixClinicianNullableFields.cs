using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class RevertFixClinicianNullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Patients");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PatientAge",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Allergies",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChronicConditions",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentMedication",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReviewed",
                table: "Patients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactNo",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastMedicalCheckup",
                table: "Patients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NHSNumber",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastSurgeries",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Relationship",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Smoking",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VaccinationStatus",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerificationStatus",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerifiedBy",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 1257,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2345,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2693,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3456,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3457,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3654,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 4527,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 4569,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 5987,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 6723,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 6789,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 7891,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 7894,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8123,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8125,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8126,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8127,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8128,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8129,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8130,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8131,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8132,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8133,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8134,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8135,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8136,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8137,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8138,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8139,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8140,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8141,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8963,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 9123,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 9862,
                columns: new[] { "Allergies", "BloodGroup", "ChronicConditions", "CurrentMedication", "DateReviewed", "Department", "EmergencyContactName", "EmergencyContactNo", "Height", "LastMedicalCheckup", "NHSNumber", "PastSurgeries", "Purpose", "Relationship", "Remarks", "Smoking", "VaccinationStatus", "VerificationStatus", "VerifiedBy", "Weight" },
                values: new object[] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allergies",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ChronicConditions",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "CurrentMedication",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DateReviewed",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "EmergencyContactName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "EmergencyContactNo",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LastMedicalCheckup",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NHSNumber",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PastSurgeries",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Relationship",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Smoking",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "VaccinationStatus",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "VerificationStatus",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "VerifiedBy",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Patients");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostCode",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatientAge",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 1257,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2345,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 2693,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3456,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3457,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 3654,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 4527,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 4569,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 5987,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 6723,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 6789,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 7891,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 7894,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8123,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8125,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8126,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8127,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8128,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8129,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8130,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8131,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8132,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8133,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8134,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8135,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8136,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8137,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8138,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8139,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8140,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8141,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 8963,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 9123,
                column: "Id",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientId",
                keyValue: 9862,
                column: "Id",
                value: 0);
        }
    }
}
