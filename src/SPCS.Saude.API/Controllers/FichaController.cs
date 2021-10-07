using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Ficha;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Route("api/ficha")]
    public class FichaController : MainController
    {
        private readonly IMapper _mapper;
        private readonly IFichaService _fichaService;
        private readonly IFichaRepository _fichaRepository;

        public FichaController(IMapper mapper, IFichaService fichaService, IFichaRepository fichaRepository)
        {
            _mapper = mapper;
            _fichaService = fichaService;
            _fichaRepository = fichaRepository;
        }

        [HttpGet("listar")]
        public async Task<IEnumerable<FichaResponseApiModel>> Listar()
        {
            return (_mapper.Map<IEnumerable<FichaResponseApiModel>>(await _fichaRepository.ListarAsync()));
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<FichaResponseApiModel>> ObterPorId(Guid id)
        {
            var ficha = await _fichaRepository.ObterPorId(id);

            if(ficha == null)
            {
                AdicionarErroProcessamento("Não foi encontrado nenhuma ficha com o ID informado!");
                CustomResponse();
            }

            return CustomResponse(_mapper.Map<FichaResponseApiModel>(ficha));
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult<FichaResponseApiModel>> Cadastrar(FichaResponseApiModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var ficha = _mapper.Map<Ficha>(model);

            await _fichaService.Adicionar(ficha);

            if (!OperacaoValida())
                return CustomResponse();

            return CustomResponse(_mapper.Map<FichaResponseApiModel>(ficha));
        }
    }
}
