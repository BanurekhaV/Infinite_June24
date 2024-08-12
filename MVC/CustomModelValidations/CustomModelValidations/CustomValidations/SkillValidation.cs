using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CustomModelValidations.Models;

namespace CustomModelValidations.CustomValidations
{
    public class SkillValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<CheckBox> skills_selected = value as List<CheckBox>;
            int count = skills_selected == null ? 0 : (from s in skills_selected
                                                       where s.IsChecked == true
                                                       select s).Count();
            if (count >= 3)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}