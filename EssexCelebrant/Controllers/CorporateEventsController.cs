using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class CorporateEventsController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View();
        }
    }
}