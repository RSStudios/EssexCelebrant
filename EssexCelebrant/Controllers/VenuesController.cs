﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssexCelebrant.Controllers
{
    public class VenuesController : Controller
    {
        // GET: Venues
        public ActionResult Index()
        {
            return View("Venues");
        }
    }
}