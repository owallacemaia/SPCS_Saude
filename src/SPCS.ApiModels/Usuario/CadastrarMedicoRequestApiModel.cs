using System.ComponentModel.DataAnnotations;

namespace SPCS.ApiModels.Usuario
{
    public class CadastrarMedicoRequestApiModel : CadastrarUsuarioRequestApiModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Crm { get; set; }
    }
}
