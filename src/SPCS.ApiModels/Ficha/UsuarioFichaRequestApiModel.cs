using System;
using System.Collections.Generic;

namespace SPCS.ApiModels.Ficha
{
    public class UsuarioFichaRequestApiModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<FichasUsuarioApiModel> Fichas { get; set; }
    }

    public class FichasUsuarioApiModel
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
