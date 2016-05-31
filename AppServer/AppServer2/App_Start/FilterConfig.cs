using System.Configuration;
using System.Web;
using System.Web.Mvc;
using AppServer2.Filters;

namespace AppServer2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // Allow CORS for all MVC controllers.
            filters.Add(new AllowCorsAttribute(ConfigurationManager.AppSettings["CorsOrigins"],
                                                ConfigurationManager.AppSettings["CorsHeaders"],
                                                ConfigurationManager.AppSettings["CorsMethods"]));
        }
    }
}
