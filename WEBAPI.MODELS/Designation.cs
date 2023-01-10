using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class Designation
    {
        [Required]
        [MaxLength(50)]
        public string DesigCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string DesigDes { get; set; }

        [Required]
        public bool Status { get; set; }

         
    }
}
