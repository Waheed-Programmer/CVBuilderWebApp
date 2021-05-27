using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class workexperience
    {
        [Key]
        public int workid { get; set; }
        [StringLength(50)]
        [Display(Name = "Company")]
        [Required(ErrorMessage = "Company Required")]
        public String company_name  { get; set; }
        [StringLength(50)]
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title Required")]
        public String title { get; set; }
        [StringLength(50)]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country Required")]
        public String countary { get; set; }
       
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date Required")]
        public String start_date { get; set; }
       
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date Required")]
        public String end_date { get; set; }
        [StringLength(50)]
        [Display(Name = "Discription")]
        [Required(ErrorMessage = "Description Required")]
        public String description { get; set; }
        public int? userid { get; set; }
        [ForeignKey("userid")]
        public virtual user user { get; set; }
    }
}