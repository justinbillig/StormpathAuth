using Microsoft.Owin;
using Owin;
using Stormpath.AspNet;
using Stormpath.Configuration.Abstractions;

[assembly: OwinStartup(typeof(AppServer2.Startup))]

namespace AppServer2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //  app.UseCors();

            app.UseStormpath();
        }
    }
}
