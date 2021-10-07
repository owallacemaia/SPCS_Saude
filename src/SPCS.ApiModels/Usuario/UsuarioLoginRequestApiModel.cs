using System.ComponentModel.DataAnnotations;

namespace SPCS.ApiModels.Usuario
{
    public class UsuarioLoginRequestApiModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Senha { get; set; }
        public string RefreshToken { get; set; }
        public string GrantType { get; set; }
    }
}
