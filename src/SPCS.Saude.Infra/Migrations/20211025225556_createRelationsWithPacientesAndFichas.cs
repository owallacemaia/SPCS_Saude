using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class createRelationsWithPacientesAndFichas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FichaId",
                table: "Diagnosticos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_FichaId",
                table: "Diagnosticos",
                column: "FichaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosticos_Fichas_FichaId",
                table: "Diagnosticos",
                column: "FichaId",
                principalTable: "Fichas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosticos_Fichas_FichaId",
                table: "Diagnosticos");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_FichaId",
                table: "Diagnosticos");

            migrationBuilder.DropColumn(
                name: "FichaId",
                table: "Diagnosticos");
        }
    }
}
