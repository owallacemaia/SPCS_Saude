using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Amostra;
using SPCS.Saude.Business.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Authorize]
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
            return (_mapper.Map<IEnumerable<AmostraResponseApiModel>>(await _amostraRepository.Amostras()));
        }
    }
}
