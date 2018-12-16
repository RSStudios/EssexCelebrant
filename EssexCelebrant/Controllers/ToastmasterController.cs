using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class ToastmasterController : Controller
    {
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View("Toastmaster");
        }
    }
}