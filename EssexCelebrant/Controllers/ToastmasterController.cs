using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class ToastmasterController : Controller
    {
        // GET: Toastmaster
        public ActionResult Index()
        {
            return View("Toastmaster");
        }
    }
}