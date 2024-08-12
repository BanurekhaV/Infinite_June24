using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CustomModelValidations.Models;

namespace CustomModelValidations.CustomValidations
{
    public class ValidBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime entered_dob = Convert.ToDateTime(value);
            DateTime mindt = Convert.ToDateTime("01/01/1995");
            DateTime maxdt = Convert.ToDateTime("30/01/2003");

            if (entered_dob >= mindt && entered_dob <= maxdt)
            {

                return ValidationResult.Success;
            }
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}