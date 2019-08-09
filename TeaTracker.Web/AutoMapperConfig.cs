using AutoMapper.Configuration;
using AutoMapper.Mappers;
using TeaTracker.Core;
using TeaTracker.Core.DTOs;
using TeaTracker.Models.History;

namespace TeaTracker
{
    public static class AutoMapperConfig
    {
        public static void Register(this MapperConfigurationExpression cfg)
        {
            //cfg.AddConditionalObjectMapper().Where((s, d) => s.Namespace == "TeaTracker.Data.Entities" && s.Name == d.Name + "DTO");
            //cfg.AddConditionalObjectMapper().Where((s, d) => s.Name.EndsWith("DTO") && s.Name.Substring(0, s.Name.Length - 3) + "ViewModel" == d.Name);
            //cfg.AddConditionalObjectMapper().Where((s, d) => s.Name.EndsWith("ViewModel") && s.Name.Substring(0, s.Name.Length - 9) + "DTO" == d.Name);

            cfg.RegisterWebMappings();
            cfg.RegisterCoreMappings();
        } 

        public static void RegisterWebMappings(this MapperConfigurationExpression cfg)
        {
            cfg.CreateMap<HistoryDTO, HistoryViewModel>().ReverseMap();
            cfg.CreateMap<HistoryDTO, HistoryCreateViewModel>().ReverseMap();
        }
    }
}
