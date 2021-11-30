using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Dashboard.Relatorios;
using SPCS.Saude.Business.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Route("api/dashboard")]
    public class DashboardController : MainController
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IFichaRepository _faichaRepository;
        private readonly IAmostraRepository _amostraRepository;

        public DashboardController(IPacienteRepository pacienteRepository, 
                                   IFichaRepository faichaRepository, 
                                   IAmostraRepository amostraRepository)
        {
            _pacienteRepository = pacienteRepository;
            _faichaRepository = faichaRepository;
            _amostraRepository = amostraRepository;
        }

        [HttpGet("relatorio-dashboard")]
        public async Task<ActionResult<DashboardApiModel>> GerarRelatorio()
        {
            var pacientes = (await _pacienteRepository.ListarAsync()).Count();
            var amostras = (await _amostraRepository.ListarAsync()).Count();
            var fichas = (await _faichaRepository.ListarAsync()).Count();

            var response = new DashboardApiModel
            {
                QuantidadePacientes = pacientes,
                QuantidadeAmostras = amostras,
                QuantidadeFichas = fichas,
                QuantidadeDiagnosticos = 0,
            };

            return CustomResponse(response);    
        }
    }
}
