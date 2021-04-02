﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XPTO.Infrastructure;

namespace XPTO.Migrations
{
    [DbContext(typeof(XPTOContext))]
    [Migration("20210402153201_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XPTO.Domain.Entities.Ativo", b =>
                {
                    b.Property<int>("AtivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaAtivoId")
                        .HasColumnType("int");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("AtivoId");

                    b.HasIndex("CategoriaAtivoId");

                    b.ToTable("Ativos","xpto");
                });

            modelBuilder.Entity("XPTO.Domain.Entities.CategoriaAtivo", b =>
                {
                    b.Property<int>("CategoriaAtivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("CategoriaAtivoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("CategoriaAtivos","xpto");
                });

            modelBuilder.Entity("XPTO.Domain.Entities.CompraAtivo", b =>
                {
                    b.Property<int>("CompraAtivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtivoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("CompraAtivoId");

                    b.HasIndex("AtivoId");

                    b.ToTable("CompraAtivos","xpto");
                });

            modelBuilder.Entity("XPTO.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios","xpto");
                });

            modelBuilder.Entity("XPTO.Domain.Entities.VendaAtivo", b =>
                {
                    b.Property<int>("VendaAtivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtivoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("VendaAtivoId");

                    b.HasIndex("AtivoId");

                    b.ToTable("VendaAtivos","xpto");
                });

            modelBuilder.Entity("XPTO.Domain.Entities.Ativo", b =>
                {
                    b.HasOne("XPTO.Domain.Entities.CategoriaAtivo", "CategoriaAtivo")
                        .WithMany("Ativos")
                        .HasForeignKey("CategoriaAtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XPTO.Domain.Entities.CategoriaAtivo", b =>
                {
                    b.HasOne("XPTO.Domain.Entities.Usuario", "Usuario")
                        .WithMany("CategoriaAtivos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XPTO.Domain.Entities.CompraAtivo", b =>
                {
                    b.HasOne("XPTO.Domain.Entities.Ativo", "Ativo")
                        .WithMany("CompraAtivos")
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XPTO.Domain.Entities.VendaAtivo", b =>
                {
                    b.HasOne("XPTO.Domain.Entities.Ativo", "Ativo")
                        .WithMany("VendaAtivos")
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}