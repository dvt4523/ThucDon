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
                FoodCategory = ProteinFoods
            });
            _db.SaveChanges();

        }
    }
}
