﻿using SPCS.Saude.Core.DomainObjects;

namespace SPCS.Saude.Business.Models
{
    public class Diagnostico : Entity, IAggregateRoot
    {
        public string Sigla { get; private set; }
        public string Descricao { get; private set; }

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
