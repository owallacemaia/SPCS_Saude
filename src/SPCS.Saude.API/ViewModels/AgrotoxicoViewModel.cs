using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.ViewModels
{
    public class AgrotoxicoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string PrincipioAtivo { get; set; }
    }
}
