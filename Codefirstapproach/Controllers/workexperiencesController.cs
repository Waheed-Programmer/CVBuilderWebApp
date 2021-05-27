using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Codefirstapproach.Models;

namespace Codefirstapproach.Controllers
{
    public class workexperiencesController : Controller
    {
        private Codefirst db = new Codefirst();

        // GET: workexperiences
     
        public ActionResult Create()
        {

            var userInCookie = Request.Cookies["AccountInfo"];
            if (userInCookie != null)
            {
                ViewBag.userid = new SelectList(db.users, "userid", "username");
                return View();

            }
            else
            {

                return RedirectToAction("Login", "Account");

            }
          
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( workexperience workexperience)
        {
            if (ModelState.IsValid)
            {
                var userInCookie = Request.Cookies["AccountInfo"];
                int User_id;
                User_id = Convert.ToInt32(userInCookie["idUser"]);

                workexperience.userid = User_id;
                db.workexperiences.Add(workexperience);
                db.SaveChanges();
                return RedirectToAction("Create", "skills");
            }

            ViewBag.userid = new SelectList(db.users, "userid", "username", workexperience.userid);
            return View(workexperience);
        }

        // GET: workexperiences/Edit/5
      
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
