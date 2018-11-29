using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class FuneralsController : Controller
    {
        //[OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Baby()
        {
            return View("~/Views/baby/Funeral.cshtml");
        }

        public ActionResult Photography()
        {
            return View();
        }
    }
}