using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.MODELS;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillTypeController : ControllerBase
    {
        public readonly ISkillTypeServices _ISkillTypeServices;

        public SkillTypeController(ISkillTypeServices iskillTypeServices)
        {
            _ISkillTypeServices = iskillTypeServices;
        }

        [HttpGet]
        public ActionResult<SkillType> getSkillType(string Code)
        {
            var st = _ISkillTypeServices.getSkillType(Code);

            return Ok(st);
        }

        [HttpPost]
        public ActionResult<SkillType> SaveSkillType(SkillType skillType)
        {
            var st = _ISkillTypeServices.SaveSkillType(skillType);
            return Ok(st);

        }

        [HttpPut(template :"{Code}")]
        public ActionResult UpdateSkillType(string Code, SkillType skillType)
        {
            var st = _ISkillTypeServices.getSkillType(Code);
            if (st == null) return NotFound();

            _ISkillTypeServices.UpdateSkillType(skillType);

            return NoContent();
        }
    }
}
