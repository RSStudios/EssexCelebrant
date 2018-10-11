using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class OtherCelebrationsController : Controller
    {
        // GET: OtherCelebrations
        [OutputCache(CacheProfile = "DefaultCache")]
        public ActionResult Index()
        {
            return View("OtherCelebrations");
        }
    }
}