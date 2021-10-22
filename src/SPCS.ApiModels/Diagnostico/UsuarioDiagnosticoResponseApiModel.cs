using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.ApiModels.Diagnostico
{
    public class UsuarioDiagnosticoResponseApiModel
    {
        public string NomePaciente { get; set; }
        public string Cpf { get; set; }
        public DateTime DataFicha { get; set; }
        public Guid FichaId { get; set; }
    }
}
