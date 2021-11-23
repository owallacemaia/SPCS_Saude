using SPCS.Saude.Core.DomainObjects;
using System.Collections.Generic;

namespace SPCS.Saude.Business.Models
{
    public class Agrotoxico : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string PrincipioAtivo { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<FichaAgro> Fichas { get; set; }

        protected Agrotoxico() { }

        public Agrotoxico(string nome, string tipo, string principioAtivo)
        {
            Nome = nome;
            Tipo = tipo;
            PrincipioAtivo = principioAtivo;
            Ativo = true;
        }

        internal bool IsValid()
        {
            return true;
        }
    }
}
