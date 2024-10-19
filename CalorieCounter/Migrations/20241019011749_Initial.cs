using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieCounter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Calories",
                columns: new[] { "Id", "Calories", "Name" },
                values: new object[,]
                {
                    { 1, 105, "Banana" },
                    { 2, 95, "Apple" },
                    { 3, 45, "Orange" },
                    { 4, 563, "Big Mac" },
                    { 5, 140, "Takis" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calories");
        }
    }
}
