using JobPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JobPortal.Controllers
{
    public class JobController : Controller
    {
        private JobPortalContext db = new JobPortalContext();
        // GET: Job
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Job job)
        {
            if (ModelState.IsValid)
            {
                db.Job.Add(job);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(job);
        }
        public ActionResult List(Job job)
        {
            return View(db.Job.ToList());
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Job.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

    }
}