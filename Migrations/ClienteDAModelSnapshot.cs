﻿// <auto-generated />
using BasicApi.DataAcces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasicApi.Migrations
{
    [DbContext(typeof(MainDA))]
    partial class ClienteDAModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BasicApi.ViewData.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NmCliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BasicApi.ViewData.ProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DscProduto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("VlrUnitario")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("BasicApi.ViewData.VendaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DthVenda")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<long>("QtdVenda")
                        .HasColumnType("bigint");

                    b.Property<long>("VlrTotalVenda")
                        .HasColumnType("bigint");

                    b.Property<long>("VlrUnitarioVenda")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Venda");
                });
#pragma warning restore 612, 618
        }
    }
}
