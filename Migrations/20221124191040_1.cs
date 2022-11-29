using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HastaneMvc.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnasayfaDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnasayfaDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoktorDb",
                columns: table => new
                {
                    DoktorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoktorAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorAlani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorFcLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoktorTwLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoktorDb", x => x.DoktorId);
                });

            migrationBuilder.CreateTable(
                name: "HaberlerDb",
                columns: table => new
                {
                    HaberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaberAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaberImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etiket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaberlerDb", x => x.HaberId);
                });

            migrationBuilder.CreateTable(
                name: "HakkındaDb",
                columns: table => new
                {
                    HakkımızdaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaberAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HakkındaDb", x => x.HakkımızdaId);
                });

            migrationBuilder.CreateTable(
                name: "IletisimDb",
                columns: table => new
                {
                    IletisimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimPosta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimDb", x => x.IletisimId);
                });

            migrationBuilder.CreateTable(
                name: "RandevuDb",
                columns: table => new
                {
                    HastaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HastaSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HastalikAlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HastaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandevuDb", x => x.HastaId);
                });

            migrationBuilder.CreateTable(
                name: "YorumDb",
                columns: table => new
                {
                    YorumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaberId = table.Column<int>(type: "int", nullable: false),
                    HaberlerHaberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YorumDb", x => x.YorumId);
                    table.ForeignKey(
                        name: "FK_YorumDb_HaberlerDb_HaberlerHaberId",
                        column: x => x.HaberlerHaberId,
                        principalTable: "HaberlerDb",
                        principalColumn: "HaberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YorumDb_HaberlerHaberId",
                table: "YorumDb",
                column: "HaberlerHaberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnasayfaDb");

            migrationBuilder.DropTable(
                name: "DoktorDb");

            migrationBuilder.DropTable(
                name: "HakkındaDb");

            migrationBuilder.DropTable(
                name: "IletisimDb");

            migrationBuilder.DropTable(
                name: "RandevuDb");

            migrationBuilder.DropTable(
                name: "YorumDb");

            migrationBuilder.DropTable(
                name: "HaberlerDb");
        }
    }
}
