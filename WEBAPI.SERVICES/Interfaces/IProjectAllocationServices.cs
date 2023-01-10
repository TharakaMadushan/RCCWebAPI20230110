using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.SERVICES.Interfaces
{
    public interface  IProjectAllocationServices
    {
        public DataTable GetAllocationData(DateTime FromDate, DateTime ToDate, string EmpData);

        public int PostAllocationData(int SegmentID, int LastModifyUser, List<PostProjectAllocationDTO> projectAllocationDTOs);
    }
}
