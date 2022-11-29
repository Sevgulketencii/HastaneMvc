using Microsoft.EntityFrameworkCore.Migrations;

namespace HastaneMvc.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "okundu",
                table: "RandevuDb",
                newName: "Bayrak");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bayrak",
                table: "RandevuDb",
                newName: "okundu");
        }
    }
}
