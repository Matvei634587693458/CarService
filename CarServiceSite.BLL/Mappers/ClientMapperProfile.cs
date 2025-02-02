using AutoMapper;
using CarServiceSite.Core.Dtos;
using CarServiceSite.Core.OutputModels;
using CarServiceSite.Core.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.BLL.Mappers
{
    public class ClientMapperProfile : Profile
    {
        public ClientMapperProfile() 
        {
            CreateMap<ClientDto, ClientOutputModel>();
            CreateMap<ClientInputModel, ClientDto>();
        }
    }
}
