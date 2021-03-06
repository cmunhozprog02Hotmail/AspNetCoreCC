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
    [Migration("20180411040348_relDeparInstituicao")]
    partial class relDeparInstituicao
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

                    b.Property<long?>("InstituicaoId");

                    b.Property<long?>("IntituicaoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("DepartamentoId");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("AspNetCoreCC.Models.Instituicao", b =>
                {
                    b.Property<long?>("InstituicaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.HasKey("InstituicaoId");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("AspNetCoreCC.Models.Departamento", b =>
                {
                    b.HasOne("AspNetCoreCC.Models.Instituicao", "Instituicao")
                        .WithMany("Departamentos")
                        .HasForeignKey("InstituicaoId");
                });
#pragma warning restore 612, 618
        }
    }
}
