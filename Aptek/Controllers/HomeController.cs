using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aptek.Models;

namespace Aptek.Controllers
{
    public class HomeController : Controller
    {
        private AptekEntities db;

        public HomeController()
        {
            db = new AptekEntities();
        }

        public ActionResult Index()
        {
            IndexModel model = new IndexModel
            {
                Categories = db.Categories.ToList(),
                Drugs = db.Drugs.ToList(),
                Articles=db.Articles.ToList()
            };
            return View(model);
        }

        public ActionResult About()
        {
            var model = db.Settings.FirstOrDefault();  
            return View(model);
        }

        public ActionResult Contact()
        {
            var model = db.Settings.FirstOrDefault();
            return View(model);
        }

      
    }
}