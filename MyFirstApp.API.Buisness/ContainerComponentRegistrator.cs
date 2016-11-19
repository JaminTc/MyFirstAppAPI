using Funq;

using MyFirstApp.API.Buisness.Managers;
using MyFirstApp.API.Buisness.Interfaces;

namespace MyFirstApp.API.Buisness
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            Data.ContainerComponentRegistrator.RegisterComponents(container);
            container.RegisterAutoWiredAs<PersonManager, IPersonManager>();
        }
    }
}
