using System.Collections.Generic;

namespace JQueryTemplateSample.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<string> GetDepartments();
        IEnumerable<Employee> GetEmployeesByDepartment(string deptName);
    }
}