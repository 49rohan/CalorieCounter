using System.ComponentModel.DataAnnotations;

namespace CalorieCounter.Models
{
    public class Calorie
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public int? Calories {  get; set; }

    }
}
