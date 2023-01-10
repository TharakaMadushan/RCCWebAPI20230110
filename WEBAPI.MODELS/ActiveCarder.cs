using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEBAPI.MODELS
{
    public class ActiveCarder
    {
        public string EmpCode { get; set; }
        public DateTime Date { get; set; }
        public Boolean Availability { get; set; }    

    }
}
