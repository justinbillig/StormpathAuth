using System.Web;
using System.Web.Mvc;

namespace AppServer2.Filters
{
    /// <summary>
    /// Allow for CORS access to MVC resources.
    /// </summary>
    /// <remarks>See http://stackoverflow.com/questions/27218240/cors-in-asp-net-mvc5 </remarks>
    public class AllowCorsAttribute : ActionFilterAttribute
    {
        private readonly string origins;
        private readonly string headers;
        private readonly string methods;

        public AllowCorsAttribute(string origins, string headers, string methods)
        {
            this.origins = origins;
            this.headers = headers;
            this.methods = methods;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpResponseBase response = filterContext.RequestContext.HttpContext.Response;

            response.AddHeader("Access-Control-Allow-Origin", origins);
            response.AddHeader("Access-Control-Allow-Headers", headers);
            response.AddHeader("Access-Control-Allow-Methods", methods);

            base.OnActionExecuting(filterContext);
        }
    }
}