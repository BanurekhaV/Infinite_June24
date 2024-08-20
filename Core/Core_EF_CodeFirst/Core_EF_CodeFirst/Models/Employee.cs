namespace Core_EF_CodeFirst.Models
{
    public class Employee
    {
        public int EmployeeId { get;set; }
        public string ?Name { get;set; }
        public string ?Email { get;set; }
        public string ?Position { get; set; }
        public int DeptId { get; set; }

        public Department? Department { get; set; } 
    }
}
