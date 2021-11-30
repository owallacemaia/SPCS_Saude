using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Amostra;
using SPCS.ApiModels.Usuario;
using SPCS.Saude.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Route("api/amostras")]
    public class AmostraController : MainController
    {
        private readonly IAmostraRepository _amostraRepository;
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMapper _mapper;

        public AmostraController(IAmostraRepository amostraRepository, IPacienteRepository pacienteRepository, IMapper mapper)
        {
            _amostraRepository = amostraRepository;
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }

        [HttpGet("obter-amostras")]
        public async Task<IEnumerable<AmostraResponseApiModel>> ListarAmostras()
        {
            var pacientes = (await _pacienteRepository.ObterPacientesFichas()).Where(a => a.Fichas != null);
            var amostras = await _amostraRepository.ListarAsync();

            var response = amostras.Select(amostra =>
            {
                var amostramap = _mapper.Map<AmostraResponseApiModel>(amostra);
                var paciente = _mapper.Map<PacienteResponseApiModel>(pacientes.FirstOrDefault(a => a.Id == amostra.PacienteId));
                amostramap.Paciente = paciente;
                return amostramap;
            });

            return response;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AmostraResponseApiModel>> ObterAmostra(Guid id)
        {
            var amostra = await _amostraRepository.ObterPorId(id);

            if (amostra == null)
            {
                AdicionarErroProcessamento("Não foi possível encontrar a amostra com o ID informado!");
                return CustomResponse(amostra);
            }

            return CustomResponse(_mapper.Map<AmostraResponseApiModel>(amostra));
        }

        [HttpGet("amostras-paciente")]
        public async Task<IEnumerable<PacienteAmostraResponseApiModel>> ObterAmostra()
        {
            var pacientes = (await _pacienteRepository.ObterPacientesFichas()).Where(a => a.Fichas != null);
            var amostras = await _amostraRepository.ListarAsync();

            var response = amostras.Select(amostra =>
            {
                var amostramap = _mapper.Map<PacienteAmostraResponseApiModel>(amostra);
                var paciente = pacientes?.FirstOrDefault(a => a?.Id == amostra?.PacienteId);
                amostramap.Cpf = paciente.Cpf;
                amostramap.Nome = paciente.Nome;
                return amostramap;
            });

            return response;
        }
    }
}
