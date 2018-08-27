using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class FAQController : Controller
    {
        public ActionResult Index()
        {
            return View("FAQ");
        }
    }
}