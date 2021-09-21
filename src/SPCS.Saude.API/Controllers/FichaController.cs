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
        public async Task<IEnumerable<FichaViewModel>> Listar()
        {
            var fichas = _mapper.Map<IEnumerable<FichaViewModel>>(await _fichaRepository.ListarAsync());

            return (fichas);
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult<FichaViewModel>> Cadastrar(FichaViewModel model)
        {
            if (!ModelState.IsValid)
                return CustomResponse(model);

            var ficha = _mapper.Map<Ficha>(model);

            await _fichaService.Adicionar(ficha);

            if (!OperacaoValida())
                return CustomResponse();

            return CustomResponse(model);
        }
    }
}
