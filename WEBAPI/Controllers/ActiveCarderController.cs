using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using WEBAPI.MODELS;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActiveCarderController : ControllerBase
    {
        private readonly IActiveCarderService _activeCarderService;


        public ActiveCarderController(IActiveCarderService activeCarderService)
        {
            _activeCarderService = activeCarderService;
        }

        [HttpPost]       
        public ActionResult PostActiveCarder([FromBody]List<ActiveCarderDTO> activecarder)
        {
            int post = _activeCarderService.AddEmployeeCarder(activecarder);
            if (post != -1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
