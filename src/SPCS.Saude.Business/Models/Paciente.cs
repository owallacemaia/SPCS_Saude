using SPCS.Saude.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace SPCS.Saude.Business.Models
{
    public class Paciente : Entity, IAggregateRoot
    {
        public Guid UsuarioId { get; private set; }
        public Endereco Endereco { get; private set; }
        public IEnumerable<Ficha> Fichas { get; set; }
        protected Paciente() { }

        public Paciente(Guid usuarioId, Endereco endereco)
        {
            UsuarioId = usuarioId;
            Endereco = endereco;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
