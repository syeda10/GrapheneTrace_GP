using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrapheneTrace_GP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicianId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianSpeciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicianAge = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinicians", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clinicians");
        }
    }
}
