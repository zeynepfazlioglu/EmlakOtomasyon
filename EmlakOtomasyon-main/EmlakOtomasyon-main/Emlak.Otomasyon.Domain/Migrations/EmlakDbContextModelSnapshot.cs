﻿// <auto-generated />
using Emlak.Otomasyon.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Emlak.Otomasyon.Domain.Migrations
{
    [DbContext(typeof(EmlakDbContext))]
    partial class EmlakDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Emlak.Otomasyon.Model.Entity.Emlak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmlakTipi")
                        .HasColumnType("int");

                    b.Property<string>("Ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("alan")
                        .HasColumnType("int");

                    b.Property<int>("durum")
                        .HasColumnType("int");

                    b.Property<int>("fiyat")
                        .HasColumnType("int");

                    b.Property<int>("odasayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Emlak");
                });
#pragma warning restore 612, 618
        }
    }
}
