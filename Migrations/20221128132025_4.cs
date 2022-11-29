using Microsoft.EntityFrameworkCore.Migrations;

namespace HastaneMvc.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoktorSoyadi",
                table: "DoktorDb",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoktorSoyadi",
                table: "DoktorDb");
        }
    }
}
