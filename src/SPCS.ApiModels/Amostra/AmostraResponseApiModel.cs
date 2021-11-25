using SPCS.ApiModels.Usuario;

namespace SPCS.ApiModels.Amostra
{
    public class AmostraResponseApiModel : AmostraApiModel
    {
        public PacienteResponseApiModel Paciente { get; set; }
    }
}
