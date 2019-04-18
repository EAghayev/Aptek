using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aptek.Models;

namespace Aptek.Controllers
{
    public class DrugsController : Controller
    {
        private AptekEntities db = new AptekEntities();

        // GET: Drugs
        public ActionResult Index(int?id)
        {
            List<Drug> model = db.Drugs.Where(d => id == null ? true : (d.CategoryId == id)).ToList();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            Drug drug = db.Drugs.Find(id);

            return View(drug);
        }
    }
}