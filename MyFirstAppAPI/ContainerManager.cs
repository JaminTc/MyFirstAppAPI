using Funq;
using ServiceStack.Validation;

namespace MyFirstAppAPI
{
    public static class ContainerManager
    {
        public static void Register(Container container)
        {
            //container.RegisterValidators(ReuseScope.Container, typeof(APIValidat))
            MyFirstApp.API.Buisness.ContainerComponentRegistrator.RegisterComponents(container);
        }
    }
}