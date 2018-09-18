using EssexCelebrant.Business;
using EssexCelebrant.Models;
using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class VenuesController : Controller
    {
        public ActionResult Index()
        {
            var url = Helper.AppSetting("JSON.Venues");
            var results = Venues.GetVenues(url);

            return View("Venues", results);
        }
    }
}