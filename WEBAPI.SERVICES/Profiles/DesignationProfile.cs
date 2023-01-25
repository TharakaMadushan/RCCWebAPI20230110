using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEBAPI.MODELS;

namespace WEBAPI.SERVICES.Profiles
{
    public class DesignationProfile : Profile
    {
        public DesignationProfile()
        {
            CreateMap<UpdateDesignationsDTO, Designation>();
        }
    }
}
