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

            modelBuilder.Entity("SPCS.Saude.Business.Models.Enfermeiro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Coren")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Enfermeiros");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Ficha", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AbortoEspontaneo")
                        .HasColumnType("bit");

                    b.Property<bool>("Adoeceu")
                        .HasColumnType("bit");

                    b.Property<bool>("AgitacaoIrritabilidade")
                        .HasColumnType("bit");

                    b.Property<double>("Alt")
                        .HasColumnType("float");

                    b.Property<bool>("AlteracaoSNervoso")
                        .HasColumnType("bit");

                    b.Property<string>("Ambulatorio")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("AparelhoAuditivo")
                        .HasColumnType("bit");

                    b.Property<bool>("AparelhoDigestorio")
                        .HasColumnType("bit");

                    b.Property<bool>("AparelhoRespiratorio")
                        .HasColumnType("bit");

                    b.Property<bool>("AparelhoUrinario")
                        .HasColumnType("bit");

                    b.Property<bool>("Arritmia")
                        .HasColumnType("bit");

                    b.Property<double>("Ast")
                        .HasColumnType("float");

                    b.Property<bool>("AziaQueimacao")
                        .HasColumnType("bit");

                    b.Property<bool>("BotaProtecao")
                        .HasColumnType("bit");

                    b.Property<double>("CafeMlDia")
                        .HasColumnType("float");

                    b.Property<bool>("CatarroEscarro")
                        .HasColumnType("bit");

                    b.Property<double>("Ch_e")
                        .HasColumnType("float");

                    b.Property<double>("Ch_p")
                        .HasColumnType("float");

                    b.Property<double>("Ch_t")
                        .HasColumnType("float");

                    b.Property<int>("CircunferenciaAbdominal")
                        .HasColumnType("int");

                    b.Property<bool>("ColicasDorBarriga")
                        .HasColumnType("bit");

                    b.Property<bool>("ContatoPraguicida")
                        .HasColumnType("bit");

                    b.Property<double>("Creatinina")
                        .HasColumnType("float");

                    b.Property<bool>("DcIrritativa")
                        .HasColumnType("bit");

                    b.Property<bool>("DcSensibilizante")
                        .HasColumnType("bit");

                    b.Property<bool>("Diarreia")
                        .HasColumnType("bit");

                    b.Property<bool>("DificuldadeEngravidar")
                        .HasColumnType("bit");

                    b.Property<bool>("DigestorioCancerfamilia")
                        .HasColumnType("bit");

                    b.Property<bool>("DigestorioCcancer")
                        .HasColumnType("bit");

                    b.Property<bool>("DiminuicaoAudicao")
                        .HasColumnType("bit");

                    b.Property<bool>("DiminuicaoUrina")
                        .HasColumnType("bit");

                    b.Property<bool>("DoencaCardioVascular")
                        .HasColumnType("bit");

                    b.Property<bool>("DorCabeca")
                        .HasColumnType("bit");

                    b.Property<bool>("DorEstomago")
                        .HasColumnType("bit");

                    b.Property<bool>("EdaRegiao")
                        .HasColumnType("bit");

                    b.Property<bool>("EquipamentoProtecao")
                        .HasColumnType("bit");

                    b.Property<bool>("Etilismo")
                        .HasColumnType("bit");

                    b.Property<bool>("EtilismoAnterior")
                        .HasColumnType("bit");

                    b.Property<bool>("EtilismoAtual")
                        .HasColumnType("bit");

                    b.Property<string>("ExposicaoRaiox")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("FaltaDeAr")
                        .HasColumnType("bit");

                    b.Property<bool>("FamiliaCancer")
                        .HasColumnType("bit");

                    b.Property<bool>("FilhoMaFormacao")
                        .HasColumnType("bit");

                    b.Property<string>("FormaAplicacao")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Formigamento")
                        .HasColumnType("bit");

                    b.Property<bool>("FraquezaMuscular")
                        .HasColumnType("bit");

                    b.Property<string>("FrequenciaContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FuncaoTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Gestante")
                        .HasColumnType("bit");

                    b.Property<bool>("GlandularCancer")
                        .HasColumnType("bit");

                    b.Property<bool>("GlandularCancerfamilia")
                        .HasColumnType("bit");

                    b.Property<double>("HabitoAlimentar")
                        .HasColumnType("float");

                    b.Property<bool>("HipertensaoArterial")
                        .HasColumnType("bit");

                    b.Property<bool>("HipotensaoArterial")
                        .HasColumnType("bit");

                    b.Property<double>("Imc")
                        .HasColumnType("float");

                    b.Property<bool>("IncoordenacaoMotora")
                        .HasColumnType("bit");

                    b.Property<bool>("IngestaoCafe")
                        .HasColumnType("bit");

                    b.Property<bool>("Internado")
                        .HasColumnType("bit");

                    b.Property<bool>("IrritacaoOcular")
                        .HasColumnType("bit");

                    b.Property<bool>("IrritaçaoNasal")
                        .HasColumnType("bit");

                    b.Property<bool>("LuvasProtecao")
                        .HasColumnType("bit");

                    b.Property<bool>("MascaraProtecao")
                        .HasColumnType("bit");

                    b.Property<string>("Medicamento")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("MedicamentoContinuo")
                        .HasColumnType("bit");

                    b.Property<string>("MunicipioTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("NauseasEnjoo")
                        .HasColumnType("bit");

                    b.Property<string>("NomeRemedio")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("OculosProtecao")
                        .HasColumnType("bit");

                    b.Property<bool>("Outro")
                        .HasColumnType("bit");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("PeleMucosa")
                        .HasColumnType("bit");

                    b.Property<bool>("PeleOssoSangueCancer")
                        .HasColumnType("bit");

                    b.Property<bool>("PeleOssoSangueCancerfamilia")
                        .HasColumnType("bit");

                    b.Property<bool>("ProtetorAuricular")
                        .HasColumnType("bit");

                    b.Property<string>("QtdVezesAdoeceu")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QtdVezesInternado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("QuandoInterndo")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("QuandodiasExposicao")
                        .HasColumnType("int");

                    b.Property<string>("RelacaoTrabalho")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("RemedioMicose")
                        .HasColumnType("bit");

                    b.Property<bool>("ReprodutorCancer")
                        .HasColumnType("bit");

                    b.Property<bool>("ReprodutorCancerfamilia")
                        .HasColumnType("bit");

                    b.Property<bool>("RespiratorioCancer")
                        .HasColumnType("bit");

                    b.Property<bool>("RespiratorioCancerfamilia")
                        .HasColumnType("bit");

                    b.Property<bool>("RoupaProtecao")
                        .HasColumnType("bit");

                    b.Property<bool>("SNCCancerFamilia")
                        .HasColumnType("bit");

                    b.Property<bool>("SncCancer")
                        .HasColumnType("bit");

                    b.Property<bool>("Tabagismo")
                        .HasColumnType("bit");

                    b.Property<bool>("TabagismoAnterior")
                        .HasColumnType("bit");

                    b.Property<bool>("TabagismoAtual")
                        .HasColumnType("bit");

                    b.Property<bool>("TemFilhos")
                        .HasColumnType("bit");

                    b.Property<string>("TempoContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("TeveCancer")
                        .HasColumnType("bit");

                    b.Property<string>("TipoContato")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Tosse")
                        .HasColumnType("bit");

                    b.Property<bool>("Tremedeira")
                        .HasColumnType("bit");

                    b.Property<bool>("TremorMuscular")
                        .HasColumnType("bit");

                    b.Property<string>("UltimoContatoPraguicida")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("UrinaescuraSangue")
                        .HasColumnType("bit");

                    b.Property<bool>("VertigensTonturas")
                        .HasColumnType("bit");

                    b.Property<string>("ViaExposicao")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("VisãoTurvaEmbacada")
                        .HasColumnType("bit");

                    b.Property<bool>("Vomito")
                        .HasColumnType("bit");

                    b.Property<double>("Y_gt")
                        .HasColumnType("float");

                    b.Property<bool>("Zumbido")
                        .HasColumnType("bit");

                    b.HasKey("Id");

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

            modelBuilder.Entity("SPCS.Saude.Business.Models.Medico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("SPCS.Saude.Business.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Escolaridade")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("TipoUsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuarios");
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
                    b.HasOne("SPCS.Saude.Business.Models.Paciente", "Paciente")
                        .WithMany("Fichas")
                        .HasForeignKey("PacienteId")
                        .IsRequired();

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

            modelBuilder.Entity("SPCS.Saude.Business.Models.Ficha", b =>
                {
                    b.Navigation("Agrotoxicos");
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
