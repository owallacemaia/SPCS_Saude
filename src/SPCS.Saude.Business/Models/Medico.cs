using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Medico : Entity, IAggregateRoot
    {
        public Guid UsuarioId { get; private set; }
        public string Crm { get; private set; }

        //EF Constructor
        protected Medico() { }

        public Medico(Guid usuarioId, string crm)
        {
            UsuarioId = usuarioId;
            Crm = crm;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
