using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Cors;
using Microsoft.Owin.Cors;
using Owin;

namespace AppServer2
{
    public partial class Startup
    {
        public void ConfigureCors(IAppBuilder app)
        {
            var corsPolicy = new CorsPolicy
            {
                AllowAnyMethod = false,
                AllowAnyHeader = false,
                AllowAnyOrigin = false,
                SupportsCredentials = true
            };

            var origins = ConfigurationManager.AppSettings["CorsOrigins"];
            var headers = ConfigurationManager.AppSettings["CorsHeaders"];
            var methods = ConfigurationManager.AppSettings["CorsMethods"];

            AddTokens(origins, corsPolicy.Origins);
            AddTokens(headers, corsPolicy.Headers);
            AddTokens(methods, corsPolicy.Methods);

            var corsOptions = new CorsOptions
            {
                PolicyProvider = new CorsPolicyProvider
                {
                    PolicyResolver = context => Task.FromResult(corsPolicy)
                }
            };

            app.UseCors(corsOptions);
        }

        private void AddTokens(string tokens, IList<string> target)
        {
            if (!string.IsNullOrEmpty(tokens))
            {
                foreach (var token in tokens.Split(','))
                {
                    target.Add(token.Trim());
                }
            }
        }
    }
}
