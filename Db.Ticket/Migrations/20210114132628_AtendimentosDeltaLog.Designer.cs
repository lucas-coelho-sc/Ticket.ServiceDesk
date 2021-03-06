﻿// <auto-generated />
using AtendimentosSD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.AtendimentosSD.Migrations
{
    [DbContext(typeof(Ticketcontext))]
    [Migration("20210114132628_AtendimentosDeltaLog")]
    partial class AtendimentosDeltaLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ClasseDeTabela.TblAtendimentoDeltaLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Acao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Analista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Imei")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Monitor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motorista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Problema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AtendimentosDeltaLog");
                });

            modelBuilder.Entity("Classes.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Analista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ticket")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
