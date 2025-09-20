using Microsoft.AspNetCore.Mvc;

namespace FirstWebsite.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Show()
        {
            return "This is a second action method of Text Controller!";
        }

        public int StudentId(int id)
        {
            return id;
        }
    }
}