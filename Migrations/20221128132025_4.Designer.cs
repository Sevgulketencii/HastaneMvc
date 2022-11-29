﻿// <auto-generated />
using System;
using HastaneMvc.Models.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HastaneMvc.Migrations
{
    [DbContext(typeof(Dbcontext))]
    [Migration("20221128132025_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminSifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("AdminDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Anasayfa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AnasayfaDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Doktor", b =>
                {
                    b.Property<int>("DoktorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DoktorAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoktorAlani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoktorFcLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoktorImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoktorSoyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoktorTwLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoktorYetki")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoktorId");

                    b.ToTable("DoktorDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Haberler", b =>
                {
                    b.Property<int>("HaberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Etiket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("HaberId");

                    b.ToTable("HaberlerDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Hakkında", b =>
                {
                    b.Property<int>("HakkımızdaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HaberAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaberBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkımızdaId");

                    b.ToTable("HakkındaDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Iletisim", b =>
                {
                    b.Property<int>("IletisimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IletisimAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimPosta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimTel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IletisimId");

                    b.ToTable("IletisimDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Randevu", b =>
                {
                    b.Property<int>("HastaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HastaAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HastaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HastaMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HastaSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HastalikAlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("HastaId");

                    b.ToTable("RandevuDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Yorum", b =>
                {
                    b.Property<int>("YorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HaberId")
                        .HasColumnType("int");

                    b.Property<int?>("HaberlerHaberId")
                        .HasColumnType("int");

                    b.Property<string>("YorumAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumMail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumId");

                    b.HasIndex("HaberlerHaberId");

                    b.ToTable("YorumDb");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Yorum", b =>
                {
                    b.HasOne("HastaneMvc.Models.Sınıflar.Haberler", "Haberler")
                        .WithMany("Yorums")
                        .HasForeignKey("HaberlerHaberId");

                    b.Navigation("Haberler");
                });

            modelBuilder.Entity("HastaneMvc.Models.Sınıflar.Haberler", b =>
                {
                    b.Navigation("Yorums");
                });
#pragma warning restore 612, 618
        }
    }
}
