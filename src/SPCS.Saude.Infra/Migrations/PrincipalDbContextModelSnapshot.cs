﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPCS.Saude.Infra.Context;

namespace SPCS.Saude.Infra.Migrations
{
    [DbContext(typeof(PrincipalDbContext))]
    partial class PrincipalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SPCS.Saude.Business.Models.Agrotoxico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PrincipioAtivo")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Agrotoxicos");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Amostra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AbortoEspontaneo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Adoeceu")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AgitacaoIrritabilidade")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Alt_discretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AlteracaoSNervoso")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ambulatorio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AparelhoAuditivo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AparelhoDigestorio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AparelhoRespiratorio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AparelhoUrinario")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Arritmia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ast_discretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AziaQueimacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("BotaProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CafeMldiaDiscretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CatarroEscarro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ch_e_discretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ch_p_discretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ch_t_discretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CircunferenciaAbdominalDiscretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ColicasDorBarriga")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CreatininaDiscretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cultura")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DcIrritativa")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DcSensibilizante")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Diarreia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DificuldadeEngravidar")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DigestorioCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DigestorioCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DiminuicaoAudicao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DiminuicaoUrina")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DoencaCardioVascular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DorCabeca")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DorEstomago")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EdaRegiao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EquipamentoProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Etilismo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EtilismoAnterior")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EtilismoAtual")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ExposicaoRaiox")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FaltaDeAr")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FamiliaCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FilhoMaFormacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FormaAplicacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Formigamento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FraquezaMuscular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FrequenciaContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FuncaoTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gestante")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GlandularCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GlandularCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HabitoAlimentarDiscretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HipertensaoArterial")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HipotensaoArterial")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IdadeDiscretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImcDiscretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IncoordenacaoMotora")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IngestaoCafe")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Internado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IrritacaoNasal")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IrritacaoOcular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LuvasProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MascaraProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MedicamentoContinuo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NVezesAdoeceu")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NauseasEnjoo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeComercial")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeRemedio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NvezesInternado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OculosProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Outro")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PeleMucosa")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PeleOssoSangueCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PeleOssoSangueCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PrincipioAtivo1")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PrincipioAtivo2")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProtetorAuricular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QuandoInternado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QuandodiasExposicao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RelacaoTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RemedioMicose")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ReprodutorCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ReprodutorCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RespiratorioCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RespiratorioCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RoupaProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SNCCancerFamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Sexo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SiglaDiagnostico")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SncCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tabagismo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TabagismoAnterior")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TabagismoAtual")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TemFilhos")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TempoContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TeveCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TipoContato")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tosse")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tremedeira")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TremorMuscular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UltimoContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrinaescuraSangue")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("VertigensTonturas")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ViaExposicao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("VisaoTurvaEmbacada")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Vomito")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Y_gt_discretizado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Zumbido")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Amostras");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Diagnostico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("FichaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sigla")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("FichaId");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Ficha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AbortoEspontaneo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Adoeceu")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AgitacaoIrritabilidade")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Alt")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AlteracaoSNervoso")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ambulatorio")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("AmostraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AparelhoAuditivo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AparelhoDigestorio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AparelhoRespiratorio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AparelhoUrinario")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Arritmia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ast")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("AziaQueimacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("BotaProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CafeMlDia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CatarroEscarro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ch_e")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ch_p")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Ch_t")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CircunferenciaAbdominal")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ColicasDorBarriga")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Creatinina")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cultura")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("DcIrritativa")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DcSensibilizante")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Diarreia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DificuldadeEngravidar")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DigestorioCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DigestorioCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DiminuicaoAudicao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DiminuicaoUrina")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DoencaCardioVascular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DorCabeca")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DorEstomago")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EdaRegiao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EquipamentoProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Etilismo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EtilismoAnterior")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EtilismoAtual")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ExposicaoRaiox")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FaltaDeAr")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FamiliaCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FilhoMaFormacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FormaAplicacao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Formigamento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FraquezaMuscular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FrequenciaContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FuncaoTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gestante")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GlandularCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GlandularCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HabitoAlimentar")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HipertensaoArterial")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("HipotensaoArterial")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Imc")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IncoordenacaoMotora")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IngestaoCafe")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Internado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IrritacaoNasal")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IrritacaoOcular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LuvasProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MascaraProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Medicamento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MedicamentoContinuo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("MunicipioTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NauseasEnjoo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeRemedio")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("OculosProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Outro")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PeleMucosa")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PeleOssoSangueCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PeleOssoSangueCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ProdutoContatoUltimaVez")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProtetorAuricular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QtdVezesAdoeceu")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QtdVezesInternado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QuandoInterndo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QuandodiasExposicao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RelacaoTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RemedioMicose")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ReprodutorCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ReprodutorCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RespiratorioCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RespiratorioCancerfamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RoupaProtecao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SNCCancerFamilia")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("SncCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tabagismo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TabagismoAnterior")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TabagismoAtual")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TemFilhos")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TempoContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TeveCancer")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TipoContato")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tosse")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tremedeira")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TremorMuscular")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UltimoContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrinaescuraSangue")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("VertigensTonturas")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ViaExposicao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("VisaoTurvaEmbacada")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Vomito")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Y_gt")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Zumbido")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AmostraId")
                        .IsUnique();

                    b.HasIndex("PacienteId");

                    b.ToTable("Fichas");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.FichaAgro", b =>
                {
                    b.Property<Guid>("FichaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AgrotoxicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FichaId", "AgrotoxicoId");

                    b.HasIndex("AgrotoxicoId");

                    b.ToTable("FichaAgro");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Escolaridade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.RefreshTokenData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.TipoUsuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("TiposUsuario");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Sexo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("TipoUsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Diagnostico", b =>
                {
                    b.HasOne("SPCS.Saude.Business.Models.Ficha", "Ficha")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("FichaId")
                        .IsRequired();

                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Endereco", b =>
                {
                    b.HasOne("SPCS.Saude.Business.Models.Paciente", "Paciente")
                        .WithOne("Endereco")
                        .HasForeignKey("SPCS.Saude.Business.Models.Endereco", "PacienteId")
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Ficha", b =>
                {
                    b.HasOne("SPCS.Saude.Business.Models.Amostra", "Amostra")
                        .WithOne("Ficha")
                        .HasForeignKey("SPCS.Saude.Business.Models.Ficha", "AmostraId")
                        .IsRequired();

                    b.HasOne("SPCS.Saude.Business.Models.Paciente", "Paciente")
                        .WithMany("Fichas")
                        .HasForeignKey("PacienteId")
                        .IsRequired();

                    b.Navigation("Amostra");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.FichaAgro", b =>
                {
                    b.HasOne("SPCS.Saude.Business.Models.Agrotoxico", "Agrotoxico")
                        .WithMany("Fichas")
                        .HasForeignKey("AgrotoxicoId")
                        .IsRequired();

                    b.HasOne("SPCS.Saude.Business.Models.Ficha", "Ficha")
                        .WithMany("Agrotoxicos")
                        .HasForeignKey("FichaId")
                        .IsRequired();

                    b.Navigation("Agrotoxico");

                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Usuario", b =>
                {
                    b.HasOne("SPCS.Saude.Business.Models.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioId");

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Agrotoxico", b =>
                {
                    b.Navigation("Fichas");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Amostra", b =>
                {
                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Ficha", b =>
                {
                    b.Navigation("Agrotoxicos");

                    b.Navigation("Diagnosticos");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Paciente", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Fichas");
                });
#pragma warning restore 612, 618
        }
    }
}
