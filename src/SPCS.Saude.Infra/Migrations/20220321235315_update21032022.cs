using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class update21032022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ambulatorio",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "HabitoAlimentar",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "IrritaçaoNasal",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Ambulatorio",
                table: "Amostras");

            migrationBuilder.DropColumn(
                name: "HabitoAlimentarDiscretizado",
                table: "Amostras");

            migrationBuilder.DropColumn(
                name: "Outro",
                table: "Amostras");

            migrationBuilder.RenameColumn(
                name: "Outro",
                table: "Fichas",
                newName: "IrritacaoNasal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IrritacaoNasal",
                table: "Fichas",
                newName: "Outro");

            migrationBuilder.AddColumn<string>(
                name: "Ambulatorio",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HabitoAlimentar",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IrritaçaoNasal",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ambulatorio",
                table: "Amostras",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HabitoAlimentarDiscretizado",
                table: "Amostras",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Outro",
                table: "Amostras",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
