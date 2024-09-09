﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240908052837_CriandoBandoDeDados")]
    partial class CriandoBandoDeDados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Models.ContribuicaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContribuinteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataPrevista")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdContribuinte")
                        .HasColumnType("int");

                    b.Property<int>("IdMensageiro")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPagamento")
                        .HasColumnType("int");

                    b.Property<int>("MensageiroId")
                        .HasColumnType("int");

                    b.Property<string>("Recibo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoPagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContribuinteId");

                    b.HasIndex("MensageiroId");

                    b.HasIndex("TipoPagamentoId");

                    b.ToTable("Contribuicao");
                });

            modelBuilder.Entity("Backend.Models.ContribuinteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contribuintes");
                });

            modelBuilder.Entity("Backend.Models.MensageiroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mensageiros");
                });

            modelBuilder.Entity("Backend.Models.MovimentoDiarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataMovimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataPrevista")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataRecebimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMensageiro")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPagamento")
                        .HasColumnType("int");

                    b.Property<int>("MensageiroId")
                        .HasColumnType("int");

                    b.Property<string>("Recibo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoPagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MensageiroId");

                    b.HasIndex("TipoPagamentoId");

                    b.ToTable("MovimentoDiario");
                });

            modelBuilder.Entity("Backend.Models.TipoPagamentoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoPagamentos");
                });

            modelBuilder.Entity("Backend.Models.ContribuicaoModel", b =>
                {
                    b.HasOne("Backend.Models.ContribuinteModel", "Contribuinte")
                        .WithMany()
                        .HasForeignKey("ContribuinteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.MensageiroModel", "Mensageiro")
                        .WithMany()
                        .HasForeignKey("MensageiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.TipoPagamentoModel", "TipoPagamento")
                        .WithMany()
                        .HasForeignKey("TipoPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contribuinte");

                    b.Navigation("Mensageiro");

                    b.Navigation("TipoPagamento");
                });

            modelBuilder.Entity("Backend.Models.MovimentoDiarioModel", b =>
                {
                    b.HasOne("Backend.Models.MensageiroModel", "Mensageiro")
                        .WithMany()
                        .HasForeignKey("MensageiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.TipoPagamentoModel", "TipoPagamento")
                        .WithMany()
                        .HasForeignKey("TipoPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mensageiro");

                    b.Navigation("TipoPagamento");
                });
#pragma warning restore 612, 618
        }
    }
}
