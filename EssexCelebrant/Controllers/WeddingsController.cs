using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class WeddingsController : Controller
    {
        // GET: Weddings
        public ActionResult Index()
        {
            return View("Weddings");
        }
    }
}