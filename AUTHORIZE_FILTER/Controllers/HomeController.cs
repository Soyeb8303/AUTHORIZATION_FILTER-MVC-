﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AUTHORIZE_FILTER.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    
        public ActionResult About()
        {
            return View();
        }
       // [Authorize]
        public ActionResult Contact()
        {
            return View();
        }


    }
}