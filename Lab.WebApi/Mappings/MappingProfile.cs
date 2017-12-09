using System;
using AutoMapper;
using Lab.WebApi.Models;
using Lab.WebApi.OutputModels;

namespace Lab.WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerOutputModel>();
        }
    }
}