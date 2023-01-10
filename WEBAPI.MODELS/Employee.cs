using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class Employee
    {
        [Required]
        [MaxLength(20)]
        public string EmployeeCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmployeeDes { get; set; }

        [Required]
        public bool Status { get; set; }

        [MaxLength(20)]
        public string TPNo1 { get; set; }

        [MaxLength(20)]
        public string TPNo2 { get; set; }

        [MaxLength(20)]
        public string Fax { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string NIC { get; set; }
    
        [MaxLength(100)]
        public string EPFNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string SkillTypeCode { get; set; }

        [Required]
        [MaxLength(20)]
        public string DesignationCode { get; set; }

        
        public DateTime Date { get; set; }

   

    }
}
