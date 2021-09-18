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
        public string MunicipioResidencia { get; private set; }
        public string MunicipioTrabalho { get; private set; }
        public string Estado { get; private set; }
        public Paciente Paciente { get; private set; }

        protected Endereco() { }

        public Endereco(Guid pacienteId, string logradouro, string numero, string complemento, string bairro, string cep, 
                        string municipioResidencia, string municipioTrabalho, string estado)
        {
            PacienteId = pacienteId;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            MunicipioResidencia = municipioResidencia;
            MunicipioTrabalho = municipioTrabalho;
            Estado = estado;
        }
    }
}
