using SPCS.ApiModels.Usuario;
using System;

namespace SPCS.ApiModels.Amostra
{
    public class AmostraResponseApiModel : AmostraApiModel
    {
        public PacienteResponseApiModel Paciente { get; set; }
    }

    public class PacienteAmostraResponseApiModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
