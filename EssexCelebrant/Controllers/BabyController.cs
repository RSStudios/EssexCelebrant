using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class BabyController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View("Naming");
        }

        [OutputCache(CacheProfile = "DefaultCache")]
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