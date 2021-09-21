using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Usuarios_UsuarioId",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Enderecos",
                newName: "PacienteId");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Enderecos",
                newName: "MunicipioTrabalho");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_UsuarioId",
                table: "Enderecos",
                newName: "IX_Enderecos_PacienteId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Escolaridade",
                table: "Usuarios",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Usuarios",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MunicipioResidencia",
                table: "Enderecos",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Ficha",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gestante = table.Column<bool>(type: "bit", nullable: false),
                    Tabagismo = table.Column<bool>(type: "bit", nullable: false),
                    TabagismoAtual = table.Column<bool>(type: "bit", nullable: true),
                    TabagismoAnterior = table.Column<bool>(type: "bit", nullable: true),
                    Etilismo = table.Column<bool>(type: "bit", nullable: false),
                    EtilismoAtual = table.Column<bool>(type: "bit", nullable: true),
                    EtilismoAnterior = table.Column<bool>(type: "bit", nullable: true),
                    IngestaoCafe = table.Column<bool>(type: "bit", nullable: false),
                    CafeMlDia = table.Column<double>(type: "float", nullable: false),
                    RelacaoTrabalho = table.Column<string>(type: "varchar(100)", nullable: true),
                    FuncaoTrabalho = table.Column<string>(type: "varchar(100)", nullable: true),
                    ContatoPraguicida = table.Column<bool>(type: "bit", nullable: false),
                    TempoContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    FrequenciaContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    UltimoContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    FormaAplicacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    ViaExposicao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Adoeceu = table.Column<bool>(type: "bit", nullable: false),
                    QtdVezesAdoeceu = table.Column<string>(type: "varchar(100)", nullable: true),
                    Internado = table.Column<bool>(type: "bit", nullable: false),
                    QtdVezesInternado = table.Column<string>(type: "varchar(100)", nullable: true),
                    QuandoInterndo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TipoContato = table.Column<string>(type: "varchar(100)", nullable: true),
                    EquipamentoProtecao = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ficha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ficha_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ficha_PacienteId",
                table: "Ficha",
                column: "PacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pacientes_PacienteId",
                table: "Enderecos",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pacientes_PacienteId",
                table: "Enderecos");

            migrationBuilder.DropTable(
                name: "Ficha");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Escolaridade",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "MunicipioResidencia",
                table: "Enderecos");

            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "Enderecos",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "MunicipioTrabalho",
                table: "Enderecos",
                newName: "Cidade");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_PacienteId",
                table: "Enderecos",
                newName: "IX_Enderecos_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Usuarios_UsuarioId",
                table: "Enderecos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
