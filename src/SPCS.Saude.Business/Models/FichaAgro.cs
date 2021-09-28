using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class FichaAgro : Entity, IAggregateRoot
    {
        public Guid FichaId { get; private set; }
        public Guid AgrotoxicoId { get; private set; }

        public Ficha Ficha { get; private set; }
        public Agrotoxico Agrotoxico { get; private set; }

        protected FichaAgro() { }

        public FichaAgro(Guid fichaId, Guid agrotoxicoId, Ficha ficha, Agrotoxico agrotoxico)
        {
            FichaId = fichaId;
            AgrotoxicoId = agrotoxicoId;
            Ficha = ficha;
            Agrotoxico = agrotoxico;
        }
        internal bool IsValid()
        {
            return true;
        }
    }
}
