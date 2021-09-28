using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Amostra : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; private set; }
        public string IdadeDiscretizado { get; private set; }
        public char Sexo { get; private set; }
        public bool Gestante { get; private set; }
        public bool Tabagismo { get; private set; }
        public bool TabagismoAtual { get; private set; }
        public bool TabagismoAnterior { get; private set; }
        public bool Etilismo { get; private set; }
        public bool EtilismoAtual { get; private set; }
        public bool EtilismoAnterior { get; private set; }
        public bool IngestaoCafe { get; private set; }
        public string CafeMldiaDiscretizado { get; private set; }
        public string RelacaoTrabalho { get; private set; }
        public string FuncaoTrabalho { get; private set; }
        public bool ContatoPraguicida { get; private set; }
        public string TempoContatoPraguicida { get; private set; }
        public string FrequenciaContatoPraguicida { get; private set; }
        public string UltimoContatoPraguicida { get; private set; }
        public string ClasseProduto1 { get; private set; }
        public string ClasseProduto2 { get; private set; }
        public string ClasseProduto3 { get; private set; }
        public string FormaAplicacao { get; private set; }
        public string ViaExposicao { get; private set; }
        public string Adoeceu { get; private set; }
        public string NVezesAdoeceu { get; private set; }
        public bool Internado { get; private set; }
        public string NvezesInternado { get; private set; }
        public string QuandoInternado { get; private set; }
        public string TipoContato { get; private set; }
        public bool EquipamentoProtecao { get; private set; }
        public bool RoupaProtecao { get; private set; }
        public bool BotaProtecao { get; private set; }
        public bool LuvasProtecao { get; private set; }
        public bool MascaraProtecao { get; private set; }
        public bool OculosProtecao { get; private set; }
        public bool ProtetorAuricular { get; private set; }
        public bool DoencaCardioVascular { get; private set; }
        public bool HipertensaoArterial { get; private set; }
        public bool HipotensaoArterial { get; private set; }
        public bool Arritmia { get; private set; }
        public bool AlteracaoSNervoso { get; private set; }
        public bool DorCabeca { get; private set; }
        public bool FraquezaMuscular { get; private set; }
        public bool Tremedeira { get; private set; }
        public bool TremorMuscular { get; private set; }
        public bool VisaoTurvaEmbacada { get; private set; }
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
        public string Ch_t_discretizado { get; private set; }
        public string Ch_e_discretizado { get; private set; }
        public string Ch_p_discretizado { get; private set; }
        public string Ast_discretizado { get; private set; }
        public string Alt_discretizado { get; private set; }
        public string Y_gt_discretizado { get; private set; }
        public string CreatininaDiscretizado { get; private set; }
        public string Ambulatorio { get; private set; }
        public string HabitoAlimentarDiscretizado { get; private set; }
        public string ImcDiscretizado { get; private set; }
        public string CircunferenciaAbdominalDiscretizado { get; private set; }
        public bool DificuldadeEngravidar { get; private set; }
        public bool AbortoEspontaneo { get; private set; }
        public bool TemFilhos { get; private set; }
        public bool FilhoMaFormacao { get; private set; }
        public string MedicamentoContinuo { get; private set; }
        public string RemedioMicose { get; private set; }
        public string SiglaDiagnostico { get; private set; }

        protected Amostra() { }

        public Amostra(Guid pacienteId, string idadeDiscretizado, char sexo, bool gestante, bool tabagismo,
            bool tabagismoAtual, bool tabagismoAnterior, bool etilismo, bool etilismoAtual, bool etilismoAnterior,
            bool ingestaoCafe, string cafeMldiaDiscretizado, string relacaoTrabalho, string funcaoTrabalho,
            bool contatoPraguicida, string tempoContatoPraguicida, string frequenciaContatoPraguicida,
            string ultimoContatoPraguicida, string classeProduto1, string classeProduto2, string classeProduto3,
            string formaAplicacao, string viaExposicao, string adoeceu, string nVezesAdoeceu, bool internado,
            string nvezesInternado, string quandoInternado, string tipoContato, bool equipamentoProtecao,
            bool roupaProtecao, bool botaProtecao, bool luvasProtecao, bool mascaraProtecao, bool oculosProtecao,
            bool protetorAuricular, bool doencaCardioVascular, bool hipertensaoArterial, bool hipotensaoArterial,
            bool arritmia, bool alteracaoSNervoso, bool dorCabeca, bool fraquezaMuscular, bool tremedeira,
            bool tremorMuscular, bool visãoTurvaEmbacada, bool agitacaoIrritabilidade, bool vertigensTonturas,
            bool formigamento, bool incoordenacaoMotora, bool aparelhoDigestorio, bool colicasDorBarriga, bool dorEstomago,
            bool aziaQueimacao, bool nauseasEnjoo, bool vomito, bool diarreia, bool aparelhoRespiratorio, bool faltaDeAr,
            bool irritaçaoNasal, bool catarroEscarro, bool tosse, bool aparelhoAuditivo, bool diminuicaoAudicao, bool zumbido,
            bool peleMucosa, bool dcSensibilizante, bool dcIrritativa, bool irritacaoOcular, bool aparelhoUrinario,
            bool diminuicaoUrina, bool urinaescuraSangue, bool outro, string exposicaoRaiox, int quandodiasExposicao,
            bool teveCancer, bool sncCancer, bool digestorioCcancer, bool respiratorioCancer, bool reprodutorCancer,
            bool glandularCancer, bool peleOssoSangueCancer, bool familiaCancer, bool sNCCancerFamilia,
            bool digestorioCancerfamilia, bool respiratorioCancerfamilia, bool reprodutorCancerfamilia,
            bool glandularCancerfamilia, bool peleOssoSangueCancerfamilia, bool edaRegiao, string ch_t_discretizado,
            string ch_e_discretizado, string ch_p_discretizado, string ast_discretizado, string alt_discretizado,
            string y_gt_discretizado, string creatininaDiscretizado, string ambulatorio, string habitoAlimentarDiscretizado,
            string imcDiscretizado, string circunferenciaAbdominalDiscretizado, bool dificuldadeEngravidar,
            bool abortoEspontaneo, bool temFilhos, bool filhoMaFormacao, string medicamentoContinuo, string remedioMicose,
            string siglaDiagnostico)
        {
            PacienteId = pacienteId;
            IdadeDiscretizado = idadeDiscretizado;
            Sexo = sexo;
            Gestante = gestante;
            Tabagismo = tabagismo;
            TabagismoAtual = tabagismoAtual;
            TabagismoAnterior = tabagismoAnterior;
            Etilismo = etilismo;
            EtilismoAtual = etilismoAtual;
            EtilismoAnterior = etilismoAnterior;
            IngestaoCafe = ingestaoCafe;
            CafeMldiaDiscretizado = cafeMldiaDiscretizado;
            RelacaoTrabalho = relacaoTrabalho;
            FuncaoTrabalho = funcaoTrabalho;
            ContatoPraguicida = contatoPraguicida;
            TempoContatoPraguicida = tempoContatoPraguicida;
            FrequenciaContatoPraguicida = frequenciaContatoPraguicida;
            UltimoContatoPraguicida = ultimoContatoPraguicida;
            ClasseProduto1 = classeProduto1;
            ClasseProduto2 = classeProduto2;
            ClasseProduto3 = classeProduto3;
            FormaAplicacao = formaAplicacao;
            ViaExposicao = viaExposicao;
            Adoeceu = adoeceu;
            NVezesAdoeceu = nVezesAdoeceu;
            Internado = internado;
            NvezesInternado = nvezesInternado;
            QuandoInternado = quandoInternado;
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
            VisaoTurvaEmbacada = visãoTurvaEmbacada;
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
            Ch_t_discretizado = ch_t_discretizado;
            Ch_e_discretizado = ch_e_discretizado;
            Ch_p_discretizado = ch_p_discretizado;
            Ast_discretizado = ast_discretizado;
            Alt_discretizado = alt_discretizado;
            Y_gt_discretizado = y_gt_discretizado;
            CreatininaDiscretizado = creatininaDiscretizado;
            Ambulatorio = ambulatorio;
            HabitoAlimentarDiscretizado = habitoAlimentarDiscretizado;
            ImcDiscretizado = imcDiscretizado;
            CircunferenciaAbdominalDiscretizado = circunferenciaAbdominalDiscretizado;
            DificuldadeEngravidar = dificuldadeEngravidar;
            AbortoEspontaneo = abortoEspontaneo;
            TemFilhos = temFilhos;
            FilhoMaFormacao = filhoMaFormacao;
            MedicamentoContinuo = medicamentoContinuo;
            RemedioMicose = remedioMicose;
            SiglaDiagnostico = siglaDiagnostico;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
