using NetDevPack.Domain;
using Newtonsoft.Json;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Ficha : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; private set; }
        public string MunicipioTrabalho { get; private set; }
        public bool Gestante { get; set; }
        public bool Tabagismo { get; set; }
        public bool TabagismoAtual { get; set; }
        public bool TabagismoAnterior { get; set; }
        public bool Etilismo { get; set; }
        public bool EtilismoAtual { get; set; }
        public bool EtilismoAnterior { get; set; }
        public bool IngestaoCafe { get; set; }
        public double CafeMlDia { get; set; }
        public string RelacaoTrabalho { get; set; }
        public string FuncaoTrabalho { get; set; }
        public bool ContatoPraguicida { get; set; }
        public string TempoContatoPraguicida { get; set; }
        public string FrequenciaContatoPraguicida { get; set; }  
        public string UltimoContatoPraguicida { get; set; }
        public string FormaAplicacao { get; set; }
        public string ViaExposicao { get; set; }
        public bool Adoeceu { get; set; }
        public string QtdVezesAdoeceu { get; set; }
        public bool Internado { get; set; }
        public string QtdVezesInternado { get; set; }
        public string QuandoInterndo { get; set; }
        public string TipoContato { get; set; }
        public bool EquipamentoProtecao { get; set; }
        public bool RoupaProtecao { get; set; }
        public bool BotaProtecao { get; set; }
        public bool LuvasProtecao { get; set; }
        public bool MascaraProtecao { get; set; }
        public bool OculosProtecao { get; set; }
        public bool ProtetorAuricular { get; set; }
        public bool DoencaCardioVascular { get; set; }
        public bool HipertensaoArterial { get; set; }
        public bool HipotensaoArterial { get; set; }
        public bool Arritmia { get; set; }
        public bool AlteracaoSNervoso { get; set; }
        public bool DorCabeca { get; set; }
        public bool FraquezaMuscular { get; set; }
        public bool Tremedeira { get; set; }
        public bool TremorMuscular { get; set; }
        public bool VisãoTurvaEmbacada { get; set; }
        public bool AgitacaoIrritabilidade { get; set; }
        public bool VertigensTonturas { get; set; }
        public bool Formigamento { get; set; }
        public bool IncoordenacaoMotora { get; set; }
        public bool AparelhoDigestorio { get; set; }
        public bool ColicasDorBarriga { get; set; }
        public bool DorEstomago { get; set; }
        public bool AziaQueimacao { get; set; }
        public bool NauseasEnjoo { get; set; }
        public bool Vomito { get; set; }
        public bool Diarreia { get; set; }
        public bool AparelhoRespiratorio { get; set; }
        public bool FaltaDeAr { get; set; }
        public bool IrritaçaoNasal { get; set; }
        public bool CatarroEscarro { get; set; }
        public bool Tosse { get; set; }
        public bool AparelhoAuditivo { get; set; }
        public bool DiminuicaoAudicao { get; set; }
        public bool Zumbido { get; set; }
        public bool PeleMucosa { get; set; }
        public bool DcSensibilizante { get; set; }
        public bool DcIrritativa { get; set; }
        public bool IrritacaoOcular { get; set; }
        public bool AparelhoUrinario { get; set; }
        public bool DiminuicaoUrina { get; set; }
        public bool UrinaescuraSangue { get; set; }
        public bool Outro { get; set; }
        public string ExposicaoRaiox { get; set; }
        public int QuandodiasExposicao { get; set; }
        public bool TeveCancer { get; set; }
        public bool SncCancer { get; set; }
        public bool DigestorioCcancer { get; set; }
        public bool RespiratorioCancer { get; set; }
        public bool ReprodutorCancer { get; set; }
        public bool GlandularCancer { get; set; }
        public bool PeleOssoSangueCancer { get; set; }
        public bool FamiliaCancer { get; set; }
        public bool SNCCancerFamilia { get; set; }
        public bool DigestorioCancerfamilia { get; set; }
        public bool RespiratorioCancerfamilia { get; set; }
        public bool ReprodutorCancerfamilia { get; set; }
        public bool GlandularCancerfamilia { get; set; }
        public bool PeleOssoSangueCancerfamilia { get; set; }
        public bool EdaRegiao { get; set; }
        public double Ch_t { get; set; }
        public double Ch_e { get; set; }
        public double Ch_p { get; set; }
        public double Ast { get; set; }
        public double Alt { get; set; }
        public double Y_gt { get; set; }
        public double Creatinina { get; set; }
        public String Ambulatorio { get; set; }
        public double HabitoAlimentar { get; set; }
        public double Imc { get; set; }
        public int CircunferenciaAbdominal { get; set; }
        public bool DificuldadeEngravidar { get; set; }
        public bool AbortoEspontaneo { get; set; }
        public bool TemFilhos { get; set; }
        public bool FilhoMaFormacao { get; set; }
        public bool MedicamentoContinuo { get; set; }
        public string Medicamento { get; set; }
        public bool RemedioMicose { get; set; }

        public string NomeRemedio { get; set; }

        public Paciente Paciente { get; private set; }

        public Ficha(Guid pacienteId, string municipioTrabalho, bool gestante, bool tabagismo, bool tabagismoAtual, 
                     bool tabagismoAnterior, bool etilismo, bool etilismoAtual, bool etilismoAnterior, bool ingestaoCafe, 
                     double cafeMlDia, string relacaoTrabalho, string funcaoTrabalho, bool contatoPraguicida, string tempoContatoPraguicida, 
                     string frequenciaContatoPraguicida, string ultimoContatoPraguicida, string formaAplicacao, string viaExposicao, bool adoeceu, 
                     string qtdVezesAdoeceu, bool internado, string qtdVezesInternado, string quandoInterndo, string tipoContato,
                     bool equipamentoProtecao, bool roupaProtecao, bool botaProtecao, bool luvasProtecao, bool mascaraProtecao, bool oculosProtecao,
                     bool protetorAuricular, bool doencaCardioVascular, bool hipertensaoArterial, bool hipotensaoArterial, bool arritmia,
                     bool alteracaoSNervoso, bool dorCabeca, bool fraquezaMuscular, bool tremedeira, bool tremorMuscular, bool visãoTurvaEmbacada,
                     bool agitacaoIrritabilidade, bool vertigensTonturas, bool formigamento, bool incoordenacaoMotora, bool aparelhoDigestorio, 
                     bool colicasDorBarriga, bool dorEstomago, bool aziaQueimacao, bool nauseasEnjoo, bool vomito, bool diarreia, 
                     bool aparelhoRespiratorio, bool faltaDeAr, bool irritaçaoNasal, bool catarroEscarro, bool tosse, bool aparelhoAuditivo, 
                     bool diminuicaoAudicao, bool zumbido, bool peleMucosa, bool dcSensibilizante, bool dcIrritativa, bool irritacaoOcular,
                     bool aparelhoUrinario, bool diminuicaoUrina, bool urinaescuraSangue, bool outro, string exposicaoRaiox, int quandodiasExposicao, 
                     bool teveCancer, bool sncCancer, bool digestorioCcancer, bool respiratorioCancer, bool reprodutorCancer, bool glandularCancer, 
                     bool peleOssoSangueCancer, bool familiaCancer, bool sNCCancerFamilia, bool digestorioCancerfamilia, bool respiratorioCancerfamilia, 
                     bool reprodutorCancerfamilia, bool glandularCancerfamilia, bool peleOssoSangueCancerfamilia, bool edaRegiao, double ch_t, 
                     double ch_e, double ch_p, double ast, double alt, double y_gt, double creatinina, string ambulatorio, double habitoAlimentar,
                     double imc, int circunferenciaAbdominal, bool dificuldadeEngravidar, bool abortoEspontaneo, bool temFilhos, bool filhoMaFormacao,
                     bool medicamentoContinuo, string medicamento, bool remedioMicose, string nomeRemedio, Paciente paciente)
        {
            PacienteId = pacienteId;
            MunicipioTrabalho = municipioTrabalho;
            Gestante = gestante;
            Tabagismo = tabagismo;
            TabagismoAtual = tabagismoAtual;
            TabagismoAnterior = tabagismoAnterior;
            Etilismo = etilismo;
            EtilismoAtual = etilismoAtual;
            EtilismoAnterior = etilismoAnterior;
            IngestaoCafe = ingestaoCafe;
            CafeMlDia = cafeMlDia;
            RelacaoTrabalho = relacaoTrabalho;
            FuncaoTrabalho = funcaoTrabalho;
            ContatoPraguicida = contatoPraguicida;
            TempoContatoPraguicida = tempoContatoPraguicida;
            FrequenciaContatoPraguicida = frequenciaContatoPraguicida;
            UltimoContatoPraguicida = ultimoContatoPraguicida;
            FormaAplicacao = formaAplicacao;
            ViaExposicao = viaExposicao;
            Adoeceu = adoeceu;
            QtdVezesAdoeceu = qtdVezesAdoeceu;
            Internado = internado;
            QtdVezesInternado = qtdVezesInternado;
            QuandoInterndo = quandoInterndo;
            TipoContato = tipoContato;
            EquipamentoProtecao = equipamentoProtecao;
            RoupaProtecao = roupaProtecao;
            BotaProtecao = botaProtecao;
            LuvasProtecao = luvasProtecao;
            MascaraProtecao = mascaraProtecao;
            OculosProtecao = oculosProtecao;
            ProtetorAuricular = protetorAuricular;
            DoencaCardioVascular = doencaCardioVascular;
            HipertensaoArterial = hipertensaoArterial;
            HipotensaoArterial = hipotensaoArterial;
            Arritmia = arritmia;
            AlteracaoSNervoso = alteracaoSNervoso;
            DorCabeca = dorCabeca;
            FraquezaMuscular = fraquezaMuscular;
            Tremedeira = tremedeira;
            TremorMuscular = tremorMuscular;
            VisãoTurvaEmbacada = visãoTurvaEmbacada;
            AgitacaoIrritabilidade = agitacaoIrritabilidade;
            VertigensTonturas = vertigensTonturas;
            Formigamento = formigamento;
            IncoordenacaoMotora = incoordenacaoMotora;
            AparelhoDigestorio = aparelhoDigestorio;
            ColicasDorBarriga = colicasDorBarriga;
            DorEstomago = dorEstomago;
            AziaQueimacao = aziaQueimacao;
            NauseasEnjoo = nauseasEnjoo;
            Vomito = vomito;
            Diarreia = diarreia;
            AparelhoRespiratorio = aparelhoRespiratorio;
            FaltaDeAr = faltaDeAr;
            IrritaçaoNasal = irritaçaoNasal;
            CatarroEscarro = catarroEscarro;
            Tosse = tosse;
            AparelhoAuditivo = aparelhoAuditivo;
            DiminuicaoAudicao = diminuicaoAudicao;
            Zumbido = zumbido;
            PeleMucosa = peleMucosa;
            DcSensibilizante = dcSensibilizante;
            DcIrritativa = dcIrritativa;
            IrritacaoOcular = irritacaoOcular;
            AparelhoUrinario = aparelhoUrinario;
            DiminuicaoUrina = diminuicaoUrina;
            UrinaescuraSangue = urinaescuraSangue;
            Outro = outro;
            ExposicaoRaiox = exposicaoRaiox;
            QuandodiasExposicao = quandodiasExposicao;
            TeveCancer = teveCancer;
            SncCancer = sncCancer;
            DigestorioCcancer = digestorioCcancer;
            RespiratorioCancer = respiratorioCancer;
            ReprodutorCancer = reprodutorCancer;
            GlandularCancer = glandularCancer;
            PeleOssoSangueCancer = peleOssoSangueCancer;
            FamiliaCancer = familiaCancer;
            SNCCancerFamilia = sNCCancerFamilia;
            DigestorioCancerfamilia = digestorioCancerfamilia;
            RespiratorioCancerfamilia = respiratorioCancerfamilia;
            ReprodutorCancerfamilia = reprodutorCancerfamilia;
            GlandularCancerfamilia = glandularCancerfamilia;
            PeleOssoSangueCancerfamilia = peleOssoSangueCancerfamilia;
            EdaRegiao = edaRegiao;
            Ch_t = ch_t;
            Ch_e = ch_e;
            Ch_p = ch_p;
            Ast = ast;
            Alt = alt;
            Y_gt = y_gt;
            Creatinina = creatinina;
            Ambulatorio = ambulatorio;
            HabitoAlimentar = habitoAlimentar;
            Imc = imc;
            CircunferenciaAbdominal = circunferenciaAbdominal;
            DificuldadeEngravidar = dificuldadeEngravidar;
            AbortoEspontaneo = abortoEspontaneo;
            TemFilhos = temFilhos;
            FilhoMaFormacao = filhoMaFormacao;
            MedicamentoContinuo = medicamentoContinuo;
            Medicamento = medicamento;
            RemedioMicose = remedioMicose;
            NomeRemedio = nomeRemedio;
            Paciente = paciente;
        }
    }


}
