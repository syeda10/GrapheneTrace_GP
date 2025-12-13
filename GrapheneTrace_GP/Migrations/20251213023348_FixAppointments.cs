using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class FixAppointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 36);

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6011), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6032), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6040), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6048), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6053), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6059), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6065), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6070), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6076), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6082), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Clinicians",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6088), new DateTime(2025, 12, 13, 2, 33, 46, 424, DateTimeKind.Utc).AddTicks(6088) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AppointmentId",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AppointmentDate", "Comments", "IsCompleted", "NextAppointment", "PatientId", "TreatmentType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Routine visit", false, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2693, "General Checkup" },
                    { 2, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal results", true, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2693, "Blood Test" },
                    { 3, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Progressing well", false, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2693, "Physical Therapy" },
                    { 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stable condition", true, null, 2693, "Follow-up" },
                    { 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good oral hygiene", true, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5987, "Dental Cleaning" },
                    { 6, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "No issues detected", true, null, 5987, "X-Ray" },
                    { 7, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", false, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5987, "General Checkup" },
                    { 8, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prescribed glasses", true, null, 5987, "Eye Examination" },
                    { 9, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minor spinal issue", false, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8963, "MRI Scan" },
                    { 10, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Back pain improving", true, null, 8963, "Physiotherapy" },
                    { 11, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Condition stable", true, null, 8963, "Follow-up" },
                    { 12, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "No serious issues", true, null, 8963, "Neurology Review" },
                    { 13, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", true, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1257, "General Checkup" },
                    { 14, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Low iron", false, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1257, "Blood Work" },
                    { 15, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diet plan issued", true, null, 1257, "Nutrition Consultation" },
                    { 16, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Updated records", true, null, 1257, "Vaccination" },
                    { 17, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy", true, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9862, "General Checkup" },
                    { 18, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "No issues", true, null, 9862, "Skin Screening" },
                    { 19, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vision normal", true, null, 9862, "Eye Test" },
                    { 20, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "All good", true, null, 9862, "Follow-up" },
                    { 21, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive lifestyle noted", false, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3654, "General Checkup" },
                    { 22, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borderline results", true, null, 3654, "Cardio Stress Test" },
                    { 23, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plan provided", true, null, 3654, "Diet Consultation" },
                    { 24, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improving", true, null, 3654, "Follow-up" },
                    { 25, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mild allergies found", true, null, 4527, "Allergy Test" },
                    { 26, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good health", true, null, 4527, "General Checkup" },
                    { 27, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Results normal", true, null, 4527, "Blood Test" },
                    { 28, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "No issues", true, null, 4527, "X-Ray" },
                    { 29, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inactive status noted", true, null, 6723, "General Checkup" },
                    { 30, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good teeth", true, null, 6723, "Dental Cleaning" },
                    { 31, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reading glasses advised", true, null, 6723, "Eye Examination" },
                    { 32, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clear", true, null, 6723, "Skin Screening" },
                    { 33, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very healthy", true, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7894, "General Checkup" },
                    { 34, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleared for activity", true, null, 7894, "Sports Physical" },
                    { 35, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improved posture", true, null, 7894, "Chiropractic Adjustment" },
                    { 36, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excellent condition", true, null, 7894, "Follow-up" }
                });

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
    }
}
