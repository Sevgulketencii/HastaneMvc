using Microsoft.EntityFrameworkCore.Migrations;

namespace HastaneMvc.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoktorYetki",
                table: "DoktorDb",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoktorYetki",
                table: "DoktorDb");
        }
    }
}
