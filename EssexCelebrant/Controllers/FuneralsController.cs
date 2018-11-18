using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class FuneralsController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View();
        }
    }
}