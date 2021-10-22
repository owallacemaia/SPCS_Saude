using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SPCS.ApiModels.Amostra;
using SPCS.ApiModels.Ficha;
using System.Threading.Tasks;

namespace SPCS.Saude.API.Controllers
{
    [Authorize]
    [Route("api/amostras")]
    public class AmostraController : MainController
    {

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(FichaResponseApiModel model)
        {
            var response = new AmostraApiModel
            {
                
            };
            
            return Ok();
        }
    }
}
