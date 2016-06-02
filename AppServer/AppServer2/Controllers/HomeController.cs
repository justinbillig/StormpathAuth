using System.Web.Mvc;

namespace AppServer2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [Authorize]
        public JsonResult MoreValues()
        {
            var values = new[] {"value1", "value2", "value3"};

            return Json(values);
        }
    }
}
