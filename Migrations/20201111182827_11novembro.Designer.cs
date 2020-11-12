﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app02.Data;

namespace app02.Migrations
{
    [DbContext(typeof(app02Context))]
    [Migration("20201111182827_11novembro")]
    partial class _11novembro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("app02.Models.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("app02.Models.Entidades.Indices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Juros");

                    b.Property<double>("Multa");

                    b.Property<DateTime>("Periodo");

                    b.HasKey("Id");

                    b.ToTable("Indices");
                });

            modelBuilder.Entity("app02.Models.Entidades.Titulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("Documento");

                    b.Property<DateTime>("Emissao");

                    b.Property<double>("Juros");

                    b.Property<double>("Multa");

                    b.Property<DateTime>("Pagamento");

                    b.Property<int>("Status");

                    b.Property<double>("Totalpago");

                    b.Property<double>("Valor");

                    b.Property<DateTime>("Vencimento");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Titulos");
                });

            modelBuilder.Entity("app02.Models.Entidades.Titulo", b =>
                {
                    b.HasOne("app02.Models.Entidades.Cliente", "Cliente")
                        .WithMany("Titulos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}