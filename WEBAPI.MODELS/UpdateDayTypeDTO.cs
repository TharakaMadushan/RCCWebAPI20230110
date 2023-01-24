using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class UpdateDayTypeDTO
    {
        //public string DayTypeCode { get; set; }
        public string DayTypeName { get; set; }
        public decimal WorkingHours { get; set; } = decimal.Zero;
        public bool IsActive { get; set; }
    }
}
