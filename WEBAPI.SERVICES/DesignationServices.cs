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
    public class DesignationServices:IDesignationServices
    {
        private readonly DataAccess dataAccess;

        public DesignationServices(DataAccess _da)
        {
            dataAccess = _da;
        }
        public Designation GetDesignation(string DesigCode)
        {
            return dataAccess.tblRefDesignation.AsNoTracking().FirstOrDefault(x => x.DesigCode == DesigCode);
        }

        public void CreateDesignation(Designation designation)
        {
            dataAccess.tblRefDesignation.Add(designation);
            dataAccess.SaveChanges();
        }

        public void UpdateDesignation(Designation designation)
        {
            dataAccess.tblRefDesignation.Update(designation);
            dataAccess.SaveChanges();
        }


    }
}
