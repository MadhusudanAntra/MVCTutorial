using Microsoft.AspNetCore.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> emps = new List<Employee> {
             new Employee{Id=1, Name="Pam", EmailId="Pam@demo.com", Phone="9876543210" },
             new Employee{Id=2, Name="Sarah", EmailId="Pam@demo.com", Phone="9876543210" },
             new Employee{Id=3, Name="William", EmailId="Pam@demo.com", Phone="9876543210" },

            };
            return View(emps);
        }
    }
}
