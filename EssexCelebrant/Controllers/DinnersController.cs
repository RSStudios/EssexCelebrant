using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class DinnersController : Controller
    {
        // GET: Dinners
        public ActionResult Index()
        {
            return View("Dinners");
        }
    }
}