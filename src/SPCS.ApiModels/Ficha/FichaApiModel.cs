using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.ApiModels.Ficha
{
    public class FichaApiModel
    { 
        public Guid PacienteId { get; private set; }
        public DateTime DataCadastro { get; set; }
        public string MunicipioTrabalho { get; private set; }
        public string Gestante { get; private set; }
        public string Tabagismo { get; private set; }
        public string TabagismoAtual { get; private set; }
        public string TabagismoAnterior { get; private set; }
        public string Etilismo { get; private set; }
        public string EtilismoAtual { get; private set; }
        public string EtilismoAnterior { get; private set; }
        public string IngestaoCafe { get; private set; }
        public string CafeMlDia { get; private set; }
        public string RelacaoTrabalho { get; private set; }
        public string FuncaoTrabalho { get; private set; }
        public string ContatoPraguicida { get; private set; }
        public string TempoContatoPraguicida { get; private set; }
        public string FrequenciaContatoPraguicida { get; private set; }
        public string UltimoContatoPraguicida { get; private set; }
        public string FormaAplicacao { get; private set; }
        public string ViaExposicao { get; private set; }
        public string Adoeceu { get; private set; }
        public string QtdVezesAdoeceu { get; private set; }
        public string stringernado { get; private set; }
        public string QtdVezesstringernado { get; set; }
        public string Quandostringerndo { get; set; }
        public string TipoContato { get; set; }
        public string EquipamentoProtecao { get; set; }
        public string RoupaProtecao { get; set; }
        public string BotaProtecao { get; set; }
        public string LuvasProtecao { get; set; }
        public string MascaraProtecao { get; set; }
        public string OculosProtecao { get; set; }
        public string ProtetorAuricular { get; set; }
        public string DoencaCardioVascular { get; private set; }
        public string HipertensaoArterial { get; private set; }
        public string HipotensaoArterial { get; private set; }
        public string Arritmia { get; private set; }
        public string AlteracaoSNervoso { get; private set; }
        public string DorCabeca { get; private set; }
        public string FraquezaMuscular { get; private set; }
        public string Tremedeira { get; private set; }
        public string TremorMuscular { get; private set; }
        public string VisãoTurvaEmbacada { get; private set; }
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
        public string DigestorioCcancer { get; private set; }
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
        public string Ch_t { get; private set; }
        public string Ch_e { get; private set; }
        public string Ch_p { get; private set; }
        public string Ast { get; private set; }
        public string Alt { get; private set; }
        public string Y_gt { get; private set; }
        public string Creatinina { get; private set; }
        public String Ambulatorio { get; private set; }
        public string HabitoAlimentar { get; private set; }
        public string Imc { get; private set; }
        public string CircunferenciaAbdominal { get; private set; }
        public string DificuldadeEngravidar { get; private set; }
        public string AbortoEspontaneo { get; private set; }
        public string TemFilhos { get; private set; }
        public string FilhoMaFormacao { get; private set; }
        public string MedicamentoContinuo { get; private set; }
        public string Medicamento { get; private set; }
        public string RemedioMicose { get; private set; }
        public string NomeRemedio { get; private set; }
    }
}
