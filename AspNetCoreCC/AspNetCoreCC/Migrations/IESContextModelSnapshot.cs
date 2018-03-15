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
    partial class IESContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreCC.Models.Departamento", b =>
                {
                    b.Property<long?>("DepartamentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

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
