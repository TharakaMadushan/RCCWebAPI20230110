using AutoMapper;
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
        private readonly IMapper mapper;

        public EmployeeController(IEmployeeServices _employeeServices, IMapper _mapper)
        {
            employeeServices = _employeeServices;
            mapper = _mapper;
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

        [HttpPut("{empCode}")]
        public ActionResult updateEmployee(string empCode, UpdateEmpDTO update)
        {
            var updateemp = employeeServices.GetEmployee(empCode);
            if (updateemp is null)
            {
                return NotFound();
            }

            mapper.Map(update, updateemp);
            employeeServices.updateEmployee(updateemp);

            return NoContent();
        }


        [HttpDelete("{empCode}")]
        public ActionResult deleteEmployee(string empCode)
        {
            var deleteemp = employeeServices.GetEmployee(empCode);
            if (deleteemp is null)
            {
                return NotFound();
            }

            employeeServices.deleteEmployee(deleteemp);

            return NoContent();
        }
    }
}
