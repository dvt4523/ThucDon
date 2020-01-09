using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThucDon.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        public DbInitializer (ApplicationDbContext db)
        {
            _db = db;
        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            if (_db.ProteinFoods.Any()) return;
            Models.RawFoodCategory ProteinFoods = new Models.RawFoodCategory { Name = "Protein Foods" };
            Models.RawFoodCategory FatFoods = new Models.RawFoodCategory { Name = "Fat Foods" };
            Models.RawFoodCategory CarbFoods = new Models.RawFoodCategory { Name = "Carb Foods" };
            Models.RawFoodCategory MiscFoods = new Models.RawFoodCategory { Name = "Misc Foods" };
            _db.RawFoodCategories.AddRange(ProteinFoods, FatFoods, CarbFoods, MiscFoods);

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 165,
                Protein = 31,
                Fat = 3,
                Carb = 0,
                Fiber = 0,
                Name = "Chicken Breast",
                FoodCategory = MiscFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 130,
                Protein = 2.7,
                Fat = 3,
                Carb = 78,
                Fiber = 1.6,
                Name = "Rice",
                FoodCategory = MiscFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 27,
                Protein = 1.86,
                Fat = 0,
                Carb = 0,
                Fiber = 2.6,
                Name = "Brocoli",
                FoodCategory = MiscFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 258,
                Protein = 25.6,
                Fat = 16.5,
                Carb = 0,
                Fiber = 0,
                Name = "Lamb Chop",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 100,
                Protein = 21,
                Fat = 1,
                Carb = 0,
                Fiber = 0,
                Name = "Sole",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 166,
                Protein = 19,
                Fat = 9,
                Carb = 1,
                Fiber = 0,
                Name = "Sardine",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 138,
                Protein = 23,
                Fat = 4,
                Carb = 0,
                Fiber = 0,
                Name = "Cod",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 234,
                Protein = 120,
                Fat = 30,
                Carb = 1,
                Fiber = 0,
                Name = "Mackerel",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 120,
                Protein = 30,
                Fat = 1,
                Carb = 0,
                Fiber = 0,
                Name = "Tuna",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 148,
                Protein = 28,
                Fat = 4,
                Carb = 0,
                Fiber = 0,
                Name = "Steak",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 348,
                Protein = 31,
                Fat = 23,
                Carb = 0,
                Fiber = 0,
                Name = "Beef Shredded",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 230,
                Protein = 13,
                Fat = 15,
                Carb = 60,
                Fiber = 0,
                Name = "Pork",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 18,
                Protein = 0,
                Fat = 0,
                Carb = 18,
                Fiber = 2.2,
                Name = "Tomato",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 87,
                Protein = 1.9,
                Fat = 0,
                Carb = 12,
                Fiber = 1.8,
                Name = "Potato",
                FoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 20,
                Protein = 1,
                Fat = 0,
                Carb = 5,
                Fiber = 3,
                Name = "Eggplant",
                FoodCategory = ProteinFoods
            });

            _db.SaveChanges();

        }
    }
}
