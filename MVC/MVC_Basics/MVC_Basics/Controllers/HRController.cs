using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Basics.Models;

namespace MVC_Basics.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //3. 
        public ActionResult Index()
        {
            List<Department> d = new List<Department>();
            d.Add(new Department { Id = 10, Dname = "CSE" });
            d.Add(new Department { Id = 11, Dname = "IT" });
            d.Add(new Department { Id = 12, Dname = "ECE" });
            d.Add(new Department { Id = 13, Dname = "EEE" });
            return View("DepartmentList",d);
        }

        //1. binding a model object to the view
        public ActionResult DisplayEmployee()
        {
            Employee e = new Employee() { Id = 1, Name = "Infinite", Age = 25 };
            return View(e);  //view is bound to an model object
        }

        //2. 
        public ActionResult EmployeesList()
        {
            List<Employee> lstemp = new List<Employee>()
            {
                new Employee{Id=100,Name="Adi", Age=22},
                new Employee{Id=101,Name="Eswar", Age=22},
                new Employee{Id=102,Name="Naman", Age=21},
            };
            return View(lstemp);
        }

        //4.
        public ActionResult DepartmentList(Department dept)
        {
            return View(dept);
        }


    }
}