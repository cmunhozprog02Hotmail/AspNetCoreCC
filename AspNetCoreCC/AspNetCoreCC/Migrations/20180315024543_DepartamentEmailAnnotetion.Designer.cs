﻿// <auto-generated />
using AspNetCoreCC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspNetCoreCC.Migrations
{
    [DbContext(typeof(IESContext))]
    [Migration("20180315024543_DepartamentEmailAnnotetion")]
    partial class DepartamentEmailAnnotetion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreCC.Models.Departamento", b =>
                {
                    b.Property<long?>("DepartamentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("AspNetCoreCC.Models.Instituicao", b =>
                {
                    b.Property<long?>("InstituicaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.HasKey("InstituicaoId");

                    b.ToTable("Instituicoes");
                });
#pragma warning restore 612, 618
        }
    }
}