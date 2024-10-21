using CalorieCounter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace CalorieCounter.Controllers
{
    public class HomeController : Controller
    {
        private CalorieDBContext context { get; set; } //instance of CalorieDBContext called context

        public HomeController(CalorieDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var calories = this.context.Calories.OrderBy(c => c.Name).ToList(); //Retrieve all info from the Calorie table, order it by name, then turns it into a list.
            return View(calories); //Returns the list to the index
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("FoodForm"); //Link to the FoodForm page
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var c = context.Calories.Find(id); //Find the food in the database by it's ids
            return View("FoodForm", c); //Return the FoodForm by the food id
        }
        [HttpPost]
        public IActionResult Edit(Calorie c)
        {
            if (ModelState.IsValid) //Checks if form data submitted is correct
            {
                if (c.Id == 0) //If id is 0, means that a new food is being added
                {
                    context.Calories.Add(c); //Adds it to the database
                }
                else
                {
                    context.Calories.Update(c); //If not 0, it means we are updating an already existing food
                }
                context.SaveChanges(); //Saves the changes made above
                var chars = context.Calories.ToList(); 
                return View("Index", chars); //Goes back to Index page with the new changes
            }
            else
            {
                return View("FoodForm", c); //Invalid data means staying on the FoodForm page
            }

        }
        public IActionResult Delete(int id)
        {
            Calorie del = context.Calories.Find(id); //Find the food using its id
            context.Calories.Remove(del); //Removes the food that's been clicked
            context.SaveChanges(); //Save the changes to the database
            var c = context.Calories.ToList(); 
            return View("Index", c); //Goes back to Index page with the new changes
        }
        public IActionResult Calculate()
        {
            var totalCalories = context.Calories.Sum(c => c.Calories ?? 0); //Sums up all the calories from the Calories table. If it's null, return 0

            ViewBag.TotalCalories = totalCalories; //Stores the total calories in the ViewBag

            return View("CalculateCal"); //Returns the CalculateCal page
        }
    }
}
