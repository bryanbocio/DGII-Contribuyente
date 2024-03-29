﻿// <auto-generated />
using Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(DbContextDGII))]
    [Migration("20240317022623_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Core.Entities.Contribuyentes.ComprobanteFiscal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContribuyenteId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ncf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContribuyenteId");

                    b.ToTable("ComprobantesFiscales");
                });

            modelBuilder.Entity("Core.Entities.Contribuyentes.Contribuyente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActivo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("RncCedula")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoContribuyenteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TipoContribuyenteId");

                    b.ToTable("Contribuyentes");
                });

            modelBuilder.Entity("Core.Entities.Contribuyentes.TipoContribuyente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TiposContribuyente");
                });

            modelBuilder.Entity("Core.Entities.Contribuyentes.ComprobanteFiscal", b =>
                {
                    b.HasOne("Core.Entities.Contribuyentes.Contribuyente", "Contribuyente")
                        .WithMany("ComprobantesFiscales")
                        .HasForeignKey("ContribuyenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contribuyente");
                });

            modelBuilder.Entity("Core.Entities.Contribuyentes.Contribuyente", b =>
                {
                    b.HasOne("Core.Entities.Contribuyentes.TipoContribuyente", "TipoContribuyente")
                        .WithMany()
                        .HasForeignKey("TipoContribuyenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoContribuyente");
                });

            modelBuilder.Entity("Core.Entities.Contribuyentes.Contribuyente", b =>
                {
                    b.Navigation("ComprobantesFiscales");
                });
#pragma warning restore 612, 618
        }
    }
}
