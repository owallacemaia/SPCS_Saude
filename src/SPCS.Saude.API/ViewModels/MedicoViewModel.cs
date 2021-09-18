using System.ComponentModel.DataAnnotations;

namespace SPCS.Saude.API.ViewModels
{
    public class MedicoViewModel : UsuarioViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Crm { get; set; }
    }
}
