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
    public class CustomerProjectServices:ICustomerProjectServices
    {
        private readonly DataAccess dataAccess;

        public CustomerProjectServices(DataAccess _dataAccess)
        {
            dataAccess = _dataAccess;
        }

        public CustomerProject GetCustomerProject(string Code)
        {
            return dataAccess.tblRefProject.AsNoTracking().FirstOrDefault(t => t.ProjectCode == Code);
        }

        public List<CustomerProject> GetCustomerProjectAll()
        {
            return dataAccess.tblRefProject.ToList();
        }

        public void createCustomerProject(CustomerProject _cp)
        {
            dataAccess.tblRefProject.Add(_cp);
            dataAccess.SaveChanges();
        }

        public void updateCustomerProject(CustomerProject cp)
        {            
            dataAccess.tblRefProject.Update(cp);
            dataAccess.SaveChanges();
        }
    }
}
