using SPCS.Saude.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace SPCS.Saude.Business.Models
{
    public class Paciente : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Imagem { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Escolaridade { get; set; }
        public Endereco Endereco { get; set; }
        public IEnumerable<Ficha> Fichas { get; set; }

        protected Paciente() { }

        public Paciente(string nome, string cpf, string imagem, string sexo, DateTime dataNascimento, string telefone, 
                        string escolaridade, Endereco endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Imagem = imagem;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Escolaridade = escolaridade;
            Endereco = endereco;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
