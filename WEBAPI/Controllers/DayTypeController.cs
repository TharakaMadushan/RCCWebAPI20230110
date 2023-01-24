using AutoMapper;
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
        private readonly IMapper mapper;

        public DayTypeController(IDayTypeServices _dayTypeServices, IMapper _mapper)
        {
            dayTypeServices = _dayTypeServices;
            mapper = _mapper;   
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

        [HttpPut("{dayCode}")]
        public ActionResult updateDayType(string dayCode, UpdateDayTypeDTO update)
        {
            var updatedayType = dayTypeServices.GetDayType(dayCode);

            if (updatedayType is null) return NotFound();

            mapper.Map(update, updatedayType);
            dayTypeServices.updateDayType(updatedayType);

            return NoContent();
        }

        [HttpDelete("{dayCode}")]
        public ActionResult deleteDayType(string dayCode)
        {
            var deleteDayType = dayTypeServices.GetDayType(dayCode);

            if (deleteDayType is null) return NotFound();

            dayTypeServices.deleteDayType(deleteDayType);

            return NoContent();
        }
    }
}
