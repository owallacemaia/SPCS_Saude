using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class configureRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_TiposUsuario_TipoUsuarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_TipoUsuarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_FichaId",
                table: "Diagnosticos");

            migrationBuilder.DropColumn(
                name: "TipoUsuarioId",
                table: "Pacientes");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_FichaId",
                table: "Diagnosticos",
                column: "FichaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Diagnosticos_FichaId",
                table: "Diagnosticos");

            migrationBuilder.AddColumn<Guid>(
                name: "TipoUsuarioId",
                table: "Pacientes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TipoUsuarioId",
                table: "Pacientes",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_FichaId",
                table: "Diagnosticos",
                column: "FichaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_TiposUsuario_TipoUsuarioId",
                table: "Pacientes",
                column: "TipoUsuarioId",
                principalTable: "TiposUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
