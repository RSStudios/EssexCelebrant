using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class LinksController : Controller
    {
        public ActionResult Index()
        {
            return View("Links");
        }
    }
}