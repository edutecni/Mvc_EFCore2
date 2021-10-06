﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mvc_EFCore2.Models;

namespace Mvc_EFCore2.Migrations
{
    [DbContext(typeof(AlunoContext))]
    [Migration("20210920093944_IncluirEntidadeTipoSocio")]
    partial class IncluirEntidadeTipoSocio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mvc_EFCore2.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int?>("TipoSocioId");

                    b.HasKey("AlunoId");

                    b.HasIndex("TipoSocioId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Mvc_EFCore2.Models.TipoSocio", b =>
                {
                    b.Property<int>("TipoSocioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DuracaoEmMeses");

                    b.Property<int>("TaxaDesconto");

                    b.HasKey("TipoSocioId");

                    b.ToTable("TipoSocios");
                });

            modelBuilder.Entity("Mvc_EFCore2.Models.Aluno", b =>
                {
                    b.HasOne("Mvc_EFCore2.Models.TipoSocio", "TipoSocio")
                        .WithMany()
                        .HasForeignKey("TipoSocioId");
                });
#pragma warning restore 612, 618
        }
    }
}
