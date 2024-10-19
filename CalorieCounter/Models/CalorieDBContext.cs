using Microsoft.EntityFrameworkCore;

namespace CalorieCounter.Models
{
    public class CalorieDBContext : DbContext
    {
        public CalorieDBContext
            (DbContextOptions<CalorieDBContext> options) :base (options) 
        {
            
        }

        public DbSet<Calorie> Calories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Calorie>().HasData(
                new Calorie
                {
                    Name = "Banana",
                    Calories = 105
                },
                new Calorie
                {
                    Name = "Apple",
                    Calories = 95
                },
                new Calorie
                {
                    Name = "Orange",
                    Calories = 45
                },
                new Calorie
                {
                    Name = "Big Mac",
                    Calories = 563
                },
                new Calorie
                {
                    Name = "Takis",
                    Calories = 140
                });
        }
    }
}
