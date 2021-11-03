using System;
using System.ComponentModel.DataAnnotations;

namespace SPCS.ApiModels.Usuario
{

    public class CadastrarPacienteRequestApiModel 
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Escolaridade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid TipoUsuarioId { get; set; }

        public string Imagem { get; set; }

        public CadastrarEnderecoRequestApiModel Endereco { get; set; }
    }
}
