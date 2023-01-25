using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.MODELS;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly IDesignationServices _IDesignationServices;
        private readonly IMapper _mapper;

        public DesignationController(IDesignationServices designationServices, IMapper mapper)
        {
            _IDesignationServices = designationServices;
            _mapper = mapper;
        }

        [HttpGet("{DesigCode}")]
        public ActionResult<Designation> GetDesignations(string DesigCode)
        {
            var desig = _IDesignationServices.GetDesignation(DesigCode);           
            return Ok(desig);
        }

        [HttpPost]
        public ActionResult createDesignation(Designation designation)
        {
            _IDesignationServices.CreateDesignation(designation);
            return Ok();
        }

        [HttpPut("{desCode}")]
        public ActionResult updateDesignaton(string desCode, UpdateDesignationsDTO update)
        {
            var desig = _IDesignationServices.GetDesignation(desCode);

            if (desig == null) return NotFound();

            _mapper.Map(update, desig);
            _IDesignationServices.UpdateDesignation(desig);

            return NoContent();
        }

        [HttpDelete("{desCode}")]
        public ActionResult deleteDesignation(string desCode)
        {
            var desig = _IDesignationServices.GetDesignation(desCode);

            if (desig is null)
            {
                return NotFound();
            }

            _IDesignationServices.DeleteDesignation(desig);
            return NoContent();
        }
    }
}
