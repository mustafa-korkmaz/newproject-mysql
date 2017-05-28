using AutoMapper;

namespace Business.WebApi
{
    public static class MappingConfigurator
    {
        public static MapperConfiguration Config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<DAL.Models.ApplicationUser, DTO.ApplicationUser>();
            cfg.CreateMap<DTO.ApplicationUser, DAL.Models.ApplicationUser>();

            cfg.CreateMap<DAL.Models.RequestLog, DTO.RequestLog>();
            cfg.CreateMap<DTO.RequestLog, DAL.Models.RequestLog>();
        });

        public static IMapper Mapper = Config.CreateMapper();
    }
}
