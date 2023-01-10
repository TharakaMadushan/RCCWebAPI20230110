using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class ProjectAllocationDTO
    {
        public string AllocRefNo  { get; set; }
        public string EmployeeCode { get; set; }                  
        public string JobNo { get; set; }
        public DateTime AllocDate { get; set; }
        public float AllocHours { get; set; }
        public string ApprovedStatus { get; set; }   
                

    }
}
