namespace MyFirstAppAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           new AppHost().Init();
            //WebApiConfig.Register();
        }
    }
}