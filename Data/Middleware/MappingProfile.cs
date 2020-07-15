using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectWithArchitecture.Data.Dto;
using ProjectWithArchitecture.Data.Entities;

namespace ProjectWithArchitecture.Data.Middleware
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            CreateMap<Category, CategoryDto>();
        }
    }
}
