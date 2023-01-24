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
    public class DayTypeServices:IDayTypeServices
    {
        private readonly DataAccess dataAccess;

        public DayTypeServices (DataAccess _dataAccess)
        {
            dataAccess = _dataAccess;
        }

        public DayType GetDayType(string _DayTypeCode)
        {
            return dataAccess.tblRefDayType.AsNoTracking().FirstOrDefault(t => t.DayTypeCode == _DayTypeCode);
        }

        public void createDayType(DayType dayType)
        {
            dataAccess.tblRefDayType.Add(dayType);
            dataAccess.SaveChanges();
        }

        public void updateDayType(DayType dayType)
        {
            dataAccess.Update(dayType);
            dataAccess.SaveChanges();
        }

        public void deleteDayType(DayType dayType)
        {
            dataAccess.Remove(dayType);
            dataAccess.SaveChanges();
        }
    }
}
