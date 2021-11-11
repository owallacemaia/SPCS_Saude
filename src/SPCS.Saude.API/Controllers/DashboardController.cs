using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Dashboard.Relatorios;
using SPCS.Saude.Business.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Route("dashboard")]
    public class DashboardController : MainController
    {
        private readonly IPacienteRepository _pacienteRepository;

        [HttpGet("obter-rel-dashboard")]
        public async Task<ActionResult<DashboardApiModel>> GerarRelatorio()
        {
            var pacientes = (await _pacienteRepository.ObterTodos()).Count();

            var response = new DashboardApiModel
            {
                QuantidadePacientes = pacientes,
            };

            return CustomResponse(response);    
        }
    }
}
