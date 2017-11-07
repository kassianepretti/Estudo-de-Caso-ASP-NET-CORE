using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SisRh.Infra.Data.Context.Migrations
{
    public partial class RelationshipOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodSetor",
                table: "Empregado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Codigo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empregado_CodSetor",
                table: "Empregado",
                column: "CodSetor");

            migrationBuilder.AddForeignKey(
                name: "FK_Empregado_Setor_CodSetor",
                table: "Empregado",
                column: "CodSetor",
                principalTable: "Setor",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empregado_Setor_CodSetor",
                table: "Empregado");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropIndex(
                name: "IX_Empregado_CodSetor",
                table: "Empregado");

            migrationBuilder.DropColumn(
                name: "CodSetor",
                table: "Empregado");
        }
    }
}
