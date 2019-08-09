using AutoMapper.Configuration;
using TeaTracker.Core.DTOs;
using TeaTracker.Data.Entities;

namespace TeaTracker.Core
{
    public static class AutoMapperConfig
    {
        public static void RegisterCoreMappings(this MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<History, HistoryDTO>().ReverseMap();
        }
    }
}
