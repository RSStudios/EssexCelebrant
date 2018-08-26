using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class VenuesController : Controller
    {
        public ActionResult Index()
        {
            return View("Venues");
        }
    }
}