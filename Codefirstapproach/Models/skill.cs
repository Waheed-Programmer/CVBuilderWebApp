using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirstapproach.Models
{
    public class skill
    {
        [Key]
        public int skillid { get; set; }
        [StringLength(50)]
        [Display(Name = "Skill")]
        [Required(ErrorMessage = "Skill Required")]
        public String skil { get; set; }
        public int? userid { get; set; }
        [ForeignKey("userid")]
        public virtual user user { get; set; }
    }

}
