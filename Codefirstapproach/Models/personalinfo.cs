using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class personalinfo
    {
        [Key]
        public int pid  { get; set; }
        [StringLength(50)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Name Required")]
        public String fname  { get; set; }
       
        [Display(Name = "DOB")]
        [Required(ErrorMessage = "DOB Required")]
        public String date_birth { get; set; }
        [StringLength(50)]
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address Required")]
        public String address { get; set; }
        [StringLength(50)]
        [Display(Name = "Nationality")]
        [Required(ErrorMessage = "Nationality Required")]
        public String nationality { get; set; }
        
        [Display(Name = "Phon#")]
        [Required(ErrorMessage = "Phon# Required")]
        public String phone { get; set; }
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Required")]
        public String email { get; set; }
        public int? userid { get; set; }
        [ForeignKey("userid")]
        public virtual user user { get; set; }

    }
}