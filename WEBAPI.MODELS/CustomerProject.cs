using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class CustomerProject
    {
        [Required]
        public int ProjectLink { get; set; }

        [Required]
        [MaxLength(210)]
        public string ProjectCode { get; set; }

        [Required]
        [MaxLength(500)]
        public string ProjectName { get; set; }

        [Required]
        public bool ActiveProject { get; set; }

         
    }
}
