using OSWALD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OSWALD.Controllers
{
    public class HomeController : Controller
    {
        // GET : www.oswaldtheai.com/
        public ActionResult Index()
        {
            var oswin = new Chatbot
            {
                BotName = "Oswin: "
            };

            return View(oswin);
        }
    }
}