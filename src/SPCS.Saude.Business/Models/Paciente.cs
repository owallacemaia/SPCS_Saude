using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Models
{
    public class Paciente : Entity, IAggregateRoot
    {
        public Guid UsuarioId { get; private set; }

        protected Paciente() { }

        public Paciente(Guid usuarioId)
        {
            UsuarioId = usuarioId;
        }
    }
}
