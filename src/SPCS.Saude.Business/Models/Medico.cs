using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Medico : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Imagem { get; private set; }
        public string Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Crm { get; private set; }
        public TipoUsuario TipoUsuario { get; private set; }
        
        //EF Constructor
        protected Medico() { }

        public Medico(Guid id, string nome, string email, string cpf, string imagem, string sexo, DateTime dataNascimento, string telefone, string crm, TipoUsuario tipoUsuario)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Imagem = imagem;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Crm = crm;
            TipoUsuario = tipoUsuario;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
