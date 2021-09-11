using NetDevPack.Domain;
using Newtonsoft.Json;
using System;

namespace SPCS.Saude.Business.Models
{
    public class Ficha : Entity, IAggregateRoot
    {

    }

    public class Diagnostico : Entity, IAggregateRoot
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }

    public class Agrotoxico : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string PrincipioAtivo { get; set; }
    }

    public class FichaAgro : Entity, IAggregateRoot
    {
        public Guid FichaId { get; set; }
        public Guid AgrotoxicoId { get; set; }

        public Ficha Ficha { get; set; }
        public Agrotoxico Agrotoxico { get; set; }
    }
}
