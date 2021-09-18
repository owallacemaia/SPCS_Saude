using NetDevPack.Domain;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Endereco : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Paciente Paciente { get; private set; }

        protected Endereco() { }

        public Endereco(Guid pacienteId, string logradouro, string numero, string complemento, 
                    string bairro, string cep, string cidade, string estado, Paciente paciente)
        {
            PacienteId = pacienteId;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Paciente = paciente;
        }
    }
}
