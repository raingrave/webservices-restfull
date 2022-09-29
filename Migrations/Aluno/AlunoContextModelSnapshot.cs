﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using WebServiceRestfull.Data;

#nullable disable

namespace WebServiceRestfull.Migrations.Aluno
{
    [DbContext(typeof(AlunoContext))]
    partial class AlunoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebServiceRestfull.Entities.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Altura")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("ALTURA");

                    b.Property<int>("Genero")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("GENERO");

                    b.Property<int>("Idade")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("IDADE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NOME");

                    b.Property<double>("Peso")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("PESO");

                    b.HasKey("Id");

                    b.ToTable("ALUNO");
                });
#pragma warning restore 612, 618
        }
    }
}