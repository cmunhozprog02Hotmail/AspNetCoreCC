using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetCoreCC.Migrations
{
    public partial class relDeparInstituicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "InstituicaoId",
                table: "Departamento",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IntituicaoId",
                table: "Departamento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_InstituicaoId",
                table: "Departamento",
                column: "InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Instituicao_InstituicaoId",
                table: "Departamento",
                column: "InstituicaoId",
                principalTable: "Instituicao",
                principalColumn: "InstituicaoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Instituicao_InstituicaoId",
                table: "Departamento");

            migrationBuilder.DropIndex(
                name: "IX_Departamento_InstituicaoId",
                table: "Departamento");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Departamento");

            migrationBuilder.DropColumn(
                name: "IntituicaoId",
                table: "Departamento");
        }
    }
}
