using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Enfermeiro : Entity, IAggregateRoot
    {
        public Guid UsuarioId { get; private set; }
        public string Coren { get; private set; }

        protected Enfermeiro() { }

        public Enfermeiro(Guid usuarioId, string coren)
        {
            UsuarioId = usuarioId;
            Coren = coren;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
