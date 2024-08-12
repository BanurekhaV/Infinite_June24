using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Storedproc_Prj.Models
{
    public class Department
    {
        [Key]
        public int DId { get; set; }
        public string Dname { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}