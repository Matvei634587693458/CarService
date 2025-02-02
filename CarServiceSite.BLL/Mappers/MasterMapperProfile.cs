using AutoMapper;
using CarServiceSite.Core.Dtos;
using CarServiceSite.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.BLL.Mappers
{
    public class MasterMapperProfile : Profile
    {
        public MasterMapperProfile() 
        {
            CreateMap<MasterDto, MasterOutputModel>();
        }
    }
}
