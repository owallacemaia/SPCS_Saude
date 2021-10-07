using System;

namespace SPCS.ApiModels.Agrotoxico
{
    public class BuscarAgrotoxicoRequestApiModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string PrincipioAtivo { get; set; }
    }
}
