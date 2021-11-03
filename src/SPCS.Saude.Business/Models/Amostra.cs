using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Amostra : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; private set; }
        public string IdadeDiscretizado { get; private set; }
        public string Sexo { get; private set; }
        public string Gestante { get; private set; }
        public string Tabagismo { get; private set; }
        public string TabagismoAtual { get; private set; }
        public string TabagismoAnterior { get; private set; }
        public string Etilismo { get; private set; }
        public string EtilismoAtual { get; private set; }
        public string EtilismoAnterior { get; private set; }
        public string IngestaoCafe { get; private set; }
        public string CafeMldiaDiscretizado { get; private set; }
        public string RelacaoTrabalho { get; private set; }
        public string FuncaoTrabalho { get; private set; }
        public string ContatoPraguicida { get; private set; }
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
        public string Internado { get; private set; }
        public string NvezesInternado { get; private set; }
        public string QuandoInternado { get; private set; }
        public string TipoContato { get; private set; }
        public string EquipamentoProtecao { get; private set; }
        public string RoupaProtecao { get; private set; }
        public string BotaProtecao { get; private set; }
        public string LuvasProtecao { get; private set; }
        public string MascaraProtecao { get; private set; }
        public string OculosProtecao { get; private set; }
        public string ProtetorAuricular { get; private set; }
        public string DoencaCardioVascular { get; private set; }
        public string HipertensaoArterial { get; private set; }
        public string HipotensaoArterial { get; private set; }
        public string Arritmia { get; private set; }
        public string AlteracaoSNervoso { get; private set; }
        public string DorCabeca { get; private set; }
        public string FraquezaMuscular { get; private set; }
        public string Tremedeira { get; private set; }
        public string TremorMuscular { get; private set; }
        public string VisaoTurvaEmbacada { get; private set; }
        public string AgitacaoIrritabilidade { get; private set; }
        public string VertigensTonturas { get; private set; }
        public string Formigamento { get; private set; }
        public string IncoordenacaoMotora { get; private set; }
        public string AparelhoDigestorio { get; private set; }
        public string ColicasDorBarriga { get; private set; }
        public string DorEstomago { get; private set; }
        public string AziaQueimacao { get; private set; }
        public string NauseasEnjoo { get; private set; }
        public string Vomito { get; private set; }
        public string Diarreia { get; private set; }
        public string AparelhoRespiratorio { get; private set; }
        public string FaltaDeAr { get; private set; }
        public string IrritaçaoNasal { get; private set; }
        public string CatarroEscarro { get; private set; }
        public string Tosse { get; private set; }
        public string AparelhoAuditivo { get; private set; }
        public string DiminuicaoAudicao { get; private set; }
        public string Zumbido { get; private set; }
        public string PeleMucosa { get; private set; }
        public string DcSensibilizante { get; private set; }
        public string DcIrritativa { get; private set; }
        public string IrritacaoOcular { get; private set; }
        public string AparelhoUrinario { get; private set; }
        public string DiminuicaoUrina { get; private set; }
        public string UrinaescuraSangue { get; private set; }
        public string Outro { get; private set; }
        public string ExposicaoRaiox { get; private set; }
        public string QuandodiasExposicao { get; private set; }
        public string TeveCancer { get; private set; }
        public string SncCancer { get; private set; }
        public string DigestorioCancer { get; private set; }
        public string RespiratorioCancer { get; private set; }
        public string ReprodutorCancer { get; private set; }
        public string GlandularCancer { get; private set; }
        public string PeleOssoSangueCancer { get; private set; }
        public string FamiliaCancer { get; private set; }
        public string SNCCancerFamilia { get; private set; }
        public string DigestorioCancerfamilia { get; private set; }
        public string RespiratorioCancerfamilia { get; private set; }
        public string ReprodutorCancerfamilia { get; private set; }
        public string GlandularCancerfamilia { get; private set; }
        public string PeleOssoSangueCancerfamilia { get; private set; }
        public string EdaRegiao { get; private set; }
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
        public string DificuldadeEngravidar { get; private set; }
        public string AbortoEspontaneo { get; private set; }
        public string TemFilhos { get; private set; }
        public string FilhoMaFormacao { get; private set; }
        public string MedicamentoContinuo { get; private set; }
        public string RemedioMicose { get; private set; }
        public string NomeRemedio { get; private set; }
        public string SiglaDiagnostico { get; private set; }

        protected Amostra() { }

        public Amostra(Guid pacienteId, string idadeDiscretizado, string sexo, string gestante, string tabagismo, string tabagismoAtual, 
                       string tabagismoAnterior, string etilismo, string etilismoAtual, string etilismoAnterior, string ingestaoCafe, 
                       string cafeMldiaDiscretizado, string relacaoTrabalho, string funcaoTrabalho, string contatoPraguicida, string tempoContatoPraguicida, 
                       string frequenciaContatoPraguicida, string ultimoContatoPraguicida, string classeProduto1, string classeProduto2, string classeProduto3, 
                       string formaAplicacao, string viaExposicao, string adoeceu, string nVezesAdoeceu, string internado, string nvezesInternado, 
                       string quandoInternado, string tipoContato, string equipamentoProtecao, string roupaProtecao, string botaProtecao, string luvasProtecao, 
                       string mascaraProtecao, string oculosProtecao, string protetorAuricular, string doencaCardioVascular, string hipertensaoArterial, string hipotensaoArterial, 
                       string arritmia, string alteracaoSNervoso, string dorCabeca, string fraquezaMuscular, string tremedeira, string tremorMuscular, string visaoTurvaEmbacada, 
                       string agitacaoIrritabilidade, string vertigensTonturas, string formigamento, string incoordenacaoMotora, string aparelhoDigestorio, string colicasDorBarriga, 
                       string dorEstomago, string aziaQueimacao, string nauseasEnjoo, string vomito, string diarreia, string aparelhoRespiratorio, string faltaDeAr, string irritaçaoNasal, 
                       string catarroEscarro, string tosse, string aparelhoAuditivo, string diminuicaoAudicao, string zumbido, string peleMucosa, string dcSensibilizante, 
                       string dcIrritativa, string irritacaoOcular, string aparelhoUrinario, string diminuicaoUrina, string urinaescuraSangue, string outro, string exposicaoRaiox, 
                       string quandodiasExposicao, string teveCancer, string sncCancer, string digestorioCcancer, string respiratorioCancer, string reprodutorCancer, 
                       string glandularCancer, string peleOssoSangueCancer, string familiaCancer, string sNCCancerFamilia, string digestorioCancerfamilia, string respiratorioCancerfamilia, 
                       string reprodutorCancerfamilia, string glandularCancerfamilia, string peleOssoSangueCancerfamilia, string edaRegiao, string ch_t_discretizado, string ch_e_discretizado,
                       string ch_p_discretizado, string ast_discretizado, string alt_discretizado, string y_gt_discretizado, string creatininaDiscretizado, string ambulatorio, 
                       string habitoAlimentarDiscretizado, string imcDiscretizado, string circunferenciaAbdominalDiscretizado, string dificuldadeEngravidar, string abortoEspontaneo, string temFilhos, string filhoMaFormacao, string medicamentoContinuo, string remedioMicose, string siglaDiagnostico)
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
            VisaoTurvaEmbacada = visaoTurvaEmbacada;
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
            DigestorioCancer = digestorioCcancer;
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
