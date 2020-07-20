﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using brg.Models;

namespace brg.Migrations
{
    [DbContext(typeof(BRGContext))]
    [Migration("20200720183955_Outros")]
    partial class Outros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BRG.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cargo");

                    b.Property<string>("Departamento");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("brg.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Habilidade");
                });

            modelBuilder.Entity("brg.Models.Trilha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ColaboradorId");

                    b.Property<int>("HabilidadeId");

                    b.Property<DateTime>("Prazo");

                    b.HasKey("Id");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("HabilidadeId");

                    b.ToTable("Trilha");
                });

            modelBuilder.Entity("brg.Models.Trilha", b =>
                {
                    b.HasOne("BRG.Models.Colaborador", "Colaborador")
                        .WithMany("Trilhas")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("brg.Models.Habilidade", "Habilidade")
                        .WithMany("Trilhas")
                        .HasForeignKey("HabilidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}