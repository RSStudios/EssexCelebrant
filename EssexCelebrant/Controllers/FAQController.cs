using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class FAQController : Controller
    {
        public ActionResult Index(string faqType)
        {
            switch (faqType)
            {
                case ("Funerals"):
                    return View("FAQFunerals");
                case "Celebrant":
                    return View("FAQCelebrant");
                default:
                    return View("FAQ");
            }
            
        }
    }
}