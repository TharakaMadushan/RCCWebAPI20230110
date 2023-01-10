using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.MODELS;
using WEBAPI.SERVICES;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerProjectController : ControllerBase
    {
        private readonly ICustomerProjectServices customerProjectServices;

        public CustomerProjectController(ICustomerProjectServices _customerProjectServices)
        {
            customerProjectServices = _customerProjectServices;
        }

        [HttpGet("{code}")]
        public ActionResult<CustomerProject> getCustomerProjects(string code)
        {
            var cp = customerProjectServices.GetCustomerProject(code);
            return Ok(cp);
        }

        [HttpGet]
       public ActionResult<CustomerProject> getCustomerProjectAll()
        {
            var cp = customerProjectServices.GetCustomerProjectAll();
            return Ok(cp);
        }

    }
}
