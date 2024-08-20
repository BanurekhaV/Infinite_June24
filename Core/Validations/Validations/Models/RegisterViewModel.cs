using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Validations.Models
{
    public class RegisterViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress(ErrorMessage ="please enter a Valid email")]
        [Remote(action:"IsEmailAvailable", controller:"RemoteValidation",
            ErrorMessage ="Email is in use.. Use a different email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="User Name is Required")]
        [MinLength(6,ErrorMessage ="Minimum 6 characters")]
        [Remote(action: "IsUserNameAvailable",controller:"Remotevalidation",
            ErrorMessage ="username is in use, try some other User name")]
        public string UserName {  get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
    }
}
