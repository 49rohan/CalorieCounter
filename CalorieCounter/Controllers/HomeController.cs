using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalorieCounter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
