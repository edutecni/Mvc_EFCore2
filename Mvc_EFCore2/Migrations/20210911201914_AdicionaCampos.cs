using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_EFCore2.Migrations
{
    public partial class AdicionaCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Alunos",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Texto",
                table: "Alunos",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Texto",
                table: "Alunos");
        }
    }
}
