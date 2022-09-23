using AutoMapper;

namespace Banda.DI.AutoMapper;

public class AutoMapperConfig
{
    public static IMapper Configure()
    {
        var ConfigMap = new MapperConfiguration( config => {
         config.AddProfile(new TocarAutoMapper());
        });

        return ConfigMap.CreateMapper();
        
    }
}
