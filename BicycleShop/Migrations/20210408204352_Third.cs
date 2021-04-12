using Microsoft.EntityFrameworkCore.Migrations;

namespace BicycleShop.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colors",
                table: "Colors");

            migrationBuilder.AddColumn<string>(
                name: "ColorName",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorName",
                table: "Colors");

            migrationBuilder.AddColumn<int>(
                name: "Colors",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
