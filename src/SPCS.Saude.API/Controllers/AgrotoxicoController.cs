using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPCS.Saude.API.ViewModels;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Route("api/agrotoxico")]
    public class AgrotoxicoController : MainController
    {
        private readonly IAgrotoxicoService _agrotoxicoService;
        private readonly IAgrotoxicoRepository _agrotoxicoRepository;
        private readonly IMapper _mapper;

        public AgrotoxicoController(IAgrotoxicoService agrotoxicoService, IAgrotoxicoRepository agrotoxicoRepository, IMapper mapper)
        {
            _agrotoxicoService = agrotoxicoService;
            _agrotoxicoRepository = agrotoxicoRepository;
            _mapper = mapper;
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult<AgrotoxicoViewModel>> Cadastrar([FromBody]AgrotoxicoViewModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse();

            await _agrotoxicoService.Adicionar(_mapper.Map<Agrotoxico>(model));

            if (!OperacaoValida())
                return CustomResponse();

            return CustomResponse(model);
        }

        [HttpPut("atualizar")]
        public async Task<ActionResult<AgrotoxicoViewModel>> Atualizar(AgrotoxicoViewModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse();

            var agrotoxico = await _agrotoxicoRepository.ObterPorId(model.Id);

            if (agrotoxico == null)
            {
                AdicionarErroProcessamento("Não foi encontrado nenhum agrotoxico com o ID informado!");
                return CustomResponse(model);
            }
            
            await _agrotoxicoService.Atualizar(_mapper.Map<Agrotoxico>(model));

            if (!OperacaoValida())
                return CustomResponse();

            return CustomResponse(model);
        }
    }
}
