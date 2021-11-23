using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Endereco : Entity, IAggregateRoot
    {
        public Guid PacienteId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Paciente Paciente { get; set; }

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
        internal bool IsValid()
        {
            return true;
        }
    }
}
