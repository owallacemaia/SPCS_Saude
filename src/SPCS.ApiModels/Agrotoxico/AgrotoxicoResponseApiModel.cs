using System;

namespace SPCS.ApiModels.Agrotoxico
{
    public class AgrotoxicoResponseApiModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }
        public string PrincipioAtivo { get; set; }
    }
}
