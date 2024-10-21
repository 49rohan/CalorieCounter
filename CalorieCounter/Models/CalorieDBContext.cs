using Microsoft.EntityFrameworkCore;

namespace CalorieCounter.Models
{
    public class CalorieDBContext : DbContext //Inherits from DbContext
    {
        //Constructor method
        public CalorieDBContext
            (DbContextOptions<CalorieDBContext> options) :base (options) 
        {
            
        }

        public DbSet<Calorie> Calories { get; set; } //Creates a database

        //Seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Calorie>().HasData(
                new Calorie
                {
                    Id = 1,
                    Name = "Banana",
                    Calories = 105
                },
                new Calorie
                {
                    Id = 2,
                    Name = "Apple",
                    Calories = 95
                },
                new Calorie
                {
                    Id = 3,
                    Name = "Orange",
                    Calories = 45
                },
                new Calorie
                {
                    Id = 4,
                    Name = "Big Mac",
                    Calories = 563
                },
                new Calorie
                {
                    Id = 5,
                    Name = "Takis",
                    Calories = 140
                });
        }
    }
}
