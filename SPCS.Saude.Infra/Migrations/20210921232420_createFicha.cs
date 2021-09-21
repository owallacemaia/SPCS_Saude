using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class createFicha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ficha_Pacientes_PacienteId",
                table: "Ficha");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ficha",
                table: "Ficha");

            migrationBuilder.DropColumn(
                name: "MunicipioResidencia",
                table: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Ficha",
                newName: "Fichas");

            migrationBuilder.RenameColumn(
                name: "MunicipioTrabalho",
                table: "Enderecos",
                newName: "Cidade");

            migrationBuilder.RenameIndex(
                name: "IX_Ficha_PacienteId",
                table: "Fichas",
                newName: "IX_Fichas_PacienteId");

            migrationBuilder.AlterColumn<bool>(
                name: "TabagismoAtual",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TabagismoAnterior",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EtilismoAtual",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EtilismoAnterior",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AbortoEspontaneo",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AgitacaoIrritabilidade",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Alt",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "AlteracaoSNervoso",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Ambulatorio",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AparelhoAuditivo",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AparelhoDigestorio",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AparelhoRespiratorio",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AparelhoUrinario",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Arritmia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Ast",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "AziaQueimacao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BotaProtecao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CatarroEscarro",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Ch_e",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Ch_p",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Ch_t",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "CircunferenciaAbdominal",
                table: "Fichas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ColicasDorBarriga",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Creatinina",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "DcIrritativa",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DcSensibilizante",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Diarreia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DificuldadeEngravidar",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DigestorioCancerfamilia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DigestorioCcancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DiminuicaoAudicao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DiminuicaoUrina",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DoencaCardioVascular",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DorCabeca",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DorEstomago",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EdaRegiao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ExposicaoRaiox",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FaltaDeAr",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FamiliaCancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FilhoMaFormacao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Formigamento",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FraquezaMuscular",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GlandularCancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GlandularCancerfamilia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "HabitoAlimentar",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "HipertensaoArterial",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HipotensaoArterial",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Imc",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IncoordenacaoMotora",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IrritacaoOcular",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IrritaçaoNasal",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LuvasProtecao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MascaraProtecao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Medicamento",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MedicamentoContinuo",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MunicipioTrabalho",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NauseasEnjoo",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NomeRemedio",
                table: "Fichas",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "OculosProtecao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Outro",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PeleMucosa",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PeleOssoSangueCancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PeleOssoSangueCancerfamilia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProtetorAuricular",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QuandodiasExposicao",
                table: "Fichas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "RemedioMicose",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ReprodutorCancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ReprodutorCancerfamilia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RespiratorioCancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RespiratorioCancerfamilia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RoupaProtecao",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SNCCancerFamilia",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SncCancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TemFilhos",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TeveCancer",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tosse",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tremedeira",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TremorMuscular",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UrinaescuraSangue",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VertigensTonturas",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VisãoTurvaEmbacada",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Vomito",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Y_gt",
                table: "Fichas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Zumbido",
                table: "Fichas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fichas",
                table: "Fichas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fichas_Pacientes_PacienteId",
                table: "Fichas",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fichas_Pacientes_PacienteId",
                table: "Fichas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fichas",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AbortoEspontaneo",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AgitacaoIrritabilidade",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Alt",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AlteracaoSNervoso",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Ambulatorio",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AparelhoAuditivo",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AparelhoDigestorio",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AparelhoRespiratorio",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AparelhoUrinario",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Arritmia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Ast",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "AziaQueimacao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "BotaProtecao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "CatarroEscarro",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Ch_e",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Ch_p",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Ch_t",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "CircunferenciaAbdominal",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "ColicasDorBarriga",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Creatinina",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DcIrritativa",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DcSensibilizante",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Diarreia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DificuldadeEngravidar",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DigestorioCancerfamilia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DigestorioCcancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DiminuicaoAudicao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DiminuicaoUrina",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DoencaCardioVascular",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DorCabeca",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "DorEstomago",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "EdaRegiao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "ExposicaoRaiox",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "FaltaDeAr",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "FamiliaCancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "FilhoMaFormacao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Formigamento",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "FraquezaMuscular",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "GlandularCancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "GlandularCancerfamilia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "HabitoAlimentar",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "HipertensaoArterial",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "HipotensaoArterial",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Imc",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "IncoordenacaoMotora",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "IrritacaoOcular",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "IrritaçaoNasal",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "LuvasProtecao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "MascaraProtecao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Medicamento",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "MedicamentoContinuo",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "MunicipioTrabalho",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "NauseasEnjoo",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "NomeRemedio",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "OculosProtecao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Outro",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "PeleMucosa",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "PeleOssoSangueCancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "PeleOssoSangueCancerfamilia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "ProtetorAuricular",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "QuandodiasExposicao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "RemedioMicose",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "ReprodutorCancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "ReprodutorCancerfamilia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "RespiratorioCancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "RespiratorioCancerfamilia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "RoupaProtecao",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "SNCCancerFamilia",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "SncCancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "TemFilhos",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "TeveCancer",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Tosse",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Tremedeira",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "TremorMuscular",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "UrinaescuraSangue",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "VertigensTonturas",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "VisãoTurvaEmbacada",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Vomito",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Y_gt",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "Zumbido",
                table: "Fichas");

            migrationBuilder.RenameTable(
                name: "Fichas",
                newName: "Ficha");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Enderecos",
                newName: "MunicipioTrabalho");

            migrationBuilder.RenameIndex(
                name: "IX_Fichas_PacienteId",
                table: "Ficha",
                newName: "IX_Ficha_PacienteId");

            migrationBuilder.AddColumn<string>(
                name: "MunicipioResidencia",
                table: "Enderecos",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "TabagismoAtual",
                table: "Ficha",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "TabagismoAnterior",
                table: "Ficha",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "EtilismoAtual",
                table: "Ficha",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "EtilismoAnterior",
                table: "Ficha",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ficha",
                table: "Ficha",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ficha_Pacientes_PacienteId",
                table: "Ficha",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
