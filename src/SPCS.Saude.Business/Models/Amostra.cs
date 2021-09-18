using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Models
{
    class Amostra
    {
        public Guid AmostraId { get; set; }
        public Guid PacienteId { get; set; }
        public string IdadeDiscretizado { get; set; }
        public char Sexo { get; set; }
        public bool Gestante { get; set; }
        public bool Tabagismo { get; set; }
        public bool TabagismoAtual { get; set; }
        public bool TabagismoAnterior { get; set; }
        public bool Etilismo { get; set; }
        public bool EtilismoAtual { get; set; }
        public bool EtilismoAnterior { get; set; }
        public bool IngestaoCafe { get; set; }
        public string CafeMldiaDiscretizado { get; set; }
        public string RelacaoTrabalho { get; set; }
        public string FuncaoTrabalho { get; set; }
        public bool ContatoPraguicida { get; set; }
        public string TempoContatoPraguicida { get; set; }
        public string FrequenciaContatoPraguicida { get; set; }
        public string UltimoContatoPraguicida { get; set; }
        public string ClasseProduto1 { get; set; }
        public string ClasseProduto2 { get; set; }
        public string ClasseProduto3 { get; set; }
        public string FormaAplicacao { get; set; }
        public string ViaExposicao { get; set; }
        public string Adoeceu { get; set; }
        public string NVezesAdoeceu { get; set; }
        public bool Internado { get; set; }
        public string NvezesInternado { get; set; }
        public string QuandoInternado { get; set; }
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
        public bool DificuldadeEngravidar { get; set; }
        public bool AbortoEspontaneo { get; set; }
        public bool TemFilhos { get; set; }
        public bool FilhoMaFormacao { get; set; }
        public string MedicamentoContinuo { get; set; }
        public string RemedioMicose { get; set; }
        public string SiglaDiagnostico { get; set; }

        public Amostra(Guid amostraId, Guid pacienteId, string idadeDiscretizado, char sexo, bool gestante, bool tabagismo, bool tabagismoAtual, 
            bool tabagismoAnterior, bool etilismo, bool etilismoAtual, bool etilismoAnterior, bool ingestaoCafe, string cafeMldiaDiscretizado, 
            string relacaoTrabalho, string funcaoTrabalho, bool contatoPraguicida, string tempoContatoPraguicida, string frequenciaContatoPraguicida, 
            string ultimoContatoPraguicida, string classeProduto1, string classeProduto2, string classeProduto3, string formaAplicacao,
            string viaExposicao, string adoeceu, string nVezesAdoeceu, bool internado, string nvezesInternado, string quandoInternado, 
            string tipoContato, bool equipamentoProtecao, bool roupaProtecao, bool botaProtecao, bool luvasProtecao, bool mascaraProtecao, 
            bool oculosProtecao, bool protetorAuricular, bool doencaCardioVascular, bool hipertensaoArterial, bool hipotensaoArterial, bool arritmia, 
            bool alteracaoSNervoso, bool dorCabeca, bool fraquezaMuscular, bool tremedeira, bool tremorMuscular, bool visãoTurvaEmbacada, 
            bool agitacaoIrritabilidade, bool vertigensTonturas, bool formigamento, bool incoordenacaoMotora, bool aparelhoDigestorio, 
            bool colicasDorBarriga, bool dorEstomago, bool aziaQueimacao, bool nauseasEnjoo, bool vomito, bool diarreia, bool aparelhoRespiratorio,
            bool faltaDeAr, bool irritaçaoNasal, bool catarroEscarro, bool tosse, bool aparelhoAuditivo, bool diminuicaoAudicao, bool zumbido,
            bool peleMucosa, bool dcSensibilizante, bool dcIrritativa, bool irritacaoOcular, bool aparelhoUrinario, bool diminuicaoUrina, 
            bool urinaescuraSangue, bool outro, string exposicaoRaiox, int quandodiasExposicao, bool teveCancer, bool sncCancer, bool digestorioCcancer,
            bool respiratorioCancer, bool reprodutorCancer, bool glandularCancer, bool peleOssoSangueCancer, bool familiaCancer, bool sNCCancerFamilia,
            bool digestorioCancerfamilia, bool respiratorioCancerfamilia, bool reprodutorCancerfamilia, bool glandularCancerfamilia, 
            bool peleOssoSangueCancerfamilia, bool edaRegiao, string ch_t_discretizado, string ch_e_discretizado, string ch_p_discretizado, 
            string ast_discretizado, string alt_discretizado, string y_gt_discretizado, string creatininaDiscretizado, string ambulatorio, 
            string habitoAlimentarDiscretizado, string imcDiscretizado, string circunferenciaAbdominalDiscretizado, bool dificuldadeEngravidar, 
            bool abortoEspontaneo, bool temFilhos, bool filhoMaFormacao, string medicamentoContinuo, string remedioMicose, string siglaDiagnostico)
        {
            AmostraId = amostraId;
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
    }
}
