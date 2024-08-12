using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Storedproc_Prj.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
        public virtual Department Department { get; set; }
    }
}