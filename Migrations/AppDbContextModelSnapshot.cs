﻿// <auto-generated />
using APIProduct.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIProduct.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("APIProduct.Models.Product", b =>
                {
                    b.Property<int>("Id_Produto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foto_Produto")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("Id_Tipo_Produto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome_Produto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Unidade_Medida")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.HasKey("Id_Produto");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
