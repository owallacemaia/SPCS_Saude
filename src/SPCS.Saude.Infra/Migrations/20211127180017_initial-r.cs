using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class initialr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IrritaçaoNasal",
                table: "Fichas",
                newName: "IrritacaoNasal");

            migrationBuilder.RenameColumn(
                name: "IrritaçaoNasal",
                table: "Amostras",
                newName: "IrritacaoNasal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IrritacaoNasal",
                table: "Fichas",
                newName: "IrritaçaoNasal");

            migrationBuilder.RenameColumn(
                name: "IrritacaoNasal",
                table: "Amostras",
                newName: "IrritaçaoNasal");
        }
    }
}
