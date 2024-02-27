﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zalba_Mikroservis.Data;

#nullable disable

namespace Zalba_Mikroservis.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230214133447_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Zalba_Mikroservis.Models.KupacVO", b =>
                {
                    b.Property<int>("KupacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KupacID"), 1L, 1);

                    b.Property<DateTime>("DatumPocetkaZabrane")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPrestankaZabrane")
                        .HasColumnType("datetime2");

                    b.Property<int>("DuzinaTrajanjaZabraneUGodinama")
                        .HasColumnType("int");

                    b.Property<bool>("ImaZabranu")
                        .HasColumnType("bit");

                    b.Property<int?>("KupacVOKupacID")
                        .HasColumnType("int");

                    b.Property<string>("Lice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OstvarenaPovrsina")
                        .HasColumnType("int");

                    b.Property<string>("Prioritet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KupacID");

                    b.HasIndex("KupacVOKupacID");

                    b.ToTable("KupacVOs");
                });

            modelBuilder.Entity("Zalba_Mikroservis.Models.Zalba", b =>
                {
                    b.Property<int>("ZalbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZalbaID"), 1L, 1);

                    b.Property<string>("BrojOdluka_BrojNadmetanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojResenja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumPodnosenjaZalbe")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumResenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KupacID")
                        .HasColumnType("int");

                    b.Property<string>("Obrazlozenje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PodnosilacZalbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RadnjaNaOsnovuZalbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazlogZalbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusZalbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZalbaID");

                    b.HasIndex("KupacID");

                    b.ToTable("Zalbas");
                });

            modelBuilder.Entity("Zalba_Mikroservis.Models.KupacVO", b =>
                {
                    b.HasOne("Zalba_Mikroservis.Models.KupacVO", null)
                        .WithMany("Kupac")
                        .HasForeignKey("KupacVOKupacID");
                });

            modelBuilder.Entity("Zalba_Mikroservis.Models.Zalba", b =>
                {
                    b.HasOne("Zalba_Mikroservis.Models.KupacVO", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");
                });

            modelBuilder.Entity("Zalba_Mikroservis.Models.KupacVO", b =>
                {
                    b.Navigation("Kupac");
                });
#pragma warning restore 612, 618
        }
    }
}
