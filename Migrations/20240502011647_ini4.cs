using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudiantePrueba.Migrations
{
    /// <inheritdoc />
    public partial class ini4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Maestro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Estudiantes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Maestro");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Estudiantes");
        }
    }
}
