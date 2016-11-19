using AutoMapper;
using dm = MyFirstApp.API.DomainModel;
using sm = MyFirstApp.API.ServiceModel.Dtos;


namespace MyFirstAppAPI.ServiceDefinition.Mappers
{
    public class AutoMapperConfiguration
    {
        public static IMapper Configure() 
        {
            var mapperConfig = new MapperConfiguration(
                cfg => cfg.AddProfile<PersonMapper>()
            );
            return mapperConfig.CreateMapper();
        }
    }
}
