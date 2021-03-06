using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Diagnostico : Entity, IAggregateRoot
    {
        public Guid FichaId { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public Ficha Ficha { get; set; }

        protected Diagnostico() { }

        public Diagnostico(string sigla, string descricao)
        {
            Sigla = sigla;
            Descricao = descricao;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
