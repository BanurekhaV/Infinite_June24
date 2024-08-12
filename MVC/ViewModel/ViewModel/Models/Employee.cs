using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class Employee
    { 
        public int Eid { get; set; }
        public string Ename { get; set; }
        public decimal Salary { get; set; }
        public int ? AddressId { get; set; }
    }
}