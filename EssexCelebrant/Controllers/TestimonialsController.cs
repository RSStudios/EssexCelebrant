using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class TestimonialsController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View();
        }
    }
}