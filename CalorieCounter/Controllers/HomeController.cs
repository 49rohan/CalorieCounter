using CalorieCounter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalorieCounter.Controllers
{
    public class HomeController : Controller
    {
        private CalorieDBContext context { get; set; }

        public HomeController(CalorieDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var calories = this.context.Calories.OrderBy(c => c.Name).ToList();
            return View(calories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("FoodForm");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var c = context.Calories.Find(id);
            return View("FoodForm", c);
        }
        [HttpPost]
        public IActionResult Edit(Calorie c)
        {
            if (ModelState.IsValid)
            {
                if (c.Id == 0)
                {
                    context.Calories.Add(c);
                }
                else
                {
                    context.Calories.Remove(c);
                }
                context.SaveChanges();
                var chars = context.Calories.ToList();
                return View("Index", chars);
            }
            else
            {
                return View("FoodForm", c);
            }

        }
    }
}
