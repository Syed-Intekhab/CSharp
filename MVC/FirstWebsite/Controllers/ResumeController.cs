using Microsoft.AspNetCore.Mvc;
using FirstWebsite.Models;

namespace FirstWebsite.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            Resume resume = new()
            {
                Name = "John Doe",
                Age = 18,
                Email = "john@example.com"
            };

            ViewData["skills"] = new List<string> { "Coding", "Reading", "Writing" };

            ViewData["resume"] = resume;

            Employee emp = new()
            {
                Name = "Jane Doe",
                Age = 18,
                Email = "jane@example.com"
            };

            ViewBag.Salary = 25000;
            ViewBag.Employee = emp;

            return View();
        }
    }
}
