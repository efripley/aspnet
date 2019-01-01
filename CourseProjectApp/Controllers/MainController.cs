using Microsoft.AspNetCore.Mvc;

namespace CourseProjectApp.Mvc{
    public class MainController : Controller{
        public IActionResult Index(){
            ViewBag.value = "My First MVC Route";
            return View();
        }
    }
}