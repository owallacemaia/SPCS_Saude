using System.Collections.Generic;

namespace SPCS.ApiModels.Ficha
{
    public class UsuarioFichaRequestApiModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public IEnumerable<FichaApiModel> Fichas { get; set; }
    }
}
