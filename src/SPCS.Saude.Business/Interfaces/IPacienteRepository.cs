﻿using NetDevPack.Data;
using SPCS.Saude.Business.Models;
using System;
using System.Threading.Tasks;

namespace SPCS.Saude.Business.Interfaces
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        void Adicionar(Paciente paciente);
        Task<Paciente> ObterInformacoesPorUsuarioId(Guid id);
    }
}
