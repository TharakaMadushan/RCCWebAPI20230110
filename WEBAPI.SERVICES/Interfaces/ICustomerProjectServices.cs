using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.SERVICES.Interfaces
{
    public interface ICustomerProjectServices
    {
        public CustomerProject GetCustomerProject(string Code);

        public void createCustomerProject(CustomerProject _cp);

        public void updateCustomerProject(CustomerProject cp);

        public List<CustomerProject> GetCustomerProjectAll();


    }
}
