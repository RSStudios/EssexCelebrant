using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class CelebrantController : Controller
    {
        //[OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View();
        }
    }
}