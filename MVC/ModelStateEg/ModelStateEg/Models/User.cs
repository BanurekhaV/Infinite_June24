using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ModelStateEg.Models
{
    public class User
    {
        [Required(ErrorMessage ="First Name is a must")]
        [Display(Name ="User First Name ")]
        [StringLength(25, ErrorMessage ="First Name can be only upto 25 characters")]
        public string Fname { get; set; }
        [DisplayName("LastName")]
        public string Lname { get; set; }
        [Display(Name ="Age")]
       // [Range(21,45,ErrorMessage ="Age has to be between 21 and 45 only")]
        [Required(ErrorMessage ="Please Enter Age")]
        public int age { get; set; }
        [Required(ErrorMessage ="Please Enter a Valid Email")]
        [Display(Name ="Email Id")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})$",ErrorMessage =
            "Invalid Email Id")]
        public string email { get; set; }
    }
}