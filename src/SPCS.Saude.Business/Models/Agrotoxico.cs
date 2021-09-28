using SPCS.Saude.Core.DomainObjects;

namespace SPCS.Saude.Business.Models
{
    public class Agrotoxico : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public string PrincipioAtivo { get; private set; }

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
