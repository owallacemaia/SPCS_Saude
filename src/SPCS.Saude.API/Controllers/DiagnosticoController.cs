using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SPCS.Saude.API.Controllers
{
    [Authorize]
    [Route("api/diagnosticos")]
    public class DiagnosticoController : MainController
    {

    }
}
