using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.SERVICES.Interfaces
{
    public interface IActiveCarderService
    {
        public int AddEmployeeCarder(List<ActiveCarderDTO> activecarder);
    }
}
