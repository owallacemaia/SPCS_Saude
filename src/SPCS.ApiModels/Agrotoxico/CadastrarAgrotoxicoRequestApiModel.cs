using System.ComponentModel.DataAnnotations;

namespace SPCS.ApiModels.Agrotoxico
{
    public class CadastrarAgrotoxicoRequestApiModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string PrincipioAtivo { get; set; }
    }
}
