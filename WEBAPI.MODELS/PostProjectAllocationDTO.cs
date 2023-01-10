using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class PostProjectAllocationDTO
    {
        public string AllocRefNo { get; set; }
        public string EmployeeCode { get; set; }
        public string JobNo { get; set; }
        public DateTime AllocDate { get; set; }
        public float AllocHours { get; set; }
        public string ApprovedStatus { get; set; }
        public int EmployeeNo { get; set; }
        public string DocumentEmployeeNo { get; set; }
        public string EmployeeFullName { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public float Duration { get; set; }
        public float DurationHrs { get; set; }
    }
}
