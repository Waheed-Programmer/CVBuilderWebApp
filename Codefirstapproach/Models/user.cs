using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class user
    {
         [Key]
        public int userid  { get; set; }
        [StringLength(50)]
        [Display(Name = "User")]
        [Required(ErrorMessage = "User Name Required")]
        public String username { get; set; }
        [StringLength(50)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Required")]
        public String email { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Required")]
        public String password { get; set; }
    }
}