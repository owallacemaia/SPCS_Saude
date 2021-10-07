using System;
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
        public bool Gestante { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Tabagismo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool TabagismoAtual { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool TabagismoAnterior { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Etilismo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool EtilismoAtual { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool EtilismoAnterior { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool IngestaoCafe { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double CafeMlDia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RelacaoTrabalho { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string FuncaoTrabalho { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool ContatoPraguicida { get; private set; }

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
        public bool Adoeceu { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string QtdVezesAdoeceu { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Internado { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string QtdVezesInternado { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string QuandoInterndo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string TipoContato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool EquipamentoProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool RoupaProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool BotaProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool LuvasProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool MascaraProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool OculosProtecao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool ProtetorAuricular { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DoencaCardioVascular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool HipertensaoArterial { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool HipotensaoArterial { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Arritmia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AlteracaoSNervoso { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DorCabeca { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool FraquezaMuscular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Tremedeira { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool TremorMuscular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool VisãoTurvaEmbacada { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AgitacaoIrritabilidade { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool VertigensTonturas { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Formigamento { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool IncoordenacaoMotora { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AparelhoDigestorio { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool ColicasDorBarriga { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DorEstomago { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AziaQueimacao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool NauseasEnjoo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Vomito { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Diarreia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AparelhoRespiratorio { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool FaltaDeAr { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool IrritaçaoNasal { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool CatarroEscarro { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Tosse { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AparelhoAuditivo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DiminuicaoAudicao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Zumbido { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool PeleMucosa { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DcSensibilizante { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DcIrritativa { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool IrritacaoOcular { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AparelhoUrinario { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DiminuicaoUrina { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool UrinaescuraSangue { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Outro { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ExposicaoRaiox { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int QuandodiasExposicao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool TeveCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool SncCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DigestorioCcancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool RespiratorioCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool ReprodutorCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool GlandularCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool PeleOssoSangueCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool FamiliaCancer { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool SNCCancerFamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DigestorioCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool RespiratorioCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool ReprodutorCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool GlandularCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool PeleOssoSangueCancerfamilia { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool EdaRegiao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Ch_t { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Ch_e { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Ch_p { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Ast { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Alt { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Y_gt { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Creatinina { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public String Ambulatorio { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double HabitoAlimentar { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Imc { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int CircunferenciaAbdominal { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool DificuldadeEngravidar { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool AbortoEspontaneo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool TemFilhos { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool FilhoMaFormacao { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool MedicamentoContinuo { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Medicamento { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool RemedioMicose { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string NomeRemedio { get; private set; }
    }
}
