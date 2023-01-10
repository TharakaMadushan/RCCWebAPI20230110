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

        public DesignationController(IDesignationServices designationServices)
        {
            _IDesignationServices = designationServices;
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

        [HttpPut]
        public ActionResult updateDesignaton(Designation designation)
        {
            var desig = _IDesignationServices.GetDesignation(designation.DesigCode);

            if (desig == null) return NotFound();

            //var oAdd = new Designation
            //{
            //    DesigCode = designation.DesigCode,
            //    DesigDes = designation.DesigDes,
            //    Status = designation.Status
            //};


            _IDesignationServices.UpdateDesignation(designation);

            return NoContent();
        }
    }
}
