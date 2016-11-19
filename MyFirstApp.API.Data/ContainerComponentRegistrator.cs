using Funq;
using MyFirstApp.API.Data.Factories;
using MyFirstApp.API.Data.Interfaces;
using MyFirstApp.API.Data.Repositories;
using ServiceStack.Configuration;

namespace MyFirstApp.API.Data
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            var settings = new AppSettings();
            container.Register<IUnitOfWorkFactory>(c => new UnitOfWorkFactory(settings.GetString("ConnStringDb1"), true));
            container.RegisterAutoWiredAs<PersonRepository, IPersonRepository>();

        }
    }
}
