using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class FichaAgro : Entity, IAggregateRoot
    {
        public Guid FichaId { get; set; }
        public Guid AgrotoxicoId { get; set; }

        public Ficha Ficha { get; set; }
        public Agrotoxico Agrotoxico { get; set; }

        protected FichaAgro() { }
    }
}
