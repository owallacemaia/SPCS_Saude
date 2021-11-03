using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SPCS.ApiModels.Ficha
{
    public class CadastrarFichaRequestApiModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid PacienteId { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string MunicipioTrabalho { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Gestante { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Tabagismo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TabagismoAtual { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TabagismoAnterior { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Etilismo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string EtilismoAtual { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string EtilismoAnterior { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string IngestaoCafe { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CafeMlDia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RelacaoTrabalho { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FuncaoTrabalho { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ContatoPraguicida { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TempoContatoPraguicida { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FrequenciaContatoPraguicida { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string UltimoContatoPraguicida { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FormaAplicacao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ViaExposicao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Adoeceu { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string QtdVezesAdoeceu { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string stringernado { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string QtdVezesstringernado { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Quandostringerndo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TipoContato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string EquipamentoProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RoupaProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string BotaProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string LuvasProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string MascaraProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string OculosProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ProtetorAuricular { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DoencaCardioVascular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string HipertensaoArterial { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string HipotensaoArterial { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Arritmia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AlteracaoSNervoso { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DorCabeca { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FraquezaMuscular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Tremedeira { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TremorMuscular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string VisãoTurvaEmbacada { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AgitacaoIrritabilidade { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string VertigensTonturas { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Formigamento { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string IncoordenacaoMotora { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AparelhoDigestorio { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ColicasDorBarriga { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DorEstomago { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AziaQueimacao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string NauseasEnjoo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Vomito { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Diarreia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AparelhoRespiratorio { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FaltaDeAr { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string IrritaçaoNasal { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CatarroEscarro { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Tosse { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AparelhoAuditivo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DiminuicaoAudicao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Zumbido { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string PeleMucosa { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DcSensibilizante { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DcIrritativa { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string IrritacaoOcular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AparelhoUrinario { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DiminuicaoUrina { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string UrinaescuraSangue { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Outro { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ExposicaoRaiox { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string QuandodiasExposicao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TeveCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SncCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DigestorioCcancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RespiratorioCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ReprodutorCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string GlandularCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string PeleOssoSangueCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FamiliaCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string SNCCancerFamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DigestorioCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RespiratorioCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ReprodutorCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string GlandularCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string PeleOssoSangueCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string EdaRegiao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Ch_t { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Ch_e { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Ch_p { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Ast { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Alt { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Y_gt { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Creatinina { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public String Ambulatorio { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string HabitoAlimentar { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Imc { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CircunferenciaAbdominal { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string DificuldadeEngravidar { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string AbortoEspontaneo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TemFilhos { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FilhoMaFormacao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string MedicamentoContinuo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Medicamento { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RemedioMicose { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string NomeRemedio { get; private set; }

        public IEnumerable<FichaAgroApiModel> FichaAgros { get; set; }
    }

    public class FichaAgroApiModel
    {
        public Guid Id { get; set; }
    }
}
