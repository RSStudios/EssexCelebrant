using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class WeddingsController : Controller
    {
        public ActionResult Index()
        {
            return View("Weddings");
        }
    }
}