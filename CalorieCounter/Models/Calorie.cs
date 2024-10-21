using System.ComponentModel.DataAnnotations;

namespace CalorieCounter.Models
{
    public class Calorie
    {
        //Variables with getters and setters for the calorie counter website
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the name of the food")]
        public string Name {  get; set; }
        public int? Calories {  get; set; }

    }
}
