using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class ajusteficha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClasseProduto3",
                table: "Amostras",
                newName: "PrincipioAtivo2");

            migrationBuilder.RenameColumn(
                name: "ClasseProduto2",
                table: "Amostras",
                newName: "PrincipioAtivo1");

            migrationBuilder.RenameColumn(
                name: "ClasseProduto1",
                table: "Amostras",
                newName: "NomeComercial");

            migrationBuilder.AddColumn<string>(
                name: "Cultura",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoContatoUltimaVez",
                table: "Fichas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Cultura",
                table: "Amostras",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cultura",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "ProdutoContatoUltimaVez",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Cultura",
                table: "Amostras");

            migrationBuilder.RenameColumn(
                name: "PrincipioAtivo2",
                table: "Amostras",
                newName: "ClasseProduto3");

            migrationBuilder.RenameColumn(
                name: "PrincipioAtivo1",
                table: "Amostras",
                newName: "ClasseProduto2");

            migrationBuilder.RenameColumn(
                name: "NomeComercial",
                table: "Amostras",
                newName: "ClasseProduto1");
        }
    }
}
