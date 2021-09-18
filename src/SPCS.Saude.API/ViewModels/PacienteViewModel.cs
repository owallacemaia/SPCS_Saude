using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.ViewModels
{

    public class PacienteViewModel : UsuarioViewModel
    {
        public EnderecoViewModel Endereco { get; set; }
    }
}
