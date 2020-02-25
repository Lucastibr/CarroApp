using Microsoft.EntityFrameworkCore.Migrations;

namespace CarroApp.Migrations
{
    public partial class RemoverImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Carro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Carro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
