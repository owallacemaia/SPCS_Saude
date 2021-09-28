using SPCS.Saude.Core.DomainObjects;
using System.Collections.Generic;

namespace SPCS.Saude.Business.Models
{
    public class Agrotoxico : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public string PrincipioAtivo { get; private set; }
        public virtual IEnumerable<FichaAgro> Fichas { get; private set; }

        protected Agrotoxico() { }

        public Agrotoxico(string nome, string tipo, string principioAtivo)
        {
            Nome = nome;
            Tipo = tipo;
            PrincipioAtivo = principioAtivo;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
