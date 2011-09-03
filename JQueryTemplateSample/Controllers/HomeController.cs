using System.Collections.Generic;
using System.Web.Mvc;
using JQueryTemplateSample.Models;

namespace JQueryTemplateSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentRepository deptRepository;

        public HomeController(IDepartmentRepository departmentRepository)
        {
            deptRepository = departmentRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDepartments()
        {
            IEnumerable<string> dept = deptRepository.GetDepartments();
            return Json(dept, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetEmployeesByDepartment(string department)
        {
            IEnumerable<Employee> employees = deptRepository.GetEmployeesByDepartment(department);
            return Json(employees);
        }
    }
}