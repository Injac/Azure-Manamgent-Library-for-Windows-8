using System.Web.Http;
using ManagmentApiMockingService.Converters;
using Owin;

namespace ManagmentApiMockingService
{
    public class Startup
    {
        //https://management.core.windows.net//{0}/{1}
        public void Configuration(IAppBuilder app)
        {
            var config = new System.Web.Http.HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional});

            config.Formatters.Insert(0, new TextMediaTypeFormatter());
            app.UseWebApi(config);
        }
    }
}