using SPCS.Saude.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace SPCS.Saude.Business.Models
{
    public class Paciente : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Imagem { get; private set; }
        public string Sexo { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Escolaridade { get; private set; }
        public Endereco Endereco { get; private set; }
        public IEnumerable<Ficha> Fichas { get; set; }

        protected Paciente() { }

        public Paciente(string nome, string cpf, string imagem, string sexo, DateTime dataNascimento, string telefone, 
                        string escolaridade, Endereco endereco, Guid tipoUsuarioId)
        {
            Nome = nome;
            Cpf = cpf;
            Imagem = imagem;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Escolaridade = escolaridade;
            Endereco = endereco;
            TipoUsuario = tipoUsuarioId;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
