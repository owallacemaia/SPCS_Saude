using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPCS.Saude.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agrotoxicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(250)", nullable: false),
                    PrincipioAtivo = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agrotoxicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Amostras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdadeDiscretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Gestante = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tabagismo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TabagismoAtual = table.Column<string>(type: "varchar(100)", nullable: true),
                    TabagismoAnterior = table.Column<string>(type: "varchar(100)", nullable: true),
                    Etilismo = table.Column<string>(type: "varchar(100)", nullable: true),
                    EtilismoAtual = table.Column<string>(type: "varchar(100)", nullable: true),
                    EtilismoAnterior = table.Column<string>(type: "varchar(100)", nullable: true),
                    IngestaoCafe = table.Column<string>(type: "varchar(100)", nullable: true),
                    CafeMldiaDiscretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    RelacaoTrabalho = table.Column<string>(type: "varchar(100)", nullable: true),
                    FuncaoTrabalho = table.Column<string>(type: "varchar(100)", nullable: true),
                    ContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    TempoContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    FrequenciaContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    UltimoContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClasseProduto1 = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClasseProduto2 = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClasseProduto3 = table.Column<string>(type: "varchar(100)", nullable: true),
                    FormaAplicacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    ViaExposicao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Adoeceu = table.Column<string>(type: "varchar(100)", nullable: true),
                    NVezesAdoeceu = table.Column<string>(type: "varchar(100)", nullable: true),
                    Internado = table.Column<string>(type: "varchar(100)", nullable: true),
                    NvezesInternado = table.Column<string>(type: "varchar(100)", nullable: true),
                    QuandoInternado = table.Column<string>(type: "varchar(100)", nullable: true),
                    TipoContato = table.Column<string>(type: "varchar(100)", nullable: true),
                    EquipamentoProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    RoupaProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    BotaProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    LuvasProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    MascaraProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    OculosProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProtetorAuricular = table.Column<string>(type: "varchar(100)", nullable: true),
                    DoencaCardioVascular = table.Column<string>(type: "varchar(100)", nullable: true),
                    HipertensaoArterial = table.Column<string>(type: "varchar(100)", nullable: true),
                    HipotensaoArterial = table.Column<string>(type: "varchar(100)", nullable: true),
                    Arritmia = table.Column<string>(type: "varchar(100)", nullable: true),
                    AlteracaoSNervoso = table.Column<string>(type: "varchar(100)", nullable: true),
                    DorCabeca = table.Column<string>(type: "varchar(100)", nullable: true),
                    FraquezaMuscular = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tremedeira = table.Column<string>(type: "varchar(100)", nullable: true),
                    TremorMuscular = table.Column<string>(type: "varchar(100)", nullable: true),
                    VisaoTurvaEmbacada = table.Column<string>(type: "varchar(100)", nullable: true),
                    AgitacaoIrritabilidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    VertigensTonturas = table.Column<string>(type: "varchar(100)", nullable: true),
                    Formigamento = table.Column<string>(type: "varchar(100)", nullable: true),
                    IncoordenacaoMotora = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoDigestorio = table.Column<string>(type: "varchar(100)", nullable: true),
                    ColicasDorBarriga = table.Column<string>(type: "varchar(100)", nullable: true),
                    DorEstomago = table.Column<string>(type: "varchar(100)", nullable: true),
                    AziaQueimacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    NauseasEnjoo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Vomito = table.Column<string>(type: "varchar(100)", nullable: true),
                    Diarreia = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoRespiratorio = table.Column<string>(type: "varchar(100)", nullable: true),
                    FaltaDeAr = table.Column<string>(type: "varchar(100)", nullable: true),
                    IrritaçaoNasal = table.Column<string>(type: "varchar(100)", nullable: true),
                    CatarroEscarro = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tosse = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoAuditivo = table.Column<string>(type: "varchar(100)", nullable: true),
                    DiminuicaoAudicao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Zumbido = table.Column<string>(type: "varchar(100)", nullable: true),
                    PeleMucosa = table.Column<string>(type: "varchar(100)", nullable: true),
                    DcSensibilizante = table.Column<string>(type: "varchar(100)", nullable: true),
                    DcIrritativa = table.Column<string>(type: "varchar(100)", nullable: true),
                    IrritacaoOcular = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoUrinario = table.Column<string>(type: "varchar(100)", nullable: true),
                    DiminuicaoUrina = table.Column<string>(type: "varchar(100)", nullable: true),
                    UrinaescuraSangue = table.Column<string>(type: "varchar(100)", nullable: true),
                    Outro = table.Column<string>(type: "varchar(100)", nullable: true),
                    ExposicaoRaiox = table.Column<string>(type: "varchar(100)", nullable: true),
                    QuandodiasExposicao = table.Column<string>(type: "varchar(100)", nullable: true),
                    TeveCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    SncCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    DigestorioCcancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    RespiratorioCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    ReprodutorCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    GlandularCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    PeleOssoSangueCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    FamiliaCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    SNCCancerFamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    DigestorioCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    RespiratorioCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    ReprodutorCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    GlandularCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    PeleOssoSangueCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    EdaRegiao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ch_t_discretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ch_e_discretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ch_p_discretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ast_discretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Alt_discretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Y_gt_discretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreatininaDiscretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ambulatorio = table.Column<string>(type: "varchar(100)", nullable: true),
                    HabitoAlimentarDiscretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    ImcDiscretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    CircunferenciaAbdominalDiscretizado = table.Column<string>(type: "varchar(100)", nullable: true),
                    DificuldadeEngravidar = table.Column<string>(type: "varchar(100)", nullable: true),
                    AbortoEspontaneo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TemFilhos = table.Column<string>(type: "varchar(100)", nullable: true),
                    FilhoMaFormacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    MedicamentoContinuo = table.Column<string>(type: "varchar(100)", nullable: true),
                    RemedioMicose = table.Column<string>(type: "varchar(100)", nullable: true),
                    SiglaDiagnostico = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amostras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(100)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefreshToken = table.Column<string>(type: "varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enfermeiros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(9)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(11)", nullable: false),
                    Coren = table.Column<string>(type: "varchar(250)", nullable: false),
                    TipoUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermeiros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enfermeiros_TiposUsuario_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TiposUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(9)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(11)", nullable: false),
                    Crm = table.Column<string>(type: "varchar(250)", nullable: false),
                    TipoUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicos_TiposUsuario_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TiposUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(9)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(11)", nullable: false),
                    Escolaridade = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_TiposUsuario_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TiposUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    Imagem = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sexo = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(100)", nullable: true),
                    TipoUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_TiposUsuario_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TiposUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(200)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(50)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(250)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cep = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fichas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MunicipioTrabalho = table.Column<string>(type: "varchar(100)", nullable: true),
                    Gestante = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tabagismo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TabagismoAtual = table.Column<string>(type: "varchar(100)", nullable: true),
                    TabagismoAnterior = table.Column<string>(type: "varchar(100)", nullable: true),
                    Etilismo = table.Column<string>(type: "varchar(100)", nullable: true),
                    EtilismoAtual = table.Column<string>(type: "varchar(100)", nullable: true),
                    EtilismoAnterior = table.Column<string>(type: "varchar(100)", nullable: true),
                    IngestaoCafe = table.Column<string>(type: "varchar(100)", nullable: true),
                    CafeMlDia = table.Column<string>(type: "varchar(100)", nullable: true),
                    RelacaoTrabalho = table.Column<string>(type: "varchar(100)", nullable: true),
                    FuncaoTrabalho = table.Column<string>(type: "varchar(100)", nullable: true),
                    ContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    TempoContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    FrequenciaContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    UltimoContatoPraguicida = table.Column<string>(type: "varchar(100)", nullable: true),
                    FormaAplicacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    ViaExposicao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Adoeceu = table.Column<string>(type: "varchar(100)", nullable: true),
                    QtdVezesAdoeceu = table.Column<string>(type: "varchar(100)", nullable: true),
                    Internado = table.Column<string>(type: "varchar(100)", nullable: true),
                    QtdVezesInternado = table.Column<string>(type: "varchar(100)", nullable: true),
                    QuandoInterndo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TipoContato = table.Column<string>(type: "varchar(100)", nullable: true),
                    EquipamentoProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    RoupaProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    BotaProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    LuvasProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    MascaraProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    OculosProtecao = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProtetorAuricular = table.Column<string>(type: "varchar(100)", nullable: true),
                    DoencaCardioVascular = table.Column<string>(type: "varchar(100)", nullable: true),
                    HipertensaoArterial = table.Column<string>(type: "varchar(100)", nullable: true),
                    HipotensaoArterial = table.Column<string>(type: "varchar(100)", nullable: true),
                    Arritmia = table.Column<string>(type: "varchar(100)", nullable: true),
                    AlteracaoSNervoso = table.Column<string>(type: "varchar(100)", nullable: true),
                    DorCabeca = table.Column<string>(type: "varchar(100)", nullable: true),
                    FraquezaMuscular = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tremedeira = table.Column<string>(type: "varchar(100)", nullable: true),
                    TremorMuscular = table.Column<string>(type: "varchar(100)", nullable: true),
                    VisãoTurvaEmbacada = table.Column<string>(type: "varchar(100)", nullable: true),
                    AgitacaoIrritabilidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    VertigensTonturas = table.Column<string>(type: "varchar(100)", nullable: true),
                    Formigamento = table.Column<string>(type: "varchar(100)", nullable: true),
                    IncoordenacaoMotora = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoDigestorio = table.Column<string>(type: "varchar(100)", nullable: true),
                    ColicasDorBarriga = table.Column<string>(type: "varchar(100)", nullable: true),
                    DorEstomago = table.Column<string>(type: "varchar(100)", nullable: true),
                    AziaQueimacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    NauseasEnjoo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Vomito = table.Column<string>(type: "varchar(100)", nullable: true),
                    Diarreia = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoRespiratorio = table.Column<string>(type: "varchar(100)", nullable: true),
                    FaltaDeAr = table.Column<string>(type: "varchar(100)", nullable: true),
                    IrritaçaoNasal = table.Column<string>(type: "varchar(100)", nullable: true),
                    CatarroEscarro = table.Column<string>(type: "varchar(100)", nullable: true),
                    Tosse = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoAuditivo = table.Column<string>(type: "varchar(100)", nullable: true),
                    DiminuicaoAudicao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Zumbido = table.Column<string>(type: "varchar(100)", nullable: true),
                    PeleMucosa = table.Column<string>(type: "varchar(100)", nullable: true),
                    DcSensibilizante = table.Column<string>(type: "varchar(100)", nullable: true),
                    DcIrritativa = table.Column<string>(type: "varchar(100)", nullable: true),
                    IrritacaoOcular = table.Column<string>(type: "varchar(100)", nullable: true),
                    AparelhoUrinario = table.Column<string>(type: "varchar(100)", nullable: true),
                    DiminuicaoUrina = table.Column<string>(type: "varchar(100)", nullable: true),
                    UrinaescuraSangue = table.Column<string>(type: "varchar(100)", nullable: true),
                    Outro = table.Column<string>(type: "varchar(100)", nullable: true),
                    ExposicaoRaiox = table.Column<string>(type: "varchar(100)", nullable: true),
                    QuandodiasExposicao = table.Column<string>(type: "varchar(100)", nullable: true),
                    TeveCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    SncCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    DigestorioCcancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    RespiratorioCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    ReprodutorCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    GlandularCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    PeleOssoSangueCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    FamiliaCancer = table.Column<string>(type: "varchar(100)", nullable: true),
                    SNCCancerFamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    DigestorioCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    RespiratorioCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    ReprodutorCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    GlandularCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    PeleOssoSangueCancerfamilia = table.Column<string>(type: "varchar(100)", nullable: true),
                    EdaRegiao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ch_t = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ch_e = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ch_p = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ast = table.Column<string>(type: "varchar(100)", nullable: true),
                    Alt = table.Column<string>(type: "varchar(100)", nullable: true),
                    Y_gt = table.Column<string>(type: "varchar(100)", nullable: true),
                    Creatinina = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ambulatorio = table.Column<string>(type: "varchar(100)", nullable: true),
                    HabitoAlimentar = table.Column<string>(type: "varchar(100)", nullable: true),
                    Imc = table.Column<string>(type: "varchar(100)", nullable: true),
                    CircunferenciaAbdominal = table.Column<string>(type: "varchar(100)", nullable: true),
                    DificuldadeEngravidar = table.Column<string>(type: "varchar(100)", nullable: true),
                    AbortoEspontaneo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TemFilhos = table.Column<string>(type: "varchar(100)", nullable: true),
                    FilhoMaFormacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    MedicamentoContinuo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Medicamento = table.Column<string>(type: "varchar(100)", nullable: true),
                    RemedioMicose = table.Column<string>(type: "varchar(100)", nullable: true),
                    NomeRemedio = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fichas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Enderecos_PacienteId",
                table: "Enderecos",
                column: "PacienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enfermeiros_TipoUsuarioId",
                table: "Enfermeiros",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FichaAgro_AgrotoxicoId",
                table: "FichaAgro",
                column: "AgrotoxicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_PacienteId",
                table: "Fichas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_TipoUsuarioId",
                table: "Medicos",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TipoUsuarioId",
                table: "Pacientes",
                column: "TipoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amostras");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Enfermeiros");

            migrationBuilder.DropTable(
                name: "FichaAgro");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Agrotoxicos");

            migrationBuilder.DropTable(
                name: "Fichas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "TiposUsuario");
        }
    }
}
