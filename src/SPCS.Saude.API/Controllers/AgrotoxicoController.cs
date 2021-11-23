using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Agrotoxico;
using SPCS.Saude.Business.Interfaces;
using SPCS.Saude.Business.Models;
using SPCS.Saude.Core.Identidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Authorize]
    [Route("api/agrotoxico")]
    public class AgrotoxicoController : MainController
    {
        private const string Permissoes = "Criar, Visualizar, Alterar, Desativar";
        private const string TipoAuthorize = "Agrotoxicos";
        private readonly IAgrotoxicoService _agrotoxicoService;
        private readonly IAgrotoxicoRepository _agrotoxicoRepository;
        private readonly IMapper _mapper;

        public AgrotoxicoController(IAgrotoxicoService agrotoxicoService, IAgrotoxicoRepository agrotoxicoRepository, IMapper mapper)
        {
            _agrotoxicoService = agrotoxicoService;
            _agrotoxicoRepository = agrotoxicoRepository;
            _mapper = mapper;
        }

        [ClaimsAuthorize(TipoAuthorize, Permissoes)]
        [HttpGet("listar")]
        public async Task<IEnumerable<AgrotoxicoResponseApiModel>> ListarTodos()
        {
            return (_mapper.Map<IEnumerable<AgrotoxicoResponseApiModel>>(await _agrotoxicoRepository.ObterTodos()));
        }

        [ClaimsAuthorize(TipoAuthorize, Permissoes)]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AgrotoxicoResponseApiModel>> BuscarPorId(Guid id)
        {
            var agrotoxico = await _agrotoxicoRepository.ObterPorId(id);

            if (agrotoxico == null)
            {
                AdicionarErroProcessamento("Não foi encontrado o agrotoxico com o ID informado!");
                return CustomResponse();
            }

            return CustomResponse(_mapper.Map<AgrotoxicoResponseApiModel>(agrotoxico));
        }

        [ClaimsAuthorize(TipoAuthorize, Permissoes)]
        [HttpPost("cadastrar")]
        public async Task<ActionResult<AgrotoxicoResponseApiModel>> Cadastrar(CadastrarAgrotoxicoRequestApiModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse();

            var agrotoxico = _mapper.Map<Agrotoxico>(model);

            await _agrotoxicoService.Adicionar(agrotoxico);

            if (!OperacaoValida())
                return CustomResponse();

            return CustomResponse(_mapper.Map<AgrotoxicoResponseApiModel>(agrotoxico));
        }

        [ClaimsAuthorize(TipoAuthorize, Permissoes)]
        [HttpPut("atualizar")]
        public async Task<ActionResult<AgrotoxicoResponseApiModel>> Atualizar(AtualizarAgrotoxicoRequestApiModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse();

            var agrotoxico = await _agrotoxicoRepository.ObterPorId(model.Id);

            if (agrotoxico == null)
            {
                AdicionarErroProcessamento("Não foi encontrado nenhum agrotoxico com o ID informado!");
                return CustomResponse(model);
            }

            var agrotoxicomap = _mapper.Map<Agrotoxico>(model);

            await _agrotoxicoService.Atualizar(agrotoxicomap);

            if (!OperacaoValida())
                return CustomResponse();

            return CustomResponse(_mapper.Map<AgrotoxicoResponseApiModel>(agrotoxicomap));
        }

        [ClaimsAuthorize(TipoAuthorize, Permissoes)]
        [HttpPut("desativar")]
        public async Task<IActionResult> Desativar(Guid id)
        {
            var agrotoxico = await _agrotoxicoRepository.ObterPorId(id);

            if(agrotoxico == null || agrotoxico.Id != id)
            {
                AdicionarErroProcessamento("Não foi possível encontrar o agrotóxico com o ID informado.");
                return CustomResponse();
            }

            agrotoxico.Ativo = false;

            await _agrotoxicoService.Atualizar(agrotoxico);

            return CustomResponse();
        }
    }
}
