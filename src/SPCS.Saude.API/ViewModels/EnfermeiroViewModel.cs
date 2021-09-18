using System.ComponentModel.DataAnnotations;

namespace SPCS.Saude.API.ViewModels
{
    public class EnfermeiroViewModel : UsuarioViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Coren { get; set; }
    }
}
