using System;
using System.Collections.Generic;

namespace SPCS.ApiModels.Ficha
{
    public class FichaResponseApiModel
    {
        public Guid Id { get; set; }
        public Guid PacienteId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string MunicipioTrabalho { get; set; }
        public string Gestante { get; set; }
        public string Tabagismo { get; set; }
        public string TabagismoAtual { get; set; }
        public string TabagismoAnterior { get; private set; }
        public string Etilismo { get; set; }
        public string EtilismoAtual { get; set; }
        public string EtilismoAnterior { get; set; }
        public string IngestaoCafe { get; set; }
        public double CafeMlDia { get; set; }
        public string RelacaoTrabalho { get; set; }
        public string FuncaoTrabalho { get; set; }
        public string ContatoPraguicida { get; set; }
        public string TempoContatoPraguicida { get; set; }
        public string FrequenciaContatoPraguicida { get; set; }
        public string UltimoContatoPraguicida { get; set; }
        public string FormaAplicacao { get; set; }
        public string ViaExposicao { get; set; }
        public string Adoeceu { get; set; }
        public string QtdVezesAdoeceu { get; set; }
        public string Internado { get; set; }
        public string QtdVezesInternado { get; set; }
        public string QuandoInterndo { get; set; }
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
        public string VisãoTurvaEmbacada { get; set; }
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
        public double Ch_t { get; set; }
        public double Ch_e { get; set; }
        public double Ch_p { get; set; }
        public double Ast { get; set; }
        public double Alt { get; set; }
        public double Y_gt { get; set; }
        public double Creatinina { get; set; }
        public string Ambulatorio { get; set; }
        public string HabitoAlimentar { get; set; }
        public double Imc { get; set; }
        public int CircunferenciaAbdominal { get; set; }
        public string DificuldadeEngravidar { get; set; }
        public string AbortoEspontaneo { get; set; }
        public string TemFilhos { get; set; }
        public string FilhoMaFormacao { get; set; }
        public string MedicamentoContinuo { get; set; }
        public string Medicamento { get; set; }
        public string RemedioMicose { get; set; }
        public string NomeRemedio { get; set; }
        public IEnumerable<FichaAgroApiModel> FichaAgros { get; set; } //verificar
    }
}
