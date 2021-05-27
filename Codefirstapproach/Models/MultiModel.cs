using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class MultiModel
    {
         public personalinfo My_personalinfo { get; set; }
        public education My_education { get; set; }

        public workexperience My_workexperience { get; set; }
        public skill My_skill { get; set; }
    }
}