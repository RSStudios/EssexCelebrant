using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class ToastmasterController : Controller
    {
        public ActionResult Index()
        {
            return View("Toastmaster");
        }
    }
}