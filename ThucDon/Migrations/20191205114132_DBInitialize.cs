using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThucDon.Migrations
{
    public partial class DBInitialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DishesModels",
                columns: table => new
                {
                    DishID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calories = table.Column<int>(nullable: false),
                    Protein = table.Column<int>(nullable: false),
                    Fat = table.Column<int>(nullable: false),
                    Fiber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishesModels", x => x.DishID);
                });

            migrationBuilder.CreateTable(
                name: "RawFoodModels",
                columns: table => new
                {
                    FoodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calories = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Protein = table.Column<int>(nullable: false),
                    Fat = table.Column<int>(nullable: false),
                    Fiber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawFoodModels", x => x.FoodID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishesModels");

            migrationBuilder.DropTable(
                name: "RawFoodModels");
        }
    }
}
