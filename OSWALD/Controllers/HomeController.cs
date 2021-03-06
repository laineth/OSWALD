﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OSWALD.DAL;
using OSWALD.Models;

namespace OSWALD.Controllers
{
    public class HomeController : Controller
    {
        private ConversationContext db = new ConversationContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Conversations.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
