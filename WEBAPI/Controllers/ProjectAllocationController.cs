using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.SERVICES.Interfaces;
using WEBAPI.SERVICES;
using WEBAPI.MODELS;
using System.Data;
using Newtonsoft.Json;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAllocationController : ControllerBase
    {
        private readonly IProjectAllocationServices projAallocations;
        public ProjectAllocationController(IProjectAllocationServices projAallocation)
        {
            projAallocations = projAallocation;
        }

        [HttpGet("{FromDate}/{ToDate}/{EmpData}")]
        public ActionResult<List<ProjectAllocationDTO>> GetAllocationData(DateTime FromDate,DateTime ToDate,string EmpData)
        {
            DataTable dt = projAallocations.GetAllocationData(FromDate, ToDate, EmpData);
            //string result = JsonConvert.SerializeObject(dt);
            List<ProjectAllocationDTO> result = new List<ProjectAllocationDTO>();
            result = (from DataRow dr in dt.Rows
                      select new ProjectAllocationDTO()
                      {
                          AllocHours = float.Parse(dr["AllocHours"].ToString()),
                          AllocRefNo = dr["AllocRefNo"].ToString(),
                          EmployeeCode = dr["EmployeeCode"].ToString(),
                          JobNo = dr["JobNo"].ToString(),
                          AllocDate = Convert.ToDateTime(dr["AllocDate"].ToString()),
                          ApprovedStatus = dr["AllocDate"].ToString()
                      }).ToList();
            return result;
        }

        [HttpPost("{SegmentID}/{LastModifUser}")]
        public ActionResult PostAllocationData(int SegmentID, int LastModifUser,  [FromBody] List<PostProjectAllocationDTO> projectAllocationDTOs)
        {
           int Post= projAallocations.PostAllocationData(SegmentID, LastModifUser, projectAllocationDTOs);
            if (Post!=-1)
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
