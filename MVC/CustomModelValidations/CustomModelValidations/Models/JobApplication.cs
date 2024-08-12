using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CustomModelValidations.CustomValidations;

namespace CustomModelValidations.Models
{
    public class JobApplication
    {
        [Required]
        [Display(Name ="Applicant Name")]
        public string name { get; set; }
        [Display(Name ="Years of Experience")]
        [Range(3,10,ErrorMessage ="experience must be between 3 and 10 Years")]
        public int experience { get; set; }
        [Display(Name ="DOB")]
        [DataType(DataType.Date)]
        [ValidBirthDate(ErrorMessage ="DOB should be between 01/01/1995 and 30/01/2003 only")]
        public DateTime birthdate { get; set; }
        [Required]
        [Display(Name ="Email ID")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})$", ErrorMessage =
            "Invalid Email Id")]
        public string email { get; set; }
        [GenderValidate(ErrorMessage ="Please Select Your Gender")]
        public string Gender { get; set; }
        [Display(Name ="Expected Salary")]
        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$",
            ErrorMessage ="Salary should be like 6000.45")]
        public decimal expsal { get; set; }
        [SkillValidation(ErrorMessage ="Select atleast 3 Skills")]
        public List<CheckBox> Skills { get; set; }
        public string HavePassport { get; set; }
    }
}