using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notus.Migrations
{
    /// <inheritdoc />
    public partial class actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstudiantesIds",
                table: "Clases");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "Clases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "Clases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstudiantesIds",
                table: "Clases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
