using Microsoft.Owin;
using Owin;
using Stormpath.AspNet;

[assembly: OwinStartup(typeof(AppServer2.Startup))]

namespace AppServer2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseStormpath();
        }
    }
}
