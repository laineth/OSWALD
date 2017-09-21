﻿using OSWALD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSWALD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var oswin = new Chatbot
            {
                BotName = "Oswin: ",
                Greetings = "Hello! I am here to give you information about Thomas."
            };

            return View(oswin);
        }
    }
}