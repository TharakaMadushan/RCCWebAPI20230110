using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class UpdateEmpDTO
    {
        public string EmployeeDes { get; set; }
        public bool Status { get; set; }
        public string TPNo1 { get; set; }
        public string TPNo2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string NIC { get; set; }
        public string EPFNumber { get; set; }
        public string SkillTypeCode { get; set; }
        public string DesignationCode { get; set; }
        public DateTime EnterDate { get; set; }
    }
}
