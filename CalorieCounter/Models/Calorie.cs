using System.ComponentModel.DataAnnotations;

namespace CalorieCounter.Models
{
    public class Calorie
    {
        [Required(ErrorMessage = "Please enter the food name.")]
        public string Name {  get; set; }
        public int? Calories {  get; set; }

    }
}
