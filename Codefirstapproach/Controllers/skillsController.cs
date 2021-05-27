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
    public class skillsController : Controller
    {
        private Codefirst db = new Codefirst();

        // GET: skills
       

        // GET: skills/Create
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
        public ActionResult Create( skill skill)
        {
            if (ModelState.IsValid)
            {
                var userInCookie = Request.Cookies["AccountInfo"];
                int User_id;
                User_id = Convert.ToInt32(userInCookie["idUser"]);

                skill.userid = User_id;
                db.skills.Add(skill);
                db.SaveChanges();
                return RedirectToAction("Index" , "Home");
            }

            ViewBag.userid = new SelectList(db.users, "userid", "username", skill.userid);
            return View(skill);
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
