﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Community.Models;

namespace Community.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CommunityAssist2017Entities db = new CommunityAssist2017Entities();
            return View(db.People.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}