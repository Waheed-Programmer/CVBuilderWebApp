using Codefirstapproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codefirstapproach.Controllers
{
    public class AccountController : Controller
    {
        Codefirst db = new Codefirst();
      
        [HttpGet]
        public  ActionResult register()
        { 

            return View();
        }
      
        [HttpPost]
        public ActionResult register(user u)
        {
            db.users.Add(u);
            db.SaveChanges();
            return RedirectToAction("Login");
            
        }
        // Login 
        [HttpGet]
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(user user)
        {


          

                var data = db.users. Where(s => s.username.Equals(user.username) && s.password.Equals(user.password)).ToList();
                if (data.Count() > 0)
                {
                    HttpCookie cooskie = new HttpCookie("AccountInfo");
                    cooskie.Values["idUser"] = Convert.ToString(data.FirstOrDefault().userid);
                    cooskie.Values["FullName"] = Convert.ToString(data.FirstOrDefault().username);
                    cooskie.Expires = DateTime.Now.AddMonths(1);
                    Response.Cookies.Add(cooskie);
                return RedirectToAction("Dashboard", "Home");
                //return RedirectToAction("Create", "personalinfoes");
            }

              
                return View();
            

        }
        public ActionResult Logout()
        {
            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("AccountInfo"))
            {
                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["AccountInfo"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
            }
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}