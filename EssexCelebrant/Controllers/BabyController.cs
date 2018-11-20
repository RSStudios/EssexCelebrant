using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class BabyController : Controller
    {
        public ActionResult Index()
        {
            return View("Naming");
        }

        public ActionResult Naming()
        {
            return View();
        }

        public ActionResult Funeral()
        {
            return View();
        }
    }
}