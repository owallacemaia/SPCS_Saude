using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        public string SenhaConfirmacao { get; set; }

        public string Imagem { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }

    public class PacienteViewModel : UsuarioViewModel
    {

    }

    public class MedicoViewModel : UsuarioViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Crm { get; set; }
    }

    public class EnfermeiroViewModel : UsuarioViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Coren { get; set; }
    }

    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Estado { get; set; }
    }
}
