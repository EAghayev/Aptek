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
        public ActionResult Index(int?id,string name)
        {
            var model = db.Drugs.Where(d => id == null ? true : (d.CategoryId == id)).AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                model = model.Where(m => m.Name.Contains(name)).AsQueryable();
            }

            return View(model.ToList());
        }

        public ActionResult Details(int id)
        {
            Drug drug = db.Drugs.Find(id);

            return View(drug);
        }
    }
}