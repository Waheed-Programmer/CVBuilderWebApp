using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class Codefirst :DbContext
    {
        
        public Codefirst() : base("cv_builder")
        {
        }
        
        public DbSet<user> users { get; set; }
        public DbSet<personalinfo> personalinfos { get; set; }
        public DbSet<education> educations { get; set; }
        public DbSet<workexperience> workexperiences { get; set; }
        public DbSet<skill> skills { get; set; }

    }

    
}