using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Amostra : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; set; }
        public string IdadeDiscretizado { get; set; }
        public string Sexo { get; set; }
        public string Gestante { get; set; }
        public string Tabagismo { get; set; }
        public string TabagismoAtual { get; set; }
        public string TabagismoAnterior { get; set; }
        public string Etilismo { get; set; }
        public string EtilismoAtual { get; set; }
        public string EtilismoAnterior { get; set; }
        public string IngestaoCafe { get; set; }
        public string CafeMldiaDiscretizado { get; set; }
        public string RelacaoTrabalho { get; set; }
        public string FuncaoTrabalho { get; set; }
        public string ContatoPraguicida { get; set; }
        public string TempoContatoPraguicida { get; set; }
        public string FrequenciaContatoPraguicida { get; set; }
        public string UltimoContatoPraguicida { get; set; }
        public string PrincipioAtivo1 { get; set; }
        public string FormaAplicacao { get; set; }
        public string NomeComercial { get; set; }
        public string PrincipioAtivo2 { get; set; }
        public string Cultura { get; set; }
        public string ViaExposicao { get; set; }
        public string Adoeceu { get; set; }
        public string NVezesAdoeceu { get; set; }
        public string Internado { get; set; }
        public string NvezesInternado { get; set; }
        public string QuandoInternado { get; set; }
        public string TipoContato { get; set; }
        public string EquipamentoProtecao { get; set; }
        public string RoupaProtecao { get; set; }
        public string BotaProtecao { get; set; }
        public string LuvasProtecao { get; set; }
        public string MascaraProtecao { get; set; }
        public string OculosProtecao { get; set; }
        public string ProtetorAuricular { get; set; }
        public string DoencaCardioVascular { get; set; }
        public string HipertensaoArterial { get; set; }
        public string HipotensaoArterial { get; set; }
        public string Arritmia { get; set; }
        public string AlteracaoSNervoso { get; set; }
        public string DorCabeca { get; set; }
        public string FraquezaMuscular { get; set; }
        public string Tremedeira { get; set; }
        public string TremorMuscular { get; set; }
        public string VisaoTurvaEmbacada { get; set; }
        public string AgitacaoIrritabilidade { get; set; }
        public string VertigensTonturas { get; set; }
        public string Formigamento { get; set; }
        public string IncoordenacaoMotora { get; set; }
        public string AparelhoDigestorio { get; set; }
        public string ColicasDorBarriga { get; set; }
        public string DorEstomago { get; set; }
        public string AziaQueimacao { get; set; }
        public string NauseasEnjoo { get; set; }
        public string Vomito { get; set; }
        public string Diarreia { get; set; }
        public string AparelhoRespiratorio { get; set; }
        public string FaltaDeAr { get; set; }
        public string IrritaçaoNasal { get; set; }
        public string CatarroEscarro { get; set; }
        public string Tosse { get; set; }
        public string AparelhoAuditivo { get; set; }
        public string DiminuicaoAudicao { get; set; }
        public string Zumbido { get; set; }
        public string PeleMucosa { get; set; }
        public string DcSensibilizante { get; set; }
        public string DcIrritativa { get; set; }
        public string IrritacaoOcular { get; set; }
        public string AparelhoUrinario { get; set; }
        public string DiminuicaoUrina { get; set; }
        public string UrinaescuraSangue { get; set; }
        public string Outro { get; set; }
        public string ExposicaoRaiox { get; set; }
        public string QuandodiasExposicao { get; set; }
        public string TeveCancer { get; set; }
        public string SncCancer { get; set; }
        public string DigestorioCancer { get; set; }
        public string RespiratorioCancer { get; set; }
        public string ReprodutorCancer { get; set; }
        public string GlandularCancer { get; set; }
        public string PeleOssoSangueCancer { get; set; }
        public string FamiliaCancer { get; set; }
        public string SNCCancerFamilia { get; set; }
        public string DigestorioCancerfamilia { get; set; }
        public string RespiratorioCancerfamilia { get; set; }
        public string ReprodutorCancerfamilia { get; set; }
        public string GlandularCancerfamilia { get; set; }
        public string PeleOssoSangueCancerfamilia { get; set; }
        public string EdaRegiao { get; set; }
        public string Ch_t_discretizado { get; set; }
        public string Ch_e_discretizado { get; set; }
        public string Ch_p_discretizado { get; set; }
        public string Ast_discretizado { get; set; }
        public string Alt_discretizado { get; set; }
        public string Y_gt_discretizado { get; set; }
        public string CreatininaDiscretizado { get; set; }
        public string Ambulatorio { get; set; }
        public string HabitoAlimentarDiscretizado { get; set; }
        public string ImcDiscretizado { get; set; }
        public string CircunferenciaAbdominalDiscretizado { get; set; }
        public string DificuldadeEngravidar { get; set; }
        public string AbortoEspontaneo { get; set; }
        public string TemFilhos { get; set; }
        public string FilhoMaFormacao { get; set; }
        public string MedicamentoContinuo { get; set; }
        public string RemedioMicose { get; set; }
        public string NomeRemedio { get; set; }
        public string SiglaDiagnostico { get; set; }

        protected Amostra() { }

        public Amostra(Guid pacienteId, string idadeDiscretizado, string sexo, string gestante, string tabagismo, string tabagismoAtual, string tabagismoAnterior, string etilismo, string etilismoAtual, string etilismoAnterior, string ingestaoCafe, string cafeMldiaDiscretizado, string relacaoTrabalho, string funcaoTrabalho, string contatoPraguicida, string tempoContatoPraguicida, string frequenciaContatoPraguicida, string ultimoContatoPraguicida, string principioAtivo1, string formaAplicacao, string nomeComercial, string principioAtivo2, string cultura, string viaExposicao, string adoeceu, string nVezesAdoeceu, string internado, string nvezesInternado, string quandoInternado, string tipoContato, string equipamentoProtecao, string roupaProtecao, string botaProtecao, string luvasProtecao, string mascaraProtecao, string oculosProtecao, string protetorAuricular, string doencaCardioVascular, string hipertensaoArterial, string hipotensaoArterial, string arritmia, string alteracaoSNervoso, string dorCabeca, string fraquezaMuscular, string tremedeira, string tremorMuscular, string visaoTurvaEmbacada, string agitacaoIrritabilidade, string vertigensTonturas, string formigamento, string incoordenacaoMotora, string aparelhoDigestorio, string colicasDorBarriga, string dorEstomago, string aziaQueimacao, string nauseasEnjoo, string vomito, string diarreia, string aparelhoRespiratorio, string faltaDeAr, string irritaçaoNasal, string catarroEscarro, string tosse, string aparelhoAuditivo, string diminuicaoAudicao, string zumbido, string peleMucosa, string dcSensibilizante, string dcIrritativa, string irritacaoOcular, string aparelhoUrinario, string diminuicaoUrina, string urinaescuraSangue, string outro, string exposicaoRaiox, string quandodiasExposicao, string teveCancer, string sncCancer, string digestorioCancer, string respiratorioCancer, string reprodutorCancer, string glandularCancer, string peleOssoSangueCancer, string familiaCancer, string sNCCancerFamilia, string digestorioCancerfamilia, string respiratorioCancerfamilia, string reprodutorCancerfamilia, string glandularCancerfamilia, string peleOssoSangueCancerfamilia, string edaRegiao, string ch_t_discretizado, string ch_e_discretizado, string ch_p_discretizado, string ast_discretizado, string alt_discretizado, string y_gt_discretizado, string creatininaDiscretizado, string ambulatorio, string habitoAlimentarDiscretizado, string imcDiscretizado, string circunferenciaAbdominalDiscretizado, string dificuldadeEngravidar, string abortoEspontaneo, string temFilhos, string filhoMaFormacao, string medicamentoContinuo, string remedioMicose, string nomeRemedio, string siglaDiagnostico)
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
            PrincipioAtivo1 = principioAtivo1;
            FormaAplicacao = formaAplicacao;
            NomeComercial = nomeComercial;
            PrincipioAtivo2 = principioAtivo2;
            Cultura = cultura;
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
            DigestorioCancer = digestorioCancer;
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
            NomeRemedio = nomeRemedio;
            SiglaDiagnostico = siglaDiagnostico;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
