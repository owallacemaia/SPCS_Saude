using NetDevPack.Domain;
using Newtonsoft.Json;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Ficha : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; private set; }
        public string MunicipioTrabalho { get; private set; }
        public bool Gestante { get; private set; }
        public bool Tabagismo { get; private set; }
        public bool TabagismoAtual { get; private set; }
        public bool TabagismoAnterior { get; private set; }
        public bool Etilismo { get; private set; }
        public bool EtilismoAtual { get; private set; }
        public bool EtilismoAnterior { get; private set; }
        public bool IngestaoCafe { get; private set; }
        public double CafeMlDia { get; private set; }
        public string RelacaoTrabalho { get; private set; }
        public string FuncaoTrabalho { get; private set; }
        public bool ContatoPraguicida { get; private set; }
        public string TempoContatoPraguicida { get; private set; }
        public string FrequenciaContatoPraguicida { get; private set; }  
        public string UltimoContatoPraguicida { get; private set; }
        public string FormaAplicacao { get; private set; }
        public string ViaExposicao { get; private set; }
        public bool Adoeceu { get; private set; }
        public string QtdVezesAdoeceu { get; private set; }
        public bool Internado { get; private set; }
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
        public bool DoencaCardioVascular { get; private set; }
        public bool HipertensaoArterial { get; private set; }
        public bool HipotensaoArterial { get; private set; }
        public bool Arritmia { get; private set; }
        public bool AlteracaoSNervoso { get; private set; }
        public bool DorCabeca { get; private set; }
        public bool FraquezaMuscular { get; private set; }
        public bool Tremedeira { get; private set; }
        public bool TremorMuscular { get; private set; }
        public bool VisãoTurvaEmbacada { get; private set; }
        public bool AgitacaoIrritabilidade { get; private set; }
        public bool VertigensTonturas { get; private set; }
        public bool Formigamento { get; private set; }
        public bool IncoordenacaoMotora { get; private set; }
        public bool AparelhoDigestorio { get; private set; }
        public bool ColicasDorBarriga { get; private set; }
        public bool DorEstomago { get; private set; }
        public bool AziaQueimacao { get; private set; }
        public bool NauseasEnjoo { get; private set; }
        public bool Vomito { get; private set; }
        public bool Diarreia { get; private set; }
        public bool AparelhoRespiratorio { get; private set; }
        public bool FaltaDeAr { get; private set; }
        public bool IrritaçaoNasal { get; private set; }
        public bool CatarroEscarro { get; private set; }
        public bool Tosse { get; private set; }
        public bool AparelhoAuditivo { get; private set; }
        public bool DiminuicaoAudicao { get; private set; }
        public bool Zumbido { get; private set; }
        public bool PeleMucosa { get; private set; }
        public bool DcSensibilizante { get; private set; }
        public bool DcIrritativa { get; private set; }
        public bool IrritacaoOcular { get; private set; }
        public bool AparelhoUrinario { get; private set; }
        public bool DiminuicaoUrina { get; private set; }
        public bool UrinaescuraSangue { get; private set; }
        public bool Outro { get; private set; }
        public string ExposicaoRaiox { get; private set; }
        public int QuandodiasExposicao { get; private set; }
        public bool TeveCancer { get; private set; }
        public bool SncCancer { get; private set; }
        public bool DigestorioCcancer { get; private set; }
        public bool RespiratorioCancer { get; private set; }
        public bool ReprodutorCancer { get; private set; }
        public bool GlandularCancer { get; private set; }
        public bool PeleOssoSangueCancer { get; private set; }
        public bool FamiliaCancer { get; private set; }
        public bool SNCCancerFamilia { get; private set; }
        public bool DigestorioCancerfamilia { get; private set; }
        public bool RespiratorioCancerfamilia { get; private set; }
        public bool ReprodutorCancerfamilia { get; private set; }
        public bool GlandularCancerfamilia { get; private set; }
        public bool PeleOssoSangueCancerfamilia { get; private set; }
        public bool EdaRegiao { get; private set; }
        public double Ch_t { get; private set; }
        public double Ch_e { get; private set; }
        public double Ch_p { get; private set; }
        public double Ast { get; private set; }
        public double Alt { get; private set; }
        public double Y_gt { get; private set; }
        public double Creatinina { get; private set; }
        public String Ambulatorio { get; private set; }
        public double HabitoAlimentar { get; private set; }
        public double Imc { get; private set; }
        public int CircunferenciaAbdominal { get; private set; }
        public bool DificuldadeEngravidar { get; private set; }
        public bool AbortoEspontaneo { get; private set; }
        public bool TemFilhos { get; private set; }
        public bool FilhoMaFormacao { get; private set; }
        public bool MedicamentoContinuo { get; private set; }
        public string Medicamento { get; private set; }
        public bool RemedioMicose { get; private set; }

        public string NomeRemedio { get; private set; }

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
