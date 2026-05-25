using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult IssueBook()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}