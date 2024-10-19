using CalorieCounter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalorieCounter.Controllers
{
    public class HomeController : Controller
    {
        private CalorieDBContext context {  get; set; }

        public HomeController(CalorieDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var calories = this.context.Calories.OrderBy(c => c.Name).ToList();
            return View(calories);
        }

    }
}
