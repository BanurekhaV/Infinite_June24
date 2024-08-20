namespace Core_EF_CodeFirst.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string ?DName {  get; set; }

        public List<Employee> Employees { get; set; }
    }
}
