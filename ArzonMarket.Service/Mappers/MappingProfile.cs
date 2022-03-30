using ArzonMarket.Domain.Entities.Clients;
using ArzonMarket.Service.DTOs.ForCreationDTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClientForCreationDto, Client>();
        }
    }
}
