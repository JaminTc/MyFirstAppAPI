using AutoMapper;
using dm = MyFirstApp.API.DomainModel;
using sm = MyFirstApp.API.ServiceModel.Dtos;

namespace MyFirstAppAPI.ServiceDefinition.Mappers
{
    internal class PersonMapper : Profile
    {
        public PersonMapper()
        {
            CreateMap<dm.Person, sm.Person>();
            CreateMap<sm.Person, dm.Person>();
        }
    }
}
