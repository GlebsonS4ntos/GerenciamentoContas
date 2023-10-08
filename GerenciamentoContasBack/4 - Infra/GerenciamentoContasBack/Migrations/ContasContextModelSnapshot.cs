﻿// <auto-generated />
using System;
using GerenciamentoContasBack.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentoContasBack.Infra.Migrations
{
    [DbContext(typeof(ContasContext))]
    partial class ContasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMesAtual")
                        .HasColumnType("bit");

                    b.Property<int>("QuantidadeParcelas")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.PagamentoMensal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataParcela")
                        .HasColumnType("datetime2");

                    b.Property<int>("Parcela")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.ToTable("PagamentosMensais");
                });

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.TipoConta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.HasIndex("TipoId");

                    b.ToTable("TiposContas");
                });

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.PagamentoMensal", b =>
                {
                    b.HasOne("GerenciamentoContasBack.Dominio.Entities.Conta", "Conta")
                        .WithMany("PagementosMensais")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.TipoConta", b =>
                {
                    b.HasOne("GerenciamentoContasBack.Dominio.Entities.Conta", "Conta")
                        .WithMany("TiposContas")
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciamentoContasBack.Dominio.Entities.Tipo", "Tipo")
                        .WithMany("TiposContas")
                        .HasForeignKey("TipoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Conta");

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.Conta", b =>
                {
                    b.Navigation("PagementosMensais");

                    b.Navigation("TiposContas");
                });

            modelBuilder.Entity("GerenciamentoContasBack.Dominio.Entities.Tipo", b =>
                {
                    b.Navigation("TiposContas");
                });
#pragma warning restore 612, 618
        }
    }
}