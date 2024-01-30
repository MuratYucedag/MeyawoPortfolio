using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}