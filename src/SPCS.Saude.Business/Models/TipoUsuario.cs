using SPCS.Saude.Core.DomainObjects;
using System;

namespace SPCS.Saude.Business.Models
{
    public class TipoUsuario : Tipo<Guid>
    {
        public static readonly TipoUsuario Administrador = new TipoUsuario { Id = Guid.Parse("d44b63a1-80d9-41e1-994a-d9c1c4d308e7"), Descricao = "Administrador" };
        public static readonly TipoUsuario Medico = new TipoUsuario { Id = Guid.Parse("7DBE420C-2297-411C-B9FA-AA97D49E2A53"), Descricao = "Medico" };
        public static readonly TipoUsuario Enfermeiro = new TipoUsuario { Id = Guid.Parse("7D277147-A892-4312-A845-B5CA5A27BED6"), Descricao = "Enfermeiro" };
        public static readonly TipoUsuario Paciente = new TipoUsuario { Id = Guid.Parse("ff35ba72-38ac-4343-88f4-9bbda552bf59"), Descricao = "Paciente" };

        public static implicit operator TipoUsuario(Guid id)
        {
            if (id == Medico.Id)
                return Medico;
            else if (id == Enfermeiro.Id)
                return Enfermeiro;
            else if (id == Paciente.Id)
                return Paciente;
            else
                throw new Exception($"Não foi encontrado o tipo de usuário com o id {id}");
        }
    }
}
