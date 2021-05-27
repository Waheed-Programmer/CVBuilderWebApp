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
    public class educationsController : Controller
    {
        private Codefirst db = new Codefirst();

      
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
        public ActionResult Create( education education)
        {
            if (ModelState.IsValid)
            {
                var userInCookie = Request.Cookies["AccountInfo"];
                int User_id;
                User_id = Convert.ToInt32(userInCookie["idUser"]);

                education.userid = User_id;
                db.educations.Add(education);
                db.SaveChanges();
                return RedirectToAction("Create", "workexperiences");
            }

            ViewBag.userid = new SelectList(db.users, "userid", "username", education.userid);
            return View(education);
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
