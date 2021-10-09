using System.ComponentModel.DataAnnotations;

namespace SPCS.ApiModels.Usuario
{
    public class CadastrarEnfermeiroRequestApiModel : CadastrarUsuarioRequestApiModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Coren { get; set; }
    }
}
