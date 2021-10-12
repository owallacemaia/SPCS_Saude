using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Enfermeiro : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Imagem { get; private set; }
        public string Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Coren { get; private set; }
        public TipoUsuario TipoUsuario { get; private set; }

        protected Enfermeiro() { }

        public Enfermeiro(Guid id, string nome, string email, string cpf, string imagem, string sexo, DateTime dataNascimento, string telefone, string coren, Guid tipoUsuarioId)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Imagem = imagem;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Coren = coren;
            TipoUsuario = tipoUsuarioId;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
