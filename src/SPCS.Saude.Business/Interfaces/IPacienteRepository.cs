using eShop.Core.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        void Adicionar(Paciente paciente);
        void Atualizar(Paciente paciente);
        Task<IEnumerable<Paciente>> ListarAsync();
        Task<Paciente> ObterPorId(Guid id);
        Task<Paciente> ObterPorCpf(string cpf);
        Task<IEnumerable<Paciente>> ObterPacientesFichas();
    }
}
