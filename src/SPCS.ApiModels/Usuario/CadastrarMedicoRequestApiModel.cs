using System.ComponentModel.DataAnnotations;

namespace SPCS.ApiModels.Usuario
{
    public class CadastrarMedicoRequestApiModel : CadastrarUsuarioRequestApiModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Crm { get; set; }
    }
}
