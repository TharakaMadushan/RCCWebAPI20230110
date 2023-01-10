using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class DayType
    {
        [Required]
        [MaxLength(20)]
        public string DayTypeCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string DayTypeName { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
