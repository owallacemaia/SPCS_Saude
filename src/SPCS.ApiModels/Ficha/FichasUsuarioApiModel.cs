﻿using System;

namespace SPCS.ApiModels.Ficha
{
    public class FichasUsuarioApiModel
    {
        public Guid Id { get; set; }
        public Guid AmostraId { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
