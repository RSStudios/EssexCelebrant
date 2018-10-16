using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class OtherCelebrationsController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View("OtherCelebrations");
        }
    }
}