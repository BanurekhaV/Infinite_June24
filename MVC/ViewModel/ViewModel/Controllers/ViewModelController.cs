using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class ViewModelController : Controller
    {
        // GET: ViewModel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employeedetails()
        {
            Employee e = new Employee()
            {
                Eid = 101,
                Ename = "Jamuna",
                Salary = 45000,
                AddressId = 1
            };

            Address addr = new Address()
            {
                AddressId = 1,
                DoorNo = "45, ABC Apts",
                Street = "MyGulli",
                City = "MyCity"
            };

            //create an object of the Viewmodel clas
            EmployeeAddress empadd = new EmployeeAddress()
            {
                employee = e,
                address = addr,
                PageTitle = "Employee Personal Details"
            };
            return View(empadd);
        }
    }
}