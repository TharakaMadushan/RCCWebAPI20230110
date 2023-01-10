using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.MODELS;
using WEBAPI.SERVICES;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices employeeServices;

        public EmployeeController(IEmployeeServices _employeeServices)
        {
            employeeServices = _employeeServices;
        }

        [HttpGet("{code}")]
        public ActionResult<Employee> getEmployee(string code)
        {
            var employee = employeeServices.GetEmployee(code);
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult createEmployee(Employee emp)
        {
            employeeServices.createEmployee(emp);
            return Ok();
        }

        [HttpPut]
        public ActionResult updateEmployee(Employee emp)
        {
            var em = employeeServices.GetEmployee(emp.EmployeeCode);

            if (em == null) return NotFound();

            employeeServices.updateEmployee(emp);

            return NoContent();
        }
    }
}
