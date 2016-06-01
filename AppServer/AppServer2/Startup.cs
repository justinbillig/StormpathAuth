using Microsoft.Owin;
using Owin;
using Stormpath.AspNet;
using Stormpath.Configuration.Abstractions;
using System.Web.Http;
using Microsoft.Owin.Cors;

[assembly: OwinStartup(typeof(AppServer2.Startup))]

namespace AppServer2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Need to rewrite this as a more restrictive CorsPolicy
            app.UseCors(CorsOptions.AllowAll);

            // Add Stormpath security middleware before Web API
            app.UseStormpath(new StormpathConfiguration
            {
                Application = new ApplicationConfiguration
                {
                    Name = "My Application"
                }
            });

            // Add Web API
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
