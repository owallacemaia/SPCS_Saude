using SPCS.Saude.Business.Models;
using System;

namespace SPCS.ApiModels.Usuario
{
    public class PacienteResponseApiModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Imagem { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Escolaridade { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public EnderecoResponseApiModel Endereco { get; set; }
    }
}
