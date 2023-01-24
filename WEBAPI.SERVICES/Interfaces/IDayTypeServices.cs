using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;
using WEBAPI.PERSISTANCE;

namespace WEBAPI.SERVICES.Interfaces
{
    public interface IDayTypeServices
    {
        public DayType GetDayType(string _DayTypeCode);      
        public void createDayType(DayType dayType);
        public void updateDayType(DayType dayType);
        public void deleteDayType(DayType dayType);
    }
}
