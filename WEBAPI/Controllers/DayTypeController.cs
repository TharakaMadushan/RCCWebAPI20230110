using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.MODELS;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayTypeController : ControllerBase
    {
        private readonly IDayTypeServices dayTypeServices;

        public DayTypeController(IDayTypeServices _dayTypeServices)
        {
            dayTypeServices = _dayTypeServices;
        }

        [HttpGet("{code}")]
        public ActionResult<DayType> getDayType(string code)
        {
            var dt = dayTypeServices.GetDayType(code);
            return Ok(dt);
        }

        [HttpPost]
        public ActionResult createDayType(DayType dt)
        {
            dayTypeServices.createDayType(dt);
            return Ok();
        }

        [HttpPut]
        public ActionResult updateDayType(DayType dt)
        {
            var dayType = dayTypeServices.GetDayType(dt.DayTypeCode);

            if (dayType == null) return NotFound();

            dayTypeServices.updateDayType(dt);

            return NoContent();
        }
    }
}
