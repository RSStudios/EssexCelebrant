using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class SpeechWritingController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View();
        }
    }
}