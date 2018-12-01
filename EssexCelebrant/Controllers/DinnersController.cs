using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class DinnersController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View("Dinners");
        }
    }
}