using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class RefacorModelFicha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisãoTurvaEmbacada",
                table: "Fichas",
                newName: "VisaoTurvaEmbacada");

            migrationBuilder.RenameColumn(
                name: "DigestorioCcancer",
                table: "Fichas",
                newName: "DigestorioCancer");

            migrationBuilder.RenameColumn(
                name: "DigestorioCcancer",
                table: "Amostras",
                newName: "NomeRemedio");

            migrationBuilder.AddColumn<string>(
                name: "DigestorioCancer",
                table: "Amostras",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DigestorioCancer",
                table: "Amostras");

            migrationBuilder.RenameColumn(
                name: "VisaoTurvaEmbacada",
                table: "Fichas",
                newName: "VisãoTurvaEmbacada");

            migrationBuilder.RenameColumn(
                name: "DigestorioCancer",
                table: "Fichas",
                newName: "DigestorioCcancer");

            migrationBuilder.RenameColumn(
                name: "NomeRemedio",
                table: "Amostras",
                newName: "DigestorioCcancer");
        }
    }
}
