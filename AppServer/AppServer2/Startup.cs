using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Stormpath.AspNet;
using Stormpath.Configuration.Abstractions;

[assembly: OwinStartup(typeof(AppServer2.Startup))]

namespace AppServer2
{
    using System.Web.Http;
    using AppFunc = Func<IDictionary<string, object>, Task>;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use(new Func<AppFunc, AppFunc>(next => (async env =>
            {
                if ((string)env["owin.RequestMethod"] != "OPTIONS")
                {
                    await next.Invoke(env);
                    return;
                }

                return;
            })));

            app.UseStormpath(new StormpathConfiguration
            {
                Application = new ApplicationConfiguration
                {
                    Name = "My Application"
                }
            });

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
