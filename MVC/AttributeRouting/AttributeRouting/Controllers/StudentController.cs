using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting.Models;

namespace AttributeRouting.Controllers
{
     [RoutePrefix("students")]
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name= "Santosh"},
            new Student{Id=2, Name= "GuruKiran"},
            new Student{Id=3, Name= "Vaishnavi"},
            new Student{Id=4, Name= "Swapna"},
        };

        //1.  without routeprefix [Route("Student")]
         [Route]
        [HttpGet]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }

        //2. by id
        [HttpGet]
          [Route("{sid}")]
        public ActionResult GetStudentById(int sid)
        {
            Student std = students.FirstOrDefault(s => s.Id == sid);
           // Student std = students.Find(s => s.Id == sid);

            return View(std);
        }

        //3. lets us create course details for students
        [HttpGet]
        [Route("{sid}/courses")]
       // [Route("students/{sid}/courses")]
        public ActionResult GetStudentCourse(int sid)
        {
            List<string> courseList = new List<string>();
            if (sid == 1)
                courseList = new List<string>() { "ASP.Net", "C#", "SQL" };
            else if(sid == 2)
                courseList = new List<string>() { "ASP.Net", "C#.Net", "ADO.Net" };
            else if(sid == 3)
                courseList = new List<string>() { "ASP.Net", "WebAPI", "C#.Net" };
            else
                courseList = new List<string>() { "BootStrap", "JavaScript", "HTML" };
            ViewBag.course = courseList;
            return View();

        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}