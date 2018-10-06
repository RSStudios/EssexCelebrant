using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Glenn Mayes";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me";

            return View();
        }
    }
}