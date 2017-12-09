using AutoMapper;
using Lab.WebApi.Mappings;

namespace Lab.WebApi
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize
            (
                cfg =>
                {
                    cfg.AddProfile<MappingProfile>();
                }
            );
        }
    }
}