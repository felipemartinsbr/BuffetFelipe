using Microsoft.EntityFrameworkCore.Migrations;

namespace BuffetFelipe.Migrations
{
    public partial class CampoSobrenomeAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Clientes");
        }
    }
}
