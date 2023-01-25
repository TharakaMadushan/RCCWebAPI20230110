using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.SERVICES.Interfaces
{
    public interface IDesignationServices
    {
        public Designation GetDesignation(string DesigCode);
        public void CreateDesignation(Designation designation);
        public void UpdateDesignation(Designation designation);
        public void DeleteDesignation(Designation designation);
    }
}
