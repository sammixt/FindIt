using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MapperConfig
    {
        public IMapper mapper;
        public MapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LocalGovt, DTO.LocalGovt>().ReverseMap();
                cfg.CreateMap<State, DTO.State>().ReverseMap();
            });
            mapper = config.CreateMapper();
        }
    }
}
