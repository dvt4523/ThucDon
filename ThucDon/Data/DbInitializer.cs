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
                RawFoodCategory = ProteinFoods
            });

            _db.CarbFoods.Add(new Models.CarbFood
            {
                Calories = 130,
                Protein = 2.7,
                Fat = 3,
                Carb = 78,
                Fiber = 1.6,
                Name = "Rice",
                RawFoodCategory = CarbFoods
            });

            _db.MiscFoods.Add(new Models.MiscFood
            {
                Calories = 27,
                Protein = 1.86,
                Fat = 0,
                Carb = 0,
                Fiber = 2.6,
                Name = "Brocoli",
                RawFoodCategory = MiscFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 258,
                Protein = 25.6,
                Fat = 16.5,
                Carb = 0,
                Fiber = 0,
                Name = "Lamb Chop",
                RawFoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 100,
                Protein = 21,
                Fat = 1,
                Carb = 0,
                Fiber = 0,
                Name = "Sole",
                RawFoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 166,
                Protein = 19,
                Fat = 9,
                Carb = 1,
                Fiber = 0,
                Name = "Sardine",
                RawFoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 138,
                Protein = 23,
                Fat = 4,
                Carb = 0,
                Fiber = 0,
                Name = "Cod",
                RawFoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 262,
                Protein = 24,
                Fat = 18,
                Carb = 1,
                Fiber = 0,
                Name = "Mackerel",
                RawFoodCategory = ProteinFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 120,
                Protein = 20,
                Fat = 3.8,
                Carb = 0,
                Fiber = 0,
                Name = "Salmon",
                RawFoodCategory = ProteinFoods
            });

            _db.CarbFoods.Add(new Models.CarbFood
            {
                Calories = 89,
                Protein = 1.1,
                Fat = 4,
                Carb = 23,
                Fiber = 0,
                Name = "Banana",
                RawFoodCategory = CarbFoods
            });

            _db.CarbFoods.Add(new Models.CarbFood
            {
                Calories = 68,
                Protein = 2.4,
                Fat = 1.4,
                Carb = 12,
                Fiber = 1.7,
                Name = "Oats",
                RawFoodCategory = CarbFoods
            });

            _db.ProteinFoods.Add(new Models.ProteinFood
            {
                Calories = 242,
                Protein = 27,
                Fat = 14,
                Carb = 60,
                Fiber = 0,
                Name = "Pork",
                RawFoodCategory = ProteinFoods
            });

            _db.MiscFoods.Add(new Models.MiscFood
            {
                Calories = 18,
                Protein = 0,
                Fat = 0,
                Carb = 5.8,
                Fiber = 2.2,
                Name = "Tomato",
                RawFoodCategory = MiscFoods
            });

            _db.CarbFoods.Add(new Models.CarbFood
            {
                Calories = 87,
                Protein = 1.9,
                Fat = 0,
                Carb = 20,
                Fiber = 1.8,
                Name = "Potato",
                RawFoodCategory = CarbFoods
            });

            _db.MiscFoods.Add(new Models.MiscFood
            {
                Calories = 20,
                Protein = 1,
                Fat = 0,
                Carb = 5,
                Fiber = 3,
                Name = "Eggplant",
                RawFoodCategory = MiscFoods
            });

            _db.FatFoods.Add(new Models.FatFood
            {
                Calories = 353,
                Protein = 25,
                Fat = 33,
                Carb = 1.3,
                Fiber = 0,
                Name = "Cheese",
                RawFoodCategory = FatFoods
            });

            _db.FatFoods.Add(new Models.FatFood
            {
                Calories = 160,
                Protein = 2,
                Fat = 15,
                Carb = 9,
                Fiber = 7,
                Name = "Avocado",
                RawFoodCategory = FatFoods
            });

            _db.FatFoods.Add(new Models.FatFood
            {
                Calories = 553,
                Protein = 18,
                Fat = 44,
                Carb = 30,
                Fiber = 3.3,
                Name = "Cashews",
                RawFoodCategory = FatFoods
            });

            _db.SaveChanges();

        }
    }
}
