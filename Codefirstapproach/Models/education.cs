using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class education
    {
        [Key]
        public int eduid  { get; set; }
        [StringLength(50)]
        [Display(Name = "Institute")]
        [Required(ErrorMessage = "Institute Required")]
        public String institute { get; set; }
        [StringLength(50)]
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title Required")]
        public String title { get; set; }
        [StringLength(50)]
        [Display(Name = "Degree")]
        [Required(ErrorMessage = "Degree Required")]
        public String degree { get; set; }
        [StringLength(50)]
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date Required")]
        public String start_date  { get; set; }
       
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date Required")]
        public String end_date { get; set; }
       
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address Required")]
        public String address { get; set; }
        public int? userid { get; set; }
        [ForeignKey("userid")]
        public virtual user user { get; set; }
    }
}