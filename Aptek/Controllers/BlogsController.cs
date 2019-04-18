using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Aptek.Models;

namespace Aptek.Controllers
{
    public class BlogsController : Controller
    {
        private AptekEntities db = new AptekEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Models.Article article = db.Articles.Find(id);
            return View(article);
        }
    }
}
