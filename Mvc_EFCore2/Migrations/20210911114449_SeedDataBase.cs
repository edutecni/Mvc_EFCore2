using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_EFCore2.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ALUNOS VALUES('Eduardo','M', 'edutecni@hotmail.com', '1976/12/01')");
            migrationBuilder.Sql("INSERT INTO ALUNOS VALUES('Viviane','F', 'vivi@ig.com.br', '1975/03/23')");
            migrationBuilder.Sql("INSERT INTO ALUNOS VALUES('Thiago','M', 'tiaguinhofac@yahoo.com.br', '2004/05/10')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ALUNOS");
        }
    }
}
