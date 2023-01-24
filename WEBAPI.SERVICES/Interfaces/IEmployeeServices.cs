using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;
using WEBAPI.PERSISTANCE;

namespace WEBAPI.SERVICES.Interfaces
{
    public interface IEmployeeServices
    {
        public Employee GetEmployee(string EmpCode);
        public void createEmployee(Employee emp);
        public void updateEmployee(Employee emp);
        public void deleteEmployee(Employee emp);
       
    }
}
