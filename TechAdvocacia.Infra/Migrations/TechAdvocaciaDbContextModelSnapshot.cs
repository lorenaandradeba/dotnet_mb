﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechAdvocacia.Infra;

#nullable disable

namespace TechAdvocacia.Infra.Migrations
{
    [DbContext(typeof(TechAdvocaciaDbContext))]
    partial class TechAdvocaciaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TechAdvocacia.Core.Entities.Advogado", b =>
                {
                    b.Property<int>("AdvogadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNA")
                        .HasColumnType("longtext");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("AdvogadoId");

                    b.ToTable("Advogados", (string)null);
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.CasoJuridico", b =>
                {
                    b.Property<int>("CasoJuridicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdvogadoId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CasoJuridicoId");

                    b.HasIndex("AdvogadoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("CasoJuridicos", (string)null);
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.Documento", b =>
                {
                    b.Property<int>("DocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CasoJuridicoId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Modificacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DocumentoId");

                    b.HasIndex("CasoJuridicoId");

                    b.ToTable("Documentos", (string)null);
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.CasoJuridico", b =>
                {
                    b.HasOne("TechAdvocacia.Core.Entities.Advogado", "Advogado")
                        .WithMany("CasosJuridicos")
                        .HasForeignKey("AdvogadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechAdvocacia.Core.Entities.Cliente", "Cliente")
                        .WithMany("CasosJuridicos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advogado");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.Documento", b =>
                {
                    b.HasOne("TechAdvocacia.Core.Entities.CasoJuridico", "CasoJuridico")
                        .WithMany("Documentos")
                        .HasForeignKey("CasoJuridicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CasoJuridico");
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.Advogado", b =>
                {
                    b.Navigation("CasosJuridicos");
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.CasoJuridico", b =>
                {
                    b.Navigation("Documentos");
                });

            modelBuilder.Entity("TechAdvocacia.Core.Entities.Cliente", b =>
                {
                    b.Navigation("CasosJuridicos");
                });
#pragma warning restore 612, 618
        }
    }
}
