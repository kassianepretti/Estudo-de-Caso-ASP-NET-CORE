using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SisRh.Infra.Data.Context.Migrations
{
    public partial class RelationshipManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpregadoBeneficio",
                columns: table => new
                {
                    CodEmpregado = table.Column<int>(type: "int", nullable: false),
                    CodBeneficio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpregadoBeneficio", x => new { x.CodEmpregado, x.CodBeneficio });
                    table.ForeignKey(
                        name: "FK_EmpregadoBeneficio_Beneficio_CodBeneficio",
                        column: x => x.CodBeneficio,
                        principalTable: "Beneficio",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpregadoBeneficio_Empregado_CodEmpregado",
                        column: x => x.CodEmpregado,
                        principalTable: "Empregado",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });
            

            migrationBuilder.CreateIndex(
                name: "IX_EmpregadoBeneficio_CodBeneficio",
                table: "EmpregadoBeneficio",
                column: "CodBeneficio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpregadoBeneficio");
        }
    }
}
