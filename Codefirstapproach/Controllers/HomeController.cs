using Codefirstapproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codefirstapproach.Controllers
{
    public class HomeController : Controller
    {
        Codefirst db = new Codefirst();
        public ActionResult Index()
        {
            var userInCookie = Request.Cookies["AccountInfo"];
            if (userInCookie != null)
            {

                var std = GetPersonalinfos();
                var tchr = GetEducations();

                var edu = GetWorkexperience();
                var sk = GetSkill();

                MultiModel data = new MultiModel();
                data.My_personalinfo = std;
                data.My_education = tchr;
                data.My_workexperience = edu;
                data.My_skill = sk;

                return View(data);


            }
            else
            {

                return RedirectToAction("Login", "Account");

            }
        }

        public personalinfo GetPersonalinfos()
        {
            
            return db.personalinfos.ToList()
                .OrderByDescending(q => q.pid).FirstOrDefault();
        }
        public education GetEducations()
        {

            return db.educations.ToList().OrderByDescending(q => q.eduid).FirstOrDefault();
        }

        public workexperience GetWorkexperience()
        {

            return db.workexperiences.ToList()
                .OrderByDescending(q => q.workid).FirstOrDefault();
        }
        public skill GetSkill()
        {

            return db.skills.ToList().OrderByDescending(q => q.skillid).FirstOrDefault();
            

        }
       
        public ActionResult Dashboard()
        {
            return View();
           
        }

    }
}