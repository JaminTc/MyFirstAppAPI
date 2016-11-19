using Funq;
using MyFirstAppAPI.ServiceDefinition;
using MyFirstAppAPI.ServiceDefinition.Mappers;
using ServiceStack;

namespace MyFirstAppAPI
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base(APIInfo.Name, APIInfo.Assembly) { }

        public override void Configure(Container container)
        {
            ContainerManager.Register(container);
            SetConfig(new HostConfig { HandlerFactoryPath = "myFirstApp" });
            AutoMapperConfiguration.Configure();
        }
    }
}