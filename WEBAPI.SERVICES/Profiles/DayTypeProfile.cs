using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.SERVICES.Profiles
{
    public class DayTypeProfile : Profile
    {
        public DayTypeProfile()
        {
            CreateMap<UpdateDayTypeDTO, DayType>();
        }
    }
}
