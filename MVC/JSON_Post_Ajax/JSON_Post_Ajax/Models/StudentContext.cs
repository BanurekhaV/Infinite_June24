using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JSON_Post_Ajax.Models
{
    public class StudentContext :DbContext
    {
        public StudentContext() : base("name=StdContext") { }
        public DbSet<Student> Students { get; set; }
    }
}