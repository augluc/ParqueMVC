using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exp3.Migrations
{
    public partial class Relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManutencaoId",
                table: "Tbt_Brinquedo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContratosTrabalhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_Contratacoes = table.Column<DateTime>(type: "date", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    ValorSalario = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratosTrabalhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manutencoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    ManutencaoEmDia = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Colaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContratoTrabalhoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Colaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Colaborador_ContratosTrabalhos_ContratoTrabalhoId",
                        column: x => x.ContratoTrabalhoId,
                        principalTable: "ContratosTrabalhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Brinquedo_Colaborador",
                columns: table => new
                {
                    BrinquedoId = table.Column<int>(type: "int", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Brinquedo_Colaborador", x => new { x.BrinquedoId, x.ColaboradorId });
                    table.ForeignKey(
                        name: "FK_Tbl_Brinquedo_Colaborador_Tbl_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Tbl_Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Brinquedo_Colaborador_Tbt_Brinquedo_BrinquedoId",
                        column: x => x.BrinquedoId,
                        principalTable: "Tbt_Brinquedo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbt_Brinquedo_ManutencaoId",
                table: "Tbt_Brinquedo",
                column: "ManutencaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Brinquedo_Colaborador_ColaboradorId",
                table: "Tbl_Brinquedo_Colaborador",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Colaborador_ContratoTrabalhoId",
                table: "Tbl_Colaborador",
                column: "ContratoTrabalhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbt_Brinquedo_Manutencoes_ManutencaoId",
                table: "Tbt_Brinquedo",
                column: "ManutencaoId",
                principalTable: "Manutencoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbt_Brinquedo_Manutencoes_ManutencaoId",
                table: "Tbt_Brinquedo");

            migrationBuilder.DropTable(
                name: "Manutencoes");

            migrationBuilder.DropTable(
                name: "Tbl_Brinquedo_Colaborador");

            migrationBuilder.DropTable(
                name: "Tbl_Colaborador");

            migrationBuilder.DropTable(
                name: "ContratosTrabalhos");

            migrationBuilder.DropIndex(
                name: "IX_Tbt_Brinquedo_ManutencaoId",
                table: "Tbt_Brinquedo");

            migrationBuilder.DropColumn(
                name: "ManutencaoId",
                table: "Tbt_Brinquedo");
        }
    }
}
