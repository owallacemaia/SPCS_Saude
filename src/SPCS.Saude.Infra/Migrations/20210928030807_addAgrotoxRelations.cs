using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class addAgrotoxRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FichaAgro",
                columns: table => new
                {
                    FichaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgrotoxicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichaAgro", x => new { x.FichaId, x.AgrotoxicoId });
                    table.ForeignKey(
                        name: "FK_FichaAgro_Agrotoxicos_AgrotoxicoId",
                        column: x => x.AgrotoxicoId,
                        principalTable: "Agrotoxicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FichaAgro_Fichas_FichaId",
                        column: x => x.FichaId,
                        principalTable: "Fichas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FichaAgro_AgrotoxicoId",
                table: "FichaAgro",
                column: "AgrotoxicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FichaAgro");
        }
    }
}
