using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;
using WEBAPI.PERSISTANCE;
using WEBAPI.SERVICES.Interfaces;

namespace WEBAPI.SERVICES
{
    public class EmployeeServices:IEmployeeServices
    {
        private readonly DataAccess dataAccess;

        public EmployeeServices(DataAccess da)
        {
            dataAccess = da;
        }

        public Employee GetEmployee(string EmpCode)
        {
            return dataAccess.tblRefEmployee.AsNoTracking().FirstOrDefault(t => t.EmployeeCode == EmpCode);
        }

        public void createEmployee(Employee emp)
        {
            dataAccess.tblRefEmployee.Add(emp);
            dataAccess.SaveChanges();
        }

        public void  updateEmployee(Employee emp)
        {
            dataAccess.tblRefEmployee.Update(emp);
            dataAccess.SaveChanges();
        }
    }
}
