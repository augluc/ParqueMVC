using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exp3.Migrations
{
    public partial class AdicaoChaveData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Brinquedo_Colaborador",
                table: "Tbl_Brinquedo_Colaborador");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Tbl_Brinquedo_Colaborador",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Brinquedo_Colaborador",
                table: "Tbl_Brinquedo_Colaborador",
                columns: new[] { "BrinquedoId", "ColaboradorId", "Data" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Brinquedo_Colaborador",
                table: "Tbl_Brinquedo_Colaborador");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Tbl_Brinquedo_Colaborador");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Brinquedo_Colaborador",
                table: "Tbl_Brinquedo_Colaborador",
                columns: new[] { "BrinquedoId", "ColaboradorId" });
        }
    }
}
