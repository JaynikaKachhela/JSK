using JobPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JobPortal.Controllers
{
    public class ApplicantController : Controller
    {
            private JobPortalContext db = new JobPortalContext();
           
            public ActionResult Apply()
            {
            return View();
            }
            [HttpPost]
            public ActionResult Apply([Bind(Include="Name , Email, PhoneNumber,GitHubUrl")] Applicant applicant)
            {
                if (ModelState.IsValid)
                {
                    db.Applicant.Add(applicant);
                    
                    db.SaveChanges();
                    return RedirectToAction("Detail","Job");
                }

                return View(applicant);
            }
            public ActionResult List(Job job)
            {
                return View(db.Job.ToList());
            }
        }
    }
