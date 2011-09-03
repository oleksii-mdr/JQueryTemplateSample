using System.Collections.Generic;
using System.Linq;

namespace JQueryTemplateSample.Models
{
    public class DeparmentRepository : IDepartmentRepository
    {
        private static readonly List<Employee> data = new List<Employee>();

        static DeparmentRepository()
        {
            data.Add(new Employee {Department = "Sales", Name = "Alan McMillan", Position = "Senjor Manager"});
            data.Add(new Employee {Department = "Sales", Name = "Din Shawn", Position = "Manager"});
            data.Add(new Employee {Department = "Sales", Name = "Kira Rigson", Position = "Assistant"});
            data.Add(new Employee {Department = "Development", Name = "Daren Smith", Position = "Team Lead"});
            data.Add(new Employee {Department = "Development", Name = "Karl Brown", Position = "Developer"});
            data.Add(new Employee {Department = "Development", Name = "Ivan Cresson", Position = "Developer"});
            data.Add(new Employee {Department = "Development", Name = "Max Sheridan", Position = "Developer"});
            data.Add(new Employee {Department = "Development", Name = "Stephen Balmers", Position = "Jn Developer"});
            data.Add(new Employee {Department = "QA", Name = "Glen Olbrige", Position = "Sn tester"});
            data.Add(new Employee {Department = "QA", Name = "Lara Stanf", Position = "tester"});
            data.Add(new Employee {Department = "QA", Name = "Keley Parcker", Position = "tester"});
            data.Add(new Employee {Department = "Executive", Name = "Ed Jesterson", Position = "Chief executive"});
        }

        #region IDepartmentRepository Members

        public IEnumerable<string> GetDepartments()
        {
            return (from d in data
                    orderby d.Department ascending
                    select d.Department).Distinct();
        }

        public IEnumerable<Employee> GetEmployeesByDepartment(string deptName)
        {
            return from e in data
                   where e.Department == deptName
                   orderby e.Name ascending
                   select e;
        }

        #endregion
    }
}